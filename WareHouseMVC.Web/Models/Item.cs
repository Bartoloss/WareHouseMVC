using System.ComponentModel;

namespace WareHouseMVC.Web.Models
{
    public class Item
    {
        [DisplayName("Identyfikator")]
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Kategoria")]
        public string CategoryName { get; set; }
    }
}
