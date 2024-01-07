using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneCustomer(Customer customer)=>Create(customer);


        public void DeleteOneCustomer(Customer? customer)=>Remove(customer);


        public IQueryable<Customer> GetAllCustomers(bool trackChanges)=>FindAll(trackChanges);


        public Customer? GetOneCustomer(int id, bool trackChanges)
        {
            return FindByCondition(c=>c.CustomerId.Equals(id),trackChanges);
        }


    }
}