using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IContractsRepository
    {
        public IEnumerable<Contract> GetAllContracts();     //получить весь список
        public Contract GetContractById(int contractId);    //получить один по айди
        public void SaveContract(Contract contract);        //сохранить в БД
        public void DeleteContract(Contract contract);      //удалить из бд
        public string NewNumber();
    }
}
