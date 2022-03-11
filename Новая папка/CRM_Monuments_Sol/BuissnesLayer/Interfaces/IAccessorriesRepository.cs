using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IAccessorriesRepository
    {
        public IEnumerable<Accessorie> GetAllAccessoriesByIdContract(int contractId);     //получить весь список, относящийся к определенному договору
        public Accessorie GetAccessorieById(int accessorieId);    //получить один по айди
        public void SaveAccessorie(Accessorie accessorie);        //сохранить в БД
        public void DeleteAccessorie(Accessorie accessorie);      //удалить из бд
        public void DeleteAllAccessoriesByIdContract(int contractId);      //удалить из бд все комплектующие по договору
    }
}
