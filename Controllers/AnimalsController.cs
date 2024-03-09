using System.Security.Cryptography;
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

    /* create an endpoint to get an animal by it’s ID */
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

    /* create an endpoint to add an animal to the database given the relevant information */
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
        
        
        return Ok(newAnimal); // Return a success response (you can also return the created animal)
    }

    /* create an endpoint to list all the types of animals in the zoo */
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


    /* create an endpoint to deal with a paginated search feature on the frontend: page size/number, search by species, classification, age, name, acquiring date */
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
        
/*emily: easier way?*/
        if (searchAnimalRequest.MaxAgeByDays != null)
        {
            double maxDays = searchAnimalRequest.MaxAgeByDays ?? 0;
            var earlistDate = DateTime.UtcNow.AddDays(-maxDays);
            query = query.Where(animal => animal.DateOfBirth >= earlistDate);
        } 

        if (searchAnimalRequest.MinAgeByDays != null)
        {
            double minDays = searchAnimalRequest.MinAgeByDays ?? 0;
            query = query.Where(animal => animal.DateOfBirth <= DateTime.UtcNow.AddDays(-minDays)).AsQueryable();
        } 

        if (searchAnimalRequest.PageSize < 1 || searchAnimalRequest.PageNumber < 1)
        {
            return BadRequest("Invalid page.");
        }
        int start = searchAnimalRequest.PageSize * (searchAnimalRequest.PageNumber - 1);

        var searchResult = query.ToList().GetRange(start, searchAnimalRequest.PageSize).Select(animal => AnimalToResponse(animal));

        return Ok(searchResult);
    }

}

