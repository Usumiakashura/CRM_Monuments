using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFContractsRepository : IContractsRepository
    {
        private EFDBContext _context;
        private ICustomersRepository _customersRepository;
        private IDeceasedsRepository _deceasedsRepository;
        private IAccessorriesRepository _accessorriesRepository;

        public EFContractsRepository(EFDBContext context)
        {
            _context = context;
            _customersRepository = new EFCustomersRepository(_context);
            _deceasedsRepository = new EFDeceasedsRepository(_context);
            _accessorriesRepository = new EFAccessorriesRepository(_context);
        }

        public IEnumerable<Contract> GetAllContracts()     //получить весь список
        {
            List<Contract> contracts = new List<Contract>();
            foreach (Contract c in _context.Contracts
                .Include(c => c.Customers)
                .Include(c => c.OtherPhotoOnMonuments))
            {
                FillContractLists(c);
                contracts.Add(c);
            }
            return contracts;
        }

        public Contract GetContractById(int contractId)    //получить один по айди
        {
            Contract contract = _context.Contracts.Find(contractId);
            FillContractLists(contract);   //достаем из бд всех заказчиков, усопших и комплектующих в договор
            return contract;
        }

        public void SaveContract(Contract contract)        //сохранить в БД
        {
            if (contract.Id == 0)
                _context.Contracts.Add(contract);
            else
            {
                //Contract con = GetContractById(contract.Id);
                
                foreach (Customer c in contract.Customers)
                {
                    _customersRepository.SaveCustomer(c);
                }
                foreach (Deceased d in contract.Deceaseds)
                {
                    _deceasedsRepository.SaveDeceased(d);
                }
                _context.Entry(contract).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
                
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteContract(Contract contract)      //удалить из бд
        {
            //_customersRepository.DeleteAllCustomersByIdContract(contract.Id);
            //_context.Contracts.Remove(contract);
            //_context.SaveChanges();
            throw new NotImplementedException();
        }

        public string NewNumber()
        {
            List<string> allIds = new List<string>();
            int maxNum = 1, num;
            foreach (Contract c in _context.Contracts)
            {
                if (Int32.TryParse(c.Number, out num))
                {
                    maxNum = num > maxNum ? num : maxNum ;
                }
            }
            return (maxNum + 1).ToString();
        }

        //----------------------
        private void FillContractLists(Contract contract)
        {
            foreach (Customer c in _customersRepository.GetAllCustomersByIdContract(contract.Id)) { }
            foreach (Deceased d in _deceasedsRepository.GetAllDeceasedsByIdContract(contract.Id)) { }
            foreach (Accessorie a in _accessorriesRepository.GetAllAccessoriesByIdContract(contract.Id)) { }
        }


    }
}
