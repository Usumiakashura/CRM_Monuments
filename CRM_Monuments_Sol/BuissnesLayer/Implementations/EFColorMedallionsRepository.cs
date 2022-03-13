using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFColorMedallionsRepository : IColorMedallionsRepository
    {
        private EFDBContext _context;

        public EFColorMedallionsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<ColorMedallion> GetAllColorsMedallions()
        {
            List<ColorMedallion> pointsForSelect = new List<ColorMedallion>();
            foreach (ColorMedallion cm in _context.ColorMedallions)
                pointsForSelect.Add(cm);
            return pointsForSelect;
        }
    }
}
