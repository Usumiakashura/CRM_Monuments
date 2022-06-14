using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IDeceasedsRepository
    {
        public IEnumerable<Deceased> GetAllDeceasedsByIdStella(int stellaId);     //получить весь список, относящийся к определенной стелле
        public Deceased GetDeceasedById(int deceasedId);    //получить один по айди
        
        //public void CompleateOnTextEpitaph(int idDeceaced, DateTime dateCompleate); //отметить выполнение текста эпитафии
        public void SaveDeceased(Deceased deceased);        //сохранить в БД
        public void DeleteDeceased(Deceased deceased);      //удалить из бд
        public void DeleteAllDeceasedsByIdStella(int stellaId);      //удалить из бд всех усопших на стелле
    }
}
