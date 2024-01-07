using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CustomerManager:ICustomerService
    {
        private readonly IRepositoryManager _manager;

        public CustomerManager(IRepositoryManager manager)
        {
            _manager=manager;
        }

        public void CreateCustomer(Customer customer)
        {
            _manager.Customer.Create(customer);
            _manager.Save();
        }

        public void DeleteOneCustomer(int id)
        {
            Customer customer=GetOneCustomer(id,false);
            if(customer is not null)
            {
                _manager.Customer.DeleteOneCustomer(customer);
                _manager.Save();
            }
        }

        public IEnumerable<Customer> GetAllCustomer(bool trackChanges)
        {
            return _manager.Customer.GetAllCustomers(trackChanges);
        }



        public Customer? GetOneCustomer(int id, bool trackChanges)
        {
            var customer=_manager.Customer.GetOneCustomer(id,trackChanges);
            if(customer==null)
                throw new Exception("Customer Not Found");
            return customer;
        }

        public void UpdateOneCustomer(Customer customer)
        {
            var entitiy = _manager.Customer.GetOneCustomer(customer.CustomerId,true);
            entitiy.CustomerName=customer.CustomerName;
            entitiy.CustomerMail=customer.CustomerMail;
            entitiy.CustomerPassword=customer.CustomerPassword;
            _manager.Save();
        }

        
    }
}