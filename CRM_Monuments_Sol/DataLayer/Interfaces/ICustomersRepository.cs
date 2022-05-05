using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ICustomersRepository
    {
        public IEnumerable<Customer> GetAllCustomersByIdContract(int contractId);     //получить весь список, относящийся к определенному договору
        public Customer GetCustomerById(int customerId);    //получить один по айди
        public void SaveCustomer(Customer customer);        //сохранить в БД
        public void DeleteCustomer(Customer customer);      //удалить из бд
        public void DeleteAllCustomersByIdContract(int contractId);      //удалить из бд всех заказчиков по договору
    }
}
