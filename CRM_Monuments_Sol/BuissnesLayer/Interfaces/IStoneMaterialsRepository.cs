using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IStoneMaterialsRepository
    {
        public IEnumerable<StoneMaterial> GetAllStoneMaterials();     //получить весь список
        public StoneMaterial GetStoneMaterialById(int accessorieId);    //получить один по айди
        public void SaveStoneMaterial(StoneMaterial stoneMaterial);        //сохранить в БД
        public void DeleteStoneMaterial(StoneMaterial stoneMaterial);      //удалить из бд
    }
}
