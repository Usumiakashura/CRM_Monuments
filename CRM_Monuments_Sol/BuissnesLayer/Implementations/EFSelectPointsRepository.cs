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

        public IEnumerable<string> GetAllTypesText()
        {
            List<string> pointsForSelect = new List<string>();
            foreach (TypeText tt in _context.TypeTexts)
                pointsForSelect.Add(tt.Name);
            return pointsForSelect;
        }
        public IEnumerable<string> GetAllTypesPortraits()
        {
            List<string> pointsForSelect = new List<string>();
            foreach (TypePortrait tp in _context.TypePortraits)
                pointsForSelect.Add(tp.Name);
            return pointsForSelect;
        }
        public IEnumerable<string> GetAllMedallionsMaterials()
        {
            List<string> pointsForSelect = new List<string>();
            foreach (MedallionMaterial mm in _context.MedallionMaterials)
                pointsForSelect.Add(mm.Name);
            return pointsForSelect;
        }
        public IEnumerable<string> GetAllShapesMedallions()
        {
            List<string> pointsForSelect = new List<string>();
            foreach (ShapeMedallion sm in _context.ShapeMedallions)
                pointsForSelect.Add(sm.Name);
            return pointsForSelect;
        }
        public IEnumerable<string> GetAllColorsMedallions()
        {
            List<string> pointsForSelect = new List<string>();
            foreach (ColorMedallion cm in _context.ColorMedallions)
                pointsForSelect.Add(cm.Name);
            return pointsForSelect;
        }


    }
}
