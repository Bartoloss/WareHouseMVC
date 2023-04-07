using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Model;
using Type = WareHouseMVC.Domain.Model.Type;

namespace WareHouseMVC.Domain.Interface
{
    public interface IProductRepository
    {
        void DeleteProduct(int productId);

        int AddProduct(Product product);

        IQueryable<Product> GetProductsByTypeId(int typeId);

        Product? GetItemById(int itemId);

        IQueryable<Tag> GetAllTags();

        IQueryable<Type> GetAllTypes();
        
    }
}
