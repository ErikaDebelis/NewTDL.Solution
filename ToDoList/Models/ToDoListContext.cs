using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

// class Pet
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// public static void OrderByEx1()
// {
//     Pet[] pets = { new Pet { Name="Barley", Age=8 },
//                    new Pet { Name="Boots", Age=4 },
//                    new Pet { Name="Whiskers", Age=1 } };

//     IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

//     foreach (Pet pet in query)
//     {
//         Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
//     }
// }