using ZooManagement.Enums;

namespace ZooManagement.Models.Request;

public class SearchAnimalRequest
{
    public int PageSize { get; set; } = 10;
    public int PageNumber { get; set; } = 1;
    public string? OrderBy { get; set; } 
    public string? Name { get; set; }
    public string? SpeciesName { get; set; }
    public string? ClassificationName { get; set; }
    public string? EnclosureType { get; set; }
    public string? SexName { get; set; }
    public int? MaxAgeByDays { get; set; }
    public int? MinAgeByDays { get; set; }
    
}