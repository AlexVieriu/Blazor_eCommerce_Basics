using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string filter = null);

        Product GetProduct(int id);
    }
}
