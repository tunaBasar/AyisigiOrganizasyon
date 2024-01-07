using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ICustomerService _customerService;

        public ServiceManager(IProductService productService, 
        ICategoryService categoryService,ICustomerService customerService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _customerService=customerService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public ICustomerService CustomerService => _customerService;

        
    }
}