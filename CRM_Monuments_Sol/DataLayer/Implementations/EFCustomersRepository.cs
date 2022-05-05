using DataLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;

namespace DataLayer.Implementations
{
    public class EFCustomersRepository : ICustomersRepository
    {
        private EFDBContext _context;

        public EFCustomersRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustomersByIdContract(int contractId)     //получить весь список, относящийся к определенному договору
        {
            return _context.Customers.Where(x => x.Contract.Id == contractId);
        }

        public void DeleteAllCustomersByIdContract(int contractId)
        {
            foreach (Customer c in GetAllCustomersByIdContract(contractId))
            {
                _context.Customers.Remove(c);
            }
            //_context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(int customerId)
        {
            Customer customer = _context.Customers.Find(customerId);
            return customer;
            //throw new NotImplementedException();
        }

        public void SaveCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                customer.Id = 0;
                _context.Customers.Add(customer);
            }

            else
            {
                _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
