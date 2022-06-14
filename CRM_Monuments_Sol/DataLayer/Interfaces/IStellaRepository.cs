using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IStellaRepository
    {
        public IEnumerable<Stella> GetAllStellasByIdContract(int contractId);       //получить весь список, относящийся к определенному договору
        public Stella GetStellaById(int stellaId);                                  //получить одну по айди
        public void SaveStella(Stella stella);                                      //сохранить в БД
        public void DeleteStella(Stella stella);                                    //удалить из бд
        public void DeleteAllStellasByIdContract(int contractId);                   //удалить из бд все стеллы по договору
    }
}
