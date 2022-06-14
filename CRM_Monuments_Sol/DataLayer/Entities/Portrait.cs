using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Portrait : PhotoOnMonument
    {   //портрет
        public string? Artist { get; set; }                 //художник
        public int? TypePortraitId { get; set; }            //тип портрета Id
        [ValidateNever]
        public TypePortrait TypePortrait { get; set; }      //тип портрета
    }
}
