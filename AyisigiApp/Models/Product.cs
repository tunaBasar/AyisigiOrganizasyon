namespace AyisigiApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public String? ProductName { get; set; }=String.Empty;

        public Decimal ProductPrice { get; set; }
    }
}