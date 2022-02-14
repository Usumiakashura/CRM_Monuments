using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IDeceasedsRepository
    {
        public IEnumerable<Deceased> GetAllDeceasedsByIdContract(int contractId);     //получить весь список, относящийся к определенному договору
        public Deceased GetDeceasedById(int deceasedId);    //получить один по айди
        public void SaveDeceased(Deceased deceased);        //сохранить в БД
        public void DeleteDeceased(Deceased deceased);      //удалить из бд
        public void DeleteAllDeceasedsByIdContract(int contractId);      //удалить из бд всех усопших по договору
    }
}
