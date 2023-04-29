using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Domain.Interface
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllActiveCustomers();
        void DeleteCustomer(int customerId);

        int AddCustomer(Customer customer);

        Customer? GetCustomerById(int customerId);

    }
}
