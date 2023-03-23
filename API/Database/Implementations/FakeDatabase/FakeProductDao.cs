﻿using GalliumPlusAPI.Database.Criteria;
using GalliumPlusAPI.Exceptions;
using GalliumPlusAPI.Models;

namespace GalliumPlusAPI.Database.Implementations.FakeDatabase
{
    public class FakeProductDao : IProductDao
    {
        private List<Product> products;

        public FakeProductDao()
        {
            this.products = new List<Product> {
                new Product {
                    Id = 0,
                    Name = "KitKat",
                    Stock = 20,
                    NonMemberPrice = 0.80,
                    MemberPrice = 0.60,
                    Availability = Availability.AUTO,
                    Category = 1,
                },
                new Product {
                    Id = 1,
                    Name = "Coca-Cola Cherry",
                    Stock = 17,
                    NonMemberPrice = 1.00,
                    MemberPrice = 0.80,
                    Availability = Availability.AUTO,
                    Category = 0,
                },
                new Product {
                    Id = 2,
                    Name = "Pablo",
                    Stock = 1,
                    NonMemberPrice = 999.99,
                    MemberPrice = 500.00,
                    Availability = Availability.ALWAYS,
                    Category = 2,
                },
                new Product {
                    Id = 3,
                    Name = "Kinder Bueno",
                    Stock = 0,
                    NonMemberPrice = 1.00,
                    MemberPrice = 0.80,
                    Availability = Availability.AUTO,
                    Category = 1,
                },
                new Product {
                    Id = 4,
                    Name = "Chocolat chaud",
                    Stock = 11,
                    NonMemberPrice = 0.70,
                    MemberPrice = 0.50,
                    Availability = Availability.AUTO,
                    Category = 0,
                },
                new Product {
                    Id = 5,
                    Name = "Madeleine",
                    Stock = 24,
                    NonMemberPrice = 1.00,
                    MemberPrice = 0.80,
                    Availability = Availability.AUTO,
                    Category = 1,
                },
            };
        }

        public void Create(Product product)
        {
            lock (products)
            {
                int id = products.Count;
                product.Id = id;
                this.products.Add(product);
            }
        }

        public IEnumerable<Product> ReadAll()
        {
            return this.products;
        }

        public Product ReadOne(int id)
        {
            try
            {
                return this.products[id];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ItemNotFoundException();
            }
        }

        public void Update(int id, Product product)
        {
            lock (products)
            {
                product.Id = id;
                this.products[id] = product;
            }
        }

        public void Delete(int id)
        {
            lock (products)
            {
                this.products.RemoveAt(id);
            }
        }

        public IEnumerable<Product> ReadAvailable()
        {
            return this.products.FindAll(product => product.Available);
        }

        private static Predicate<Product> ToPredicate(ProductCriteria criteria)
        {
            return product => (!criteria.AvailableOnly || product.Available)
                           && (criteria.Category == null || product.Category == criteria.Category);
        }

        public IEnumerable<Product> FindAll(ProductCriteria criteria)
        {
            return this.products.FindAll(ToPredicate(criteria));
        }
    }
}
