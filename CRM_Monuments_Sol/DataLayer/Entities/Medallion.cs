using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Medallion : PhotoOnMonument
    {   //медальон
        //public string MaterialMedallion { get; set; }   //Материал
        public int? MedallionMaterialObjId { get; set; }   //Материал
        [ValidateNever]
        public MedallionMaterial MedallionMaterialObj { get; set; }   //Материал
        public string SizeMedallion { get; set; }       //Размер
        //public string ShapeMedallion { get; set; }      //Форма
        public int? ShapeMedallionObjId { get; set; }      //Форма
        [ValidateNever]
        public ShapeMedallion ShapeMedallionObj { get; set; }      //Форма
        //public string ColorMedallion { get; set; }      //Цвет
        public int? ColorMedallionObjId { get; set; }      //Форма
        [ValidateNever]
        public ColorMedallion ColorMedallionObj { get; set; }      //Форма
        public string BackgroundMedallion { get; set; } //Фон


        public bool Frame { get; set; }
        //--- Если рамка есть ---
        public string? TypeFrame { get; set; }           //тип рамки
        public string? SizeFrame { get; set; }           //размер
        public string? ShapeFrame { get; set; }          //форма
        public string? ColorFrame { get; set; }          //цвет
        public string? NoteFrame { get; set; }           //примечание
        //-----------------------
        //--- Если рамки нет ---
        public bool GluingIntoNiche { get; set; }       //вклейка в нишу
        //----------------------
    }
}
