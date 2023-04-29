using Microsoft.AspNetCore.Mvc;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //utworzyć widok dla akcji
            //tabela z klientami
            //utworzenie panelu do filtrowania klientów w tabeli
            //przygotować dane
            //przekazać filtry do serwisu
            //serwis musi przygotować dane
            //serwis musi zwrócić dane w odpowiednim formacie

            List<Customer> model = customerService.GetAllCustomersForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerModel model)
        {
            int id = customerService.AddCustomer(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewAddressForClient(int customerId)
        {

        }

        [HttpPost]
        public IActionResult AddNewAddressForClient(AddressModel model)
        {

        }

        public IActionResult ViewCustomer(int customerId)
        {
            Customer customerModel = customerService.GetCustomerDetails(customerId);
            return View(customerModel);

        }


    }
}
