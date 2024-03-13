
using System.ComponentModel.DataAnnotations.Schema;
using ZooManagement.Enums;

namespace ZooManagement.Models.Data;

public class Enclosure
{
    public int Id { get; set; }

    public required EnclosureType Type {get; set; }

    public int Capacity { get; set; }

    [InverseProperty(nameof(Animal.Enclosure))]
    public List<Animal> Animals { get; set; } = [];
    
    public int Population => Animals.Count;

    // [InverseProperty(nameof(Animal.Enclosure))]
    // public Animal[] Animals { get; set; }

    // public Enclosure()
    // {
    //     // 在构造函数中设置 Capacity: all Capacity = 10
    //     Capacity = Type switch
    //     {
    //         EnclosureType.Lion => 10,
    //         EnclosureType.Aviary => 50,
    //         EnclosureType.Reptile => 40,
    //         EnclosureType.Giraffe => 6,
    //         EnclosureType.Hippo => 10,
    //         EnclosureType.Others => 1000,
    //         _ => throw new ArgumentOutOfRangeException(nameof(Type)),
    //     };

    //     // Animals = new Animal[Capacity];
    // }

    
    

}