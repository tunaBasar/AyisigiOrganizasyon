using Entities.Models;

namespace Services.Contracts
{
    public interface ICustomerService
    {
        IEnumerable<Customer>GetAllCustomer(bool trackChanges);

        Customer? GetOneCustomer(int id,bool trackChanges);

        void CreateCustomer(Customer customer);

        void UpdateOneCustomer(Customer customer);

        void DeleteOneCustomer(int id);

    }
}