using DataLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;

namespace DataLayer.Implementations
{
    public class EFContractsRepository : IContractsRepository
    {
        private EFDBContext _context;
        private ICustomersRepository _customersRepository;
        private IStellaRepository _stellaRepository;

        public EFContractsRepository(EFDBContext context)
        {
            _context = context;
            _customersRepository = new EFCustomersRepository(_context);
            _stellaRepository = new EFStellaRepository(_context);
        }

        public IEnumerable<Contract> GetAllContracts()     //получить весь список
        {
            List<Contract> contracts = new List<Contract>();
            foreach (Contract c in _context.Contracts
                .Include(c => c.Customers)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.TextOnStella)
                    .ThenInclude(x => x.TypeText)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.Epitaphs)
                    .ThenInclude(x => x.TypeText)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.PhotosOnMonument)
                )
            {
                //FillContractLists(c);
                contracts.Add(c);
            }
            return contracts;
        }

        public Contract GetContractById(int contractId)    //получить один по айди
        {
            Contract contract = _context.Contracts
                .Include(c => c.Customers)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.TextOnStella)
                    .ThenInclude(x => x.TypeText)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.Epitaphs)
                    .ThenInclude(x => x.TypeText)
                .Include(x => x.Stellas)
                    .ThenInclude(x => x.Deceaseds)
                    .ThenInclude(x => x.PhotosOnMonument)
                .First(x => x.Id == contractId);
            //FillContractLists(contract);   //достаем из бд всех заказчиков, усопших и комплектующих в договор
            return contract;
        }

        public void SaveContract(Contract contract)        //сохранить в БД
        {
            if (contract.Id == 0)
                _context.Contracts.Add(contract);
            else
            {
                foreach (Customer c in contract.Customers)
                {
                    _customersRepository.SaveCustomer(c);
                }
                foreach (Stella s in contract.Stellas)
                {
                    _stellaRepository.SaveStella(s);
                }
                _context.Entry(contract).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteContract(Contract contract)      //удалить из бд
        {
            _customersRepository.DeleteAllCustomersByIdContract(contract.Id);
            _stellaRepository.DeleteAllStellasByIdContract(contract.Id);
            //_accessorriesRepository.DeleteAllAccessoriesByIdContract(contract.Id);
            _context.Contracts.Remove(contract);
            _context.SaveChanges();
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
            foreach (Stella s in _stellaRepository.GetAllStellasByIdContract(contract.Id)) { }
            //foreach (Accessorie a in _accessorriesRepository.GetAllAccessoriesByIdContract(contract.Id)) { }
        }


    }
}
