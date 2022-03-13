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
    public class EFMedallionMaterialsRepository : IMedallionMaterialsRepository
    {
        private EFDBContext _context;

        public EFMedallionMaterialsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<MedallionMaterial> GetAllMedallionsMaterials()
        {
            List<MedallionMaterial> pointsForSelect = new List<MedallionMaterial>();
            foreach (MedallionMaterial mm in _context.MedallionMaterials)
                pointsForSelect.Add(mm);
            return pointsForSelect;
        }
    }
}
