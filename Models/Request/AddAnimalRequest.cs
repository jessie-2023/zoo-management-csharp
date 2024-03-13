using ZooManagement.Enums;

namespace ZooManagement.Models.Request;

public class AddAnimalRequest
{
    public required string Name { get; set; }
    public int SpeciesId { get; set; }
    public int EnclosureId { get; set; }
    public required Sex Sex { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public required DateTime DateOfAquisition { get; set; }
    
}