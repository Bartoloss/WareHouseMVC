using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Interface;
using WareHouseMVC.Domain.Model;
using Type = WareHouseMVC.Domain.Model.Type;

namespace WareHouseMVC.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public void DeleteProduct(int productId)
        {
            Product? product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public int AddProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public IQueryable<Product> GetProductsByTypeId(int typeId)
        {
            IQueryable<Product> products = _context.Products.Where(i => i.TypeId == typeId);
            return products;
        }

        public Product? GetItemById(int itemId)
        {
            Product? product = _context.Products.FirstOrDefault(i => i.Id == itemId);
            return product;
        }

        public IQueryable<Tag> GetAllTags()
        {
            IQueryable<Tag> tags = _context.Tags;
            return tags;
        }

        public IQueryable<Type> GetAllTypes()
        {
            IQueryable<Type> types = _context.Types;
            return types;
        }
    }

}
