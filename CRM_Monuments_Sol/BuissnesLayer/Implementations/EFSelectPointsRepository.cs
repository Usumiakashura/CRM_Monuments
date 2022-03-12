using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<TypeText> GetAllTypesText()
        {
            List<TypeText> pointsForSelect = new List<TypeText>();
            foreach (TypeText tt in _context.TypeTexts.Include(d => d.Deceaseds).Include(e => e.Epitaphs))
                pointsForSelect.Add(tt);
            return pointsForSelect;
        }
        //public IEnumerable<string> GetAllTypesPortraits()
        //{
        //    List<string> pointsForSelect = new List<string>();
        //    foreach (TypePortrait tp in _context.TypePortraits)
        //        pointsForSelect.Add(tp.Name);
        //    return pointsForSelect;
        //}
        public IEnumerable<MedallionMaterial> GetAllMedallionsMaterials()
        {
            List<MedallionMaterial> pointsForSelect = new List<MedallionMaterial>();
            foreach (MedallionMaterial mm in _context.MedallionMaterials)
                pointsForSelect.Add(mm);
            return pointsForSelect;
        }
        public IEnumerable<ShapeMedallion> GetAllShapesMedallions()
        {
            List<ShapeMedallion> pointsForSelect = new List<ShapeMedallion>();
            foreach (ShapeMedallion sm in _context.ShapeMedallions)
                pointsForSelect.Add(sm);
            return pointsForSelect;
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
