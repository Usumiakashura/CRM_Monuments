using BuissnesLayer.Interfaces;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFTimesRepository : ITimesRepository
    {
        public IEnumerable<Time> GetAllTimes()
        {
            throw new NotImplementedException();
        }

        public Time GetTimeByName(string nameTime)
        {
            throw new NotImplementedException();
        }

        public void SaveTimes(Time time)
        {
            throw new NotImplementedException();
        }
    }
}
