using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Application.ViewModels.Customer;

namespace WareHouseMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCustomersForList();
        int AddCustomer(NewCustomerVm customer);
        CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
