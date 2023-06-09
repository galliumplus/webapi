﻿using GalliumPlus.WebApi.Core;
using GalliumPlus.WebApi.Core.Data;
using GalliumPlus.WebApi.Core.Stocks;
using System.Reflection;

namespace GalliumPlus.WebApi.Data.FakeDatabase
{
    public class ProductDao : BaseDaoWithAutoIncrement<Product>, IProductDao
    {
        private ICategoryDao categoryDao;

        private Dictionary<int, ProductImage> images = new();

        public ICategoryDao Categories => categoryDao;

        public ProductDao(ICategoryDao categoryDao)
        {
            this.categoryDao = categoryDao;

            string defaultImageName = "GalliumPlus.WebApi.Data.FakeDatabase.images.serial-designation-n.png";
            Stream defaultImageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(defaultImageName)!;
            byte[] defaultImageData = new byte[defaultImageStream.Length];
            defaultImageStream.Read(defaultImageData, 0, defaultImageData.Length);
            ProductImage defaultImage = ProductImage.FromStoredData(defaultImageData);

            int createdId;

            createdId = this.Create(new Product(
                0, "Coca Cherry", 27, 1.00, 0.80,
                Availability.AUTO, categoryDao.Read(0)
            )).Id;
            this.images.Add(createdId, defaultImage);

            createdId = this.Create(new Product(
                0, "KitKat", 14, 0.80, 0.60,
                Availability.AUTO, categoryDao.Read(1)
            )).Id;
            this.images.Add(createdId, defaultImage);

            createdId = this.Create(new Product(
                0, "Pablo", 1, 999.99, 500.00,
                Availability.ALWAYS, categoryDao.Read(2)
            )).Id;
            this.images.Add(createdId, defaultImage);
        }

        protected override int GetKey(Product item) => item.Id;

        protected override void SetKey(Product item, int key) => item.Id = key;

        public override void Delete(int key)
        {
            base.Delete(key);
            this.images.Remove(key);
        }

        public ProductImage ReadImage(int id)
        {
            if (!this.images.ContainsKey(id)) throw new ItemNotFoundException();

            return this.images[id];
        }

        public void SetImage(int id, ProductImage image)
        {
            if (!this.Items.ContainsKey(id)) throw new ItemNotFoundException();

            this.images[id] = image;
        }

        public void UnsetImage(int id)
        {
            if (!this.images.ContainsKey(id)) throw new ItemNotFoundException();

            this.images.Remove(id);
        }
    }
}
