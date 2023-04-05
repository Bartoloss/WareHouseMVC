using System.ComponentModel;

namespace WareHouseMVC.Web.Models
{
    public class Category
    {
        [DisplayName("Identyfikator")]
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
    }
}
