using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ITextOnStellaRepository
    {
        public TextOnStella GetTextOnStellaById(int textOnStellaId);        //получить текст, относящийся к усопшему
        public void SaveTextOnStella(TextOnStella stella);                  //сохранить в БД
        public void DeleteTextOnStella(TextOnStella stella);                //удалить из бд
        public void DeleteTextOnStellaByIdDeceased(int deceasedId);         //удалить из бд по айди усопшего
        public void CompleateOnTextName(int idDeceaced, DateTime dateCompleate);    //отметить выполнение текста
    }
}
