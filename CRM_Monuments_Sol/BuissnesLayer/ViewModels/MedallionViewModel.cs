using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewModels
{
    public class MedallionViewModel
    {
        public int Id { get; set; }                     //Id
        public string? PhotoPath { get; set; }          //Фотография путь
        public string? PhotoName { get; set; }          //Фотография имя
        public string? Note { get; set; }               //Примечания
        public DateTime DateBegin { get; set; }         //Дата Начала выполнения
        public DateTime DateCompleat { get; set; }      //Дата завершения выполнения
        public DateTime DeadLine { get; set; }          //Крайний срок
        public int? DeceasedId { get; set; }

        public List<PhotoViewModel> Photos { get; set; }
        //-------------------------------------------------------
        //-------------------------------------------------------
        public int? MedallionMaterialId { get; set; }               //id материала
        //public MedallionMaterial MedallionMaterial { get; set; }    //Материал
        public int? MedallionSizeId { get; set; }
        //public MedallionSize MedallionSize { get; set; }
        public string SizeMedallion { get; set; }                   //Размер
        public int? ShapeMedallionId { get; set; }                  //id формы
        //public ShapeMedallion ShapeMedallion { get; set; }          //Форма
        public string ColorMedallion { get; set; }                  //цветность
        public string BackgroundMedallion { get; set; }             //Фон


        public bool Frame { get; set; }
        //--- Если рамка есть ---
        public string? TypeFrame { get; set; }           //тип рамки
        public string? SizeFrame { get; set; }           //размер
        public string? ShapeFrame { get; set; }          //форма
        public string? ColorFrame { get; set; }          //цвет
        public string? NoteFrame { get; set; }           //примечание
        //-----------------------
        //--- Если рамки нет ---
        public bool GluingIntoNiche { get; set; }        //вклейка в нишу
        //----------------------
    }
}
