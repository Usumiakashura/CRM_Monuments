using DataLayer.ApplicationEntities;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuissnesLayer.Models
{
    public class SettingViewModel
    {
        public List<ApplicationUser> Users { get; set; }
        public List<TypeText> TypeTexts { get; set; }
        public List<TypePortrait> TypePortraits { get; set; }
        public List<MedallionMaterial> MedallionMaterials { get; set; }
        public List<ShapeMedallion> ShapeMedallions { get; set; }
        public List<ColorMedallion> ColorMedallions { get; set; }

    }
}
