using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Deceased
    {   
        public int Id { get; set; }                                     //Id
        public TextOnStella TextOnStella { get; set; }                  //Оформление текста на памятнике
        public List<Epitaph> Epitaphs { get; set; }                     //эпитафия
        public bool Photo { get; set; }                                 //без/с фото
        public List<PhotoOnMonument> PhotosOnMonument { get; set; }     //фотографии на памятнике

        
        //[ValidateNever]
        public int? StellaId { get; set; }
        public Stella Stella { get; set; }                              //для бд


        public Deceased()
        {
            PhotosOnMonument = new List<PhotoOnMonument>();
            Epitaphs = new List<Epitaph>();
        }
    }
}
