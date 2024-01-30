using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required, StringLength(40)]
    public string ProductName { get; set; } = null!;

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
    
    [Column("UnitPrice", TypeName = "money")] //column = real property name in db
    public double Cost { get; set; } // changed name

    [Column("UnitsInStock", TypeName = "smallint")] 
    public short Stock { get; set; }
}
