using System;
using System.Collections.Generic;
using C0621H2Shop.Entities;
using C0621H2Shop.Models.Product;

namespace C0621H2Shop.Services
{
    public interface IProductService
    {
        List<Product> GetProductByCategoryId(int CategoryId);
        Product Get(int productId);
        bool Create(CreateProduct model);
        bool Edit(EditProduct model);
    }
}
