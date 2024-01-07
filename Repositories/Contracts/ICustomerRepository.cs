using Entities.Models;
using SQLitePCL;

namespace Repositories.Contracts
{
    public interface ICustomerRepository:IRepositoryBase<Customer>
    {
        IQueryable<Customer>GetAllCustomers(bool trackChanges);

        Customer? GetOneCustomer(int id,bool trackChanges);

        void CreateOneCustomer(Customer customer);

        void DeleteOneCustomer(Customer? customer);


    }
}