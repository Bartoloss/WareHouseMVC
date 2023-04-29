using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Application.Interfaces;
using WareHouseMVC.Application.ViewModels.Customer;
using WareHouseMVC.Domain.Interface;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;


        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCustomersForList()
        {
            IQueryable<Customer> customers = _customerRepo.GetAllActiveCustomers();
            ListCustomerForListVm result = new ListCustomerForListVm();
            result.Customers = new List<CustomerForListVm>();
            foreach (Customer customer in customers)
            {
                CustomerForListVm custVm = new CustomerForListVm()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    NIP = customer.NIP,
                };
                result.Customers.Add(custVm);
            }
            result.Count = result.Customers.Count;
            return result;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            Customer? customer = _customerRepo.GetCustomerById(customerId);
            CustomerDetailsVm customerVm = new CustomerDetailsVm();
            customerVm.Id = customer.Id;
            customerVm.Name = customer.Name;
            customerVm.NIP = customer.NIP;
            customerVm.REGON = customer.Regon;
            customerVm.CEOFullName = customer.CEOName + " " + customer.CEOLastName;
            CustomerContactInformation custConInfo = customer.CustomerContactInformation;
            customerVm.FirstLineOfContactInformation = custConInfo.FirstName + " " + custConInfo.LastName;

            customerVm.Addresses = new List<AddressForListVm>();
            customerVm.PhoneNumbers = new List<ContactDetailListVm>();
            customerVm.Emails = new List<ContactDetailListVm>();

            foreach (CustomerAddress address in customer.CustomerAddresses)
            {
                AddressForListVm add = new AddressForListVm()
                {
                    Id = address.Id,
                    Country = address.Country,
                    City = address.City,
                };
                customerVm.Addresses.Add(add);
            }

            foreach (Customer  address in customer.CustomerAddresses)
            {
                AddressForListVm add = new AddressForListVm()
                {
                    Id = address.Id,
                    Country = address.Country,
                    City = address.City,
                };
                customerVm.Addresses.Add(add);
            }
        }
    }
}
