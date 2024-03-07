using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Enums;
using ZooManagement.Models.Data;
using ZooManagement.Models.Request;
using ZooManagement.Models.Response;

namespace ZooManagement.Controllers;

[ApiController]
[Route("/animals")]
public class AnimalsController: Controller
{
    private readonly Zoo _zoo;

    public AnimalsController(Zoo zoo)
    {
        _zoo = zoo;
    }

    private static AnimalResponse AnimalToResponse(Animal animal)
    {
        return new AnimalResponse
            {
                Name = animal.Name, 
                SpeciesName = animal.Species.Name, // animal.Species? 【Species defaul as null! ==> need eager loading
                Classification = animal.Species.Classification.ToString().ToLower(), // .Include(animal => animal.Species)
                Sex = animal.Sex.ToString().ToLower(),
                DateOfBirth = animal.DateOfBirth,
                DateOfAquisition = animal.DateOfAquisition,
            };
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var matchingAnimal = _zoo.Animals
            .Include(animal => animal.Species)
            .SingleOrDefault(animal => animal.Id == id);
        if (matchingAnimal == null)
        {
            return NotFound();
        }
        return Ok(AnimalToResponse(matchingAnimal));
    }

    [HttpPost("add-an-animal")]
    public IActionResult AddAnimal([FromBody] AddAnimalRequest addAnimalRequest)
    {
        if (addAnimalRequest == null)
        {
            return BadRequest("Invalid animal data.");
        }

        var newAnimal = _zoo.Animals.Add(new Animal // adds the new entity (the new Animal object) to the _zoo.Animals DbSet
        {
            Name = addAnimalRequest.Name,
            SpeciesId = addAnimalRequest.SpeciesId,
            Sex = addAnimalRequest.Sex,
            DateOfBirth = addAnimalRequest.DateOfBirth,
            DateOfAquisition = addAnimalRequest.DateOfAquisition,
        }).Entity; // this【Entity】property retrieve the actual entity object that was added      

        _zoo.SaveChangesAsync();
        
        // Return a success response (you can also return the created animal)
        return Ok(newAnimal);
    }

    [HttpGet("list-all")]
    public IActionResult ListAll()
    {
        var animals = new List<AnimalResponse> {};
        foreach (var animal in _zoo.Animals.Include(animal => animal.Species))
        {
            animals.Add(AnimalToResponse(animal));
        }

        return Ok(animals);
    }

    // input a page size and a page number 
    // return a list of animals corresponding with the the associated list of animals for the given page
    // filtered by a search query that can search by species, classification (mammal/reptile/bird etc.), age (as a number not a date of birth), name and date the zoo acquired them

    [HttpGet("search")]
    public IActionResult Search([FromQuery] SearchAnimalRequest searchAnimalRequest)
    {
        var query = _zoo.Animals.Include(animal => animal.Species).AsQueryable();
        if (!string.IsNullOrEmpty(searchAnimalRequest.Name))
        {
            query = query.Where(animal => animal.Name.Contains(searchAnimalRequest.Name));
        }

        if (!string.IsNullOrEmpty(searchAnimalRequest.SpeciesName))
        {
            query = query.Where(animal => animal.Species.Name.Contains(searchAnimalRequest.SpeciesName));
        }

        if (!string.IsNullOrEmpty(searchAnimalRequest.ClassificationName))
        { 
            if (Enum.TryParse<Classification>(searchAnimalRequest.ClassificationName, ignoreCase: true, out var classification))
            {
                query = query.Where(animal => animal.Species.Classification == classification);
            }
            else
            {
                query = Enumerable.Empty<Animal>().AsQueryable();
            }
        }

        if (!string.IsNullOrEmpty(searchAnimalRequest.SexName))
        { 
            if (Enum.TryParse<Sex>(searchAnimalRequest.SexName, ignoreCase: true, out var sex))
            {
                query = query.Where(animal => animal.Sex == sex);
            }
            else
            {
                query = Enumerable.Empty<Animal>().AsQueryable();
            }
        }

        var searchResult = query.ToList();

        return Ok(searchResult);
    }

}

