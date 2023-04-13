using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMVC.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Size { get; set; }  
        public int Amount { get; set; }
        public float Price { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }

        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
