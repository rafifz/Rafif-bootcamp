using Microsoft.EntityFrameworkCore;


//DbContext is from EntityFrameworkCore
//it can contain a virtual method for communicate or open connection to database
class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("FileName=./Northwind.db");
    }
}