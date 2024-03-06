/* 造一个Zoo类收纳间，在主程序 builder.Services.AddDbContext<Zoo>(); 句中被点名 */ 

using Microsoft.EntityFrameworkCore;
using ZooManagement.Models.Data;
using ZooManagement.Enums;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic;

namespace ZooManagement;

public class Zoo: DbContext
{
    // Zoo类收纳间里有两种架子：一个挨个儿放Animal形状的物件儿，另一个挨个儿放Species形状的物件儿【物件类型本身的结构的关系在data model里讲
    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<Species> Species { get; set; } = null!;

    // 门牌号码指路
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=zoo; Username=zoo; Password=zoo;");
    }

    // 放几个样品进去瞧瞧
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 随手捏个Species样品备用
        var lion = new Species
        {
            Id = -1,
            Name = "lion",
            Classification = Classification.Mammal,
        };
        // 放到第二个架子上
        modelBuilder.Entity<Species>().HasData(lion);

        // 再捏两个Animal样品，用上刚造的Species模块
        var simba = new Animal
        {
            Id = -1,
            Name = "simba",
            SpeciesId = -1,
            Sex = Sex.Male,
            DateOfBirth = new DateTime(1997, 10, 16).ToUniversalTime(),
            DateOfAquisition = new DateTime(2000, 1, 1).ToUniversalTime(),
        };

        var nala = new Animal
        {
            Id = -2,
            Name = "nala",
            SpeciesId = -1,
            Sex = Sex.Female,
            DateOfBirth = new DateTime(1997, 10, 16).ToUniversalTime(),
            DateOfAquisition = new DateTime(2000, 1, 1).ToUniversalTime(),
        };
        // 放到第一个架子上
        modelBuilder.Entity<Animal>().HasData(simba, nala);

        SeedData(modelBuilder);
    }

    // 批量捏100个
    private static void SeedData(ModelBuilder modelBuilder)
    {
        // 10 species
        for (var n = 2; n <= 11; n++)
        {
            Random random = new Random();
            var species = GenerateSpecies(n, $"species_{n}", random.Next(6));
            modelBuilder.Entity<Species>().HasData(species);

            // 10 animals each
            for (var m = 0; m <= 9; m++)
            {
                int id = n*10+m;
                var animal = GenerateAnimal(id, $"animal_{id}", species.Id, random.Next(2), DateTime.Now.AddDays(-random.Next(3000)), DateTime.Now);
                modelBuilder.Entity<Animal>().HasData(animal);
            }

        }
    }

    private static Species GenerateSpecies(int id, string name, int classification)
    {
        return new Species
        {
            Id = -id,
            Name = name,
            Classification = (Classification)classification,
        };
    }

    private static Animal GenerateAnimal(int id, string name, int speciesId, int sex, DateTime dateOfBirth, DateTime dateOfAquisition)
    {
        return new Animal
        {
            Id = -id,
            Name = name,
            SpeciesId = speciesId,
            Sex = (Sex)sex,
            DateOfBirth = dateOfBirth.ToUniversalTime(),
            DateOfAquisition = dateOfAquisition.ToUniversalTime(),   
        };   
    }



}
