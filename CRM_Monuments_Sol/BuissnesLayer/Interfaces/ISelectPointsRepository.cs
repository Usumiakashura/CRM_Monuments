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
        public IEnumerable<TypeText> GetAllTypesText();
        //public IEnumerable<string> GetAllTypesPortraits();
        public IEnumerable<MedallionMaterial> GetAllMedallionsMaterials();
        public IEnumerable<ShapeMedallion> GetAllShapesMedallions();
        public IEnumerable<ColorMedallion> GetAllColorsMedallions();
    }
}
