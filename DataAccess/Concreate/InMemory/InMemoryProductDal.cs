using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1, ProductName="Bag",UnitPrice=45,UnitsInStock=900},
                new Product{ProductId=2,CategoryId=2, ProductName="Camera",UnitPrice=1500,UnitsInStock=150},
                new Product{ProductId=3,CategoryId=1, ProductName="Macbook",UnitPrice=1450,UnitsInStock=250},
                new Product{ProductId=4,CategoryId=1, ProductName="Pencil",UnitPrice=10,UnitsInStock=200},
                new Product{ProductId=5,CategoryId=1, ProductName="Book",UnitPrice=15,UnitsInStock=400},
            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null; // Product productToDelete = new Product(); => unnessarry allocate in memory

            //foreach(Product p in _products)
            //{
            //    if (product.ProductId == p.ProductId) productToDelete = p;
            //} if didn't use LINQ , find the id of the referance holder

            //LINQ - Language Integrated Query
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete); // _products.Remove(product) ==> Error
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitPrice = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}

