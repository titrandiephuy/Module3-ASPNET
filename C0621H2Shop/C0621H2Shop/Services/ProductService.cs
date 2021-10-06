﻿using System;
using System.Collections.Generic;
using System.Linq;
using C0621H2Shop.Contexts;
using C0621H2Shop.Entities;
using C0621H2Shop.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace C0621H2Shop.Services
{
    public class ProductService : IProductService
    {
        private readonly C0621H1ShopDBContext context;
        public ProductService(C0621H1ShopDBContext context)
        {
            this.context = context;
        }
        public bool Create(CreateProduct model)
        {
            try
            {
                var product = new Product()
                {
                    CategoryId = model.CategoryId,
                    Pictures = model.Pictures,
                    ProductName = model.ProductName,
                    Quantity = model.Quantity
                };
                context.Add(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(EditProduct model)
        {
            try
            {
                var product = Get(model.ProductId);
                product.CategoryId = model.CategoryId;
                product.Pictures = model.Pictures;
                product.Price = model.Price;
                product.ProductName = model.ProductName;
                product.Quantity = model.Quantity;
                product.ProductId = model.ProductId;
                context.Attach(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Product Get(int productId)
        {
            return context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
