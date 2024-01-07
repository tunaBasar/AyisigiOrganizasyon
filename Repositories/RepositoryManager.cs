using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;

        private readonly ICategoryRepository _categoryRepository;

        private readonly ICustomerRepository _customerRepository;



        public RepositoryManager(IProductRepository 
        productRepository,RepositoryContext context,
        ICategoryRepository categoryRepository,
        ICustomerRepository customerRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _customerRepository=customerRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public ICustomerRepository Customer => _customerRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}