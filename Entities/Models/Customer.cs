namespace Entities.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        public String? CustomerName {get; set;}=String.Empty;
        public String? CustomerMail {get; set;}=String.Empty;
        public int CustomerPassword {get; set;}


    }
}