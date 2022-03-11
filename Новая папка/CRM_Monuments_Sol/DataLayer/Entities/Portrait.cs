using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Portrait : PhotoOnMonument
    {   //портрет
        
        public string Artist { get; set; }              //художник
        public string TypePortrait { get; set; }        //тип портрета (ручной/станочный)
        public int TypePortraitId { get; set; }        //тип портрета (ручной/станочный)
        public TypePortrait TypePortraitObj { get; set; }
    }
}
