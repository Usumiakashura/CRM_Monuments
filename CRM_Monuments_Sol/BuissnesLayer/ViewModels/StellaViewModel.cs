using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewModels
{
    public class StellaViewModel
    {
        public int Id { get; set; }                     //ID
        public int? ContractId { get; set; }             //ID договора
        //public Contract Contract { get; set; }          //сам договор
        public List<DeceasedViewModel> Deceaseds { get; set; }   //усопшие на стэлле


        public StellaViewModel()
        {
            Deceaseds = new List<DeceasedViewModel>();
        }
    }
}
