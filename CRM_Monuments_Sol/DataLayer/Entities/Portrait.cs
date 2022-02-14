using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Portrait : PhotoOnMonument
    {   //портрет
        public string TypePortrait { get; set; }        //тип портрета (ручной/станочный)
        public string Artist { get; set; }              //художник
    }
}
