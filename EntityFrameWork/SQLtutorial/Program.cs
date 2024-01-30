using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static async Task Main(string[] args)
    {
       // Read from data base
        using (Northwind dbRead = new())
        {
            Console.WriteLine("can connect to database : " + dbRead.Database.CanConnect());
            var categories = dbRead.Categories.Include(p => p.Products).ToList();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId} : {category.CategoryName}".ToUpper());

                //iterate every product in category
                //.Where((p => p.Cost > 20)) is for  filtering products with cost greater than 20
                //can use other LINQ operation
                foreach (var product in category.Products.Where((p => p.Cost > 20)))
                {
                    Console.WriteLine($"    {product.ProductId} : {product.ProductName}, ${product.Cost}");
                }
            }
        }

        //Create data base
        using (Northwind dbCreate = new())
        {
            Category newCategory = new Category()
            {
                //CategoryId otomatis
                CategoryName = "Weapon",
                Description = "membuat kategori weapon"
            };
            await dbCreate.Categories.AddAsync(newCategory);
            await dbCreate.SaveChangesAsync(); // must be saved to commit the update
            Console.WriteLine($"succesfully create Category {newCategory.CategoryName}");
        }
        //Update data base
        using (Northwind dbUpdate = new())
        {
            var toBeUpdated = dbUpdate.Categories.Find(10); // search using id Find(9)
            //var result2 = await dbUpdate.Categories.FirstOrDefaultAsync(c => c.CategoryName.Contains("Mobil")); //search using First or default
            if (toBeUpdated != null)
            {
                toBeUpdated.CategoryName = "Gadget";
                toBeUpdated.Description = "update menjadi Gadget";
            }
            await dbUpdate.SaveChangesAsync();
            Console.WriteLine($"updated to {toBeUpdated?.CategoryName}");
        }

        //Delete data base
        using (Northwind dbDelete = new())
        {
            var toBeDeleted = dbDelete.Categories.Where(p => p.CategoryName == "Weapon");
            Console.WriteLine($"deleting weapon from database");
            dbDelete.Categories.RemoveRange(toBeDeleted);
            await dbDelete.SaveChangesAsync();
        }
    }
}
