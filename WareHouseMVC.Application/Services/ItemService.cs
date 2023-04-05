using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Application.Interfaces;

namespace WareHouseMVC.Application.Services
{
    public class ItemService : IItemService
    {

        public List<int> GetAllItems()
        {
            List<int> items = new List<int>();
            items.Add(0);
            items.Add(1);
            items.Add(2);   
            items.Add(3);
            items.Add(4);
            items.Add(5);
            return items;
        }
    }
}
