using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IPhotosOnMonumentsRepository
    {
        public IEnumerable<PhotoOnMonument> GetAllPhotoOnMonumentsByIdDeceased(int deceasedId);     //получить весь список, относящийся к определенному договору
        public PhotoOnMonument GetPhotoOnMonumentById(int photoOnMonumentId);    //получить один по айди
        public IEnumerable<Portrait> GetAllPortraits();     //получить все портреты
        //public IEnumerable<Medallion> GetAllMedallions();     //получить все медальоны
        public void CompleateOn(int idPhotoOnMonument, DateTime dateCompleate);  //отметка о выполнении
        public void SavePhotoOnMonument(PhotoOnMonument photoOnMonument);        //сохранить в БД
        public void DeletePhotoOnMonument(PhotoOnMonument photoOnMonument);      //удалить из бд
        public void DeleteAllPhotoOnMonumentByIdDeceased(int deceasedId);      //удалить из бд все фото по усопшему
    }
}
