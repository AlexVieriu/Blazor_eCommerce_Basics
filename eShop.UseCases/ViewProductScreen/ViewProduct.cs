using eShop.UseCases.PluginInterfaces;
using eShop.CoreBusiness.Models;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProduct: IViewProduct
    {
        private readonly IProductRepository _productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}
