using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage ="Düğün İsmi Gerekli!")]
    public String? ProductName { get; set; } = String.Empty;
    [Required(ErrorMessage ="Fiyat Gerekli!")]
    public Decimal ProductPrice { get; set; }

}
