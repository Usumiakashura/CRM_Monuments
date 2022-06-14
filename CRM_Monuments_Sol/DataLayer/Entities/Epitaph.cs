using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Epitaph
    {
        public int Id { get; set; }
        public int? TypeTextId { get; set; }                        //ID типа текста
        //[ValidateNever]
        public TypeText TypeText { get; set; }                      //тип текста
        public string? NotesTextEpitaph { get; set; }               //примечания к тексту (эпитафия)
        public string? EngraverEpitaph { get; set; }                //резчик текста (эпитафия)
        public DateTime DateBeginTextEpitaph { get; set; }          //Дата Начала выполнения текста эпитафии
        public DateTime DateCompleatTextEpitaph { get; set; }       //Дата завершения выполнения текста эпитафии
        public DateTime DeadLine { get; set; }                      //Крайний срок

        public int? DeceasedId { get; set; }
        public Deceased Deceased { get; set; }                      //для бд

    }
}
