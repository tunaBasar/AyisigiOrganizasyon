using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }
    public String? ProductName { get; set; } = String.Empty;
    public Decimal ProductPrice { get; set; }

    public String? Description{get; set;}=String.Empty;

    public String? ImageUrl { get; set; }
    public int? CategoryId {get; set;}
    public Category? Category { get; set; }

}
