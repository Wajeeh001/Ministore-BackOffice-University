using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _product;


        public InMemoryProductService() { 
            _product = new List<Product>();
            GenerateFakeProducts();
        }





        public Product Add(Product product) {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            return false;
        }

        public bool Delete(string id)
        {
            return false;
        }

        public List<Product> GetAll()
        {
            return _product.OrderBy(p => p.Name).ToList();
        }

        public Product GetById(string id)
        {
           throw new NotImplementedException();
        }

        public List<Product> Search(string text, ProductCatagoryEnum? catagory, ProductStatusEnum? status)
        {
            throw new NotFiniteNumberException();
        }

        public void GenerateFakeProducts()
        {
            _product.Clear();
            _product.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Catagory = ProductCatagoryEnum.Electronics,
                Price = 15000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });

            _product.Add(new Product
            {
                Id = GenerateId(),
                Name = "Book",
                Catagory = ProductCatagoryEnum.Stationary,
                Price = 1000.00m,
                Stock = 20,
                Status = ProductStatusEnum.Inactive
            });

            _product.Add(new Product
            {
                Id = GenerateId(),
                Name = "Shirt",
                Catagory = ProductCatagoryEnum.Clothing,
                Price = 150.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });
        }


        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}
