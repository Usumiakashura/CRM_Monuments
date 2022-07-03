using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewModels
{
    public class DeceasedViewModel
    {
        public int Id { get; set; }                                     //Id
        public TextOnStellaViewModel TextOnStella { get; set; }         //Оформление текста на памятнике
        public List<EpitaphViewModel> Epitaphs { get; set; }            //эпитафия
        public bool Photo { get; set; }                                 //без/с фото
        public List<PortraitViewModel> Portraits { get; set; }          //портреты на памятнике
        public List<MedallionViewModel> Medallions { get; set; }        //медальоны на памятнике

        public int? StellaId { get; set; }


        public DeceasedViewModel()
        {
            Portraits = new List<PortraitViewModel>();
            Medallions = new List<MedallionViewModel>();
            Epitaphs = new List<EpitaphViewModel>();
        }
    }
}
