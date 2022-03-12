using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface ISelectPointsRepository
    {
        public IEnumerable<string> GetAllTypesText();
        //public IEnumerable<string> GetAllTypesPortraits();
        public IEnumerable<string> GetAllMedallionsMaterials();
        public IEnumerable<string> GetAllShapesMedallions();
        public IEnumerable<string> GetAllColorsMedallions();
    }
}
