using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
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
            //List<Customer> customers = new List<Customer>();
            //foreach (Customer c in _context.Customers.Where(x => x.Contract.Id == contractId))
            //{
            //    customers.Add(c);
            //}
            //return customers;
            return _context.Customers.Where(x => x.Contract.Id == contractId);
        }

        //public Customer GetCustomerById(int customerId)    //получить один по айди
        //{
        //    Customer customer = _context.Customers.Find(customerId);
        //    FillCustomerPhones(customer);
        //    return customer;
        //}

        //public void SaveCustomer(Customer customer)        //сохранить в БД
        //{
        //    if (customer.Id == 0) 
        //        _context.Customers.Add(customer);
        //    else
        //        _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    _context.SaveChanges();

        //    //????????????????????????????????????????????????????
        //    //customer.Id = _context.Customers.Last<Customer>().Id;
        //    //foreach (Phone p in customer.Phones)
        //    //{
        //    //    _phonesRepository.SavePhone(p);
        //    //}
        //    //_context.SaveChanges();
        //    //????????????????????????????????????????????????????
        //}

        //public void DeleteCustomer(Customer customer)      //удалить из бд
        //{
        //    _phonesRepository.DeleteAllPhonesByIdCustomer(customer.Id);
        //    _context.Customers.Remove(customer);
        //    _context.SaveChanges();
        //}

        //public void DeleteAllCustomersByIdContract(int contractId)      //удалить из бд всех заказчиков по договору
        //{
        //    foreach (Customer c in GetAllCustomersByIdContract(contractId))
        //    {
        //        DeleteCustomer(c);
        //    }
        //}

        ////----------------------
        //private void FillCustomerPhones(Customer customer)
        //{
        //    foreach (Phone p in _phonesRepository.GetAllPhonesByIdCustomer(customer.Id))
        //    {
        //        customer.Phones.Add(p);
        //    }
        //}
        public void DeleteAllCustomersByIdContract(int contractId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            Customer customer = _context.Customers.Find(customerId);
            return customer;
            //throw new NotImplementedException();
        }

        public void SaveCustomer(Customer customer)
        {
            if (customer.Id != 0)
            {
                if (customer.Id == -1)
                {
                    customer.Id = 0;
                    _context.Customers.Add(customer);
                }
                    
                else
                {
                    _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
            }
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
