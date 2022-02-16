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
    public class EFSelectPointsRepository : ISelectPointsRepository
    {
        private EFDBContext _context;

        public EFSelectPointsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectPoint> GetAll(SelectPoint selectPoints)
        {
            if (selectPoints is TypeText)
                return _context.TypeTexts;
            else if (selectPoints is TypePortrait)
                return _context.TypePortraits;
            else if (selectPoints is MedallionMaterial)
                return _context.MedallionMaterials;
            else if (selectPoints is ShapeMedallion)
                return _context.ShapeMedallions;
            else if (selectPoints is ColorMedallion)
                return _context.ColorMedallions;
            return null;
        }
    }
}
