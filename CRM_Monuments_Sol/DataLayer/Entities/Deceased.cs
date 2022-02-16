using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Deceased
    {   //усопший
        public int Id { get; set; }                     //Id
        public string LastName { get; set; }            //Фамилия
        public string FirstName { get; set; }           //Имя
        public string MiddleName { get; set; }          //Отчество
        public DateTime? DateBirthday { get; set; }      //Дата рождения
        public DateTime? DateRip { get; set; }           //Дата смерти
        
        //--- Фотография/портрет на памятнике ---
        public bool Photo { get; set; }                 //без/с фото
        public List<PhotoOnMonument> PhotosOnMonument { get; set; }    //обработка фотографий на памятнике

        //---------------------------------------

        //--- Текст на памятнике ---
        public string TypeNameText { get; set; }      //тип текста на памятнике (имя)
        public string NotesTextName { get; set; }       //примечания к тексту (имя)
        public string EngraverName { get; set; }      //резчик текста (имя)
        public bool Epitaph { get; set; }               //наличие эпитафии
        public string TypeNameEpitaph { get; set; }      //тип текста на памятнике (эпитафия)
        public string NotesTextEpitaph { get; set; }       //примечания к тексту (эпитафия)
        public string EngraverEpitaph { get; set; }      //резчик текста (эпитафия)
        //--------------------------
        public bool DeletedCheck { get; set; }

        public Contract Contract { get; set; }          //для бд


        public Deceased()
        {
            PhotosOnMonument = new List<PhotoOnMonument>();
        }
    }
}
