using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IColorMedallionsRepository
    {
        public IEnumerable<ColorMedallion> GetAllColorsMedallions();
    }
}
