using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using ZooManagement.Enums;
using ZooManagement.Models.Data;
using ZooManagement.Models.Request;
using ZooManagement.Models.Response;
using System.Reflection.Metadata.Ecma335;

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
                EnclosureId = animal.EnclosureId,
                EnclosureType = animal.Enclosure.Type.ToString().ToLower(),
            };
    }

    /* create an endpoint to get an animal by it’s ID */
    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var matchingAnimal = _zoo.Animals
            .Include(animal => animal.Species)
            .Include(animal => animal.Enclosure)
            .SingleOrDefault(animal => animal.Id == id);
        if (matchingAnimal == null)
        {
            return NotFound();
        }
        return Ok(AnimalToResponse(matchingAnimal));
    }

    /* create an endpoint to add an animal to the database given the relevant information, , enforce enclosure capacity */
    [HttpPost("add-an-animal")] 
    public IActionResult AddAnimal([FromBody] AddAnimalRequest addAnimalRequest)
    {
        if (addAnimalRequest == null)
        {
            return BadRequest("Invalid animal data.");
        }

        var matchingEnclosure = _zoo.Enclosures // [enclosures] table has no Animals column
            .Include(enclosure => enclosure.Animals) // has to merge with [animals] table, OR: matchingEnclosure.Animals = [] forever
            .SingleOrDefault(enclosure => enclosure.Id == addAnimalRequest.EnclosureId);

        if (matchingEnclosure == null)
        {
            return BadRequest("The enclosure is not found.");
        }
        else if (matchingEnclosure.Animals.Count >= matchingEnclosure.Capacity)
        {
            return BadRequest("This enclosure is full. Please choose another one.");
        }

        var newAnimal = _zoo.Animals.Add(new Animal // adds the new entity (a new Animal object, a new observation/row) to the _zoo.Animals DbSet
        {
            Name = addAnimalRequest.Name,
            SpeciesId = addAnimalRequest.SpeciesId,
            Sex = addAnimalRequest.Sex,
            DateOfBirth = addAnimalRequest.DateOfBirth,
            DateOfAquisition = addAnimalRequest.DateOfAquisition,
            EnclosureId = addAnimalRequest.EnclosureId,
        }).Entity; // this【Entity】property retrieve the actual entity object that was added      

        _zoo.SaveChanges(); // async?

        return Ok(newAnimal);

        // var newAnimalDuplicate = _zoo.Animals
        //     .Include(animal => animal.Species)      
        //     .Include(animal => animal.Enclosure) 
        //     .ThenInclude(enclosure => enclosure.Animals)  
        //     .Single(animal => animal.Id == newAnimal.Id);

        // return Ok(newAnimalDuplicate); // Return a success response (you can also return the created animal)
    }

    /* create an endpoint to list all the types of animals in the zoo */
    [HttpGet("list-all")]
    public IActionResult ListAll()
    {
        var animals = new List<AnimalResponse> {};
        foreach (var animal in _zoo.Animals.Include(animal => animal.Species).Include(animal => animal.Enclosure))
        {
            animals.Add(AnimalToResponse(animal)); 
        }

        animals = animals.OrderBy(animal => -animal.EnclosureId).ThenBy(animal => animal.Name).ToList();

        return Ok(animals);
    }


    /* create an endpoint to deal with a paginated search feature on the frontend: page size/number, search by species, classification, age, name, acquiring date */
    [HttpGet("search")]
    public IActionResult Search([FromQuery] SearchAnimalRequest searchAnimalRequest)
    {
        var query = _zoo.Animals.Include(animal => animal.Species).Include(animal => animal.Enclosure).AsQueryable();

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

        if (!string.IsNullOrEmpty(searchAnimalRequest.EnclosureType))
        { 
            if (Enum.TryParse<EnclosureType>(searchAnimalRequest.EnclosureType, ignoreCase: true, out var enclosureType))
            {
                query = query.Where(animal => animal.Enclosure.Type == enclosureType);
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

        // /* part 3: Allow order choice*/ 
        // var orderKey = "SpeciesName";
        // if (!string.IsNullOrEmpty(searchAnimalRequest.OrderBy))
        // {
        //     orderKey = searchAnimalRequest.OrderBy;
        // }
        //  // Use reflection to get the property info
        // PropertyInfo propertyInfo = typeof(AnimalResponse).GetProperty(orderKey);
        // if (propertyInfo == null)
        // {
        //     return BadRequest($"Property '{orderKey}' not found.");
        // }

        var searchResult = query
            .ToList() // {w/o} The LINQ expression 'DbSet<Animal>().OrderBy(a => __propertyInfo_0.GetValue(obj: AnimalsController.AnimalToResponse(a),index: null))' could not be translated. Either rewrite the query in a form that can be translated, or switch to client evaluation explicitly by inserting a call to 'AsEnumerable', 'AsAsyncEnumerable', 'ToList', or 'ToListAsync'.
            .OrderBy(animal => -animal.EnclosureId).ThenBy(animal => animal.Name)
            .Select(animal => AnimalToResponse(animal))
            // .OrderBy(animal => propertyInfo.GetValue(animal, null))
            .ToList(); // {w/o} 'IOrderedEnumerable<AnimalResponse>' does not contain a definition for 'GetRange' and no accessible extension method 'GetRange' accepting a first argument of type 'IOrderedEnumerable<AnimalResponse>' could be found
        
        /*page choices */
        if (searchAnimalRequest.PageSize < 1 || searchAnimalRequest.PageNumber < 1)
        {
            return BadRequest("Invalid page.");
        }
        int start = searchAnimalRequest.PageSize * (searchAnimalRequest.PageNumber - 1);
        var pageResult = searchResult.GetRange(
                start, 
                Math.Min(searchAnimalRequest.PageSize, searchResult.Count) // when results count less than page size
            );

        return Ok(pageResult);
    }

}

