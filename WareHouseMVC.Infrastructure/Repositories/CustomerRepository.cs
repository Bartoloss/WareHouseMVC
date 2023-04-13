using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Interface;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;
        public CustomerRepository(Context context)
        {
            _context = context;
        }
        public int AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

        public void DeleteCustomer(int customerId)
        {
            Customer? customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customer? GetCustomerById(int customerId)
        {
            Customer? customer = _context.Customers.FirstOrDefault(i => i.Id == customerId);
            return customer;
        }
    }
}
