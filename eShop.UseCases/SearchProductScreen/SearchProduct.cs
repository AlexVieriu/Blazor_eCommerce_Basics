﻿using eShop.UseCases.PluginInterfaces;
using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository _productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string filter=null)
        {
            return _productRepository.GetProducts(filter);
        }
    }
}
