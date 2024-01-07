using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        [Required(ErrorMessage = "Düğün İsmi Gerekli!")]
        public String? ProductName { get; init; } = String.Empty;
        [Required(ErrorMessage = "Fiyat Gerekli!")]
        public Decimal ProductPrice { get; init; }
        public String? Description { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; init; }

    }
}