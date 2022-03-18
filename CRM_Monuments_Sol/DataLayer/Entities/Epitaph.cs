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
        [Key]
        [ForeignKey("Deceased")]
        public int Id { get; set; }
        public bool EpitaphBool { get; set; }               //наличие эпитафии
        //public string TypeTextEpitaph { get; set; }      //тип текста на памятнике (эпитафия)
        public int? TypeTextObjId { get; set; }
        [ValidateNever]
        public TypeText TypeTextObj { get; set; }
        public string? NotesTextEpitaph { get; set; }       //примечания к тексту (эпитафия)
        public string? EngraverEpitaph { get; set; }      //резчик текста (эпитафия)
        public DateTime DateBeginTextEpitaph { get; set; }         //Дата Начала выполнения текста эпитафии
        public DateTime DateCompleatTextEpitaph { get; set; }      //Дата завершения выполнения текста эпитафии
        public DateTime DeadLine { get; set; }          //Крайний срок

        public Deceased Deceased { get; set; }

    }
}
