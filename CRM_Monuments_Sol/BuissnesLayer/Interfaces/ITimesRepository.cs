using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface ITimesRepository
    {
        public IEnumerable<Time> GetAllTimes();   // получить все сроки;
        public void SaveTimes(Time time);     // сохранить сроки в базе данных;
        public Time GetTimeByName(string nameTime); // получить срок по названию
    }
}
