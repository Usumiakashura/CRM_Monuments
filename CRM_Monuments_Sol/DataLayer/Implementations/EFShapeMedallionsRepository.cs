using DataLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;

namespace DataLayer.Implementations
{
    public class EFShapeMedallionsRepository : IShapeMedallionsRepository
    {
        private EFDBContext _context;

        public EFShapeMedallionsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<ShapeMedallion> GetAllShapesMedallions()
        {
            List<ShapeMedallion> pointsForSelect = new List<ShapeMedallion>();
            foreach (ShapeMedallion sm in _context.ShapeMedallions)
                pointsForSelect.Add(sm);
            return pointsForSelect;
        }
    }
}
