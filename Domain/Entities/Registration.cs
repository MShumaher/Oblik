using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Registration
    {
        protected Registration() => DateAdded = DateTime.Now;

        [Required]
        public Guid Id { get; set; }

       // [Required (ErrorMessage ="Введіть прізвище та ініціали")]
       // [Display(Name = "ПрізвищеІП:")]
      //  public string CodeWord { get; set; }

        [Required(ErrorMessage = "Введіть прізвище")]
        [Display(Name = "Прізвище:")]
        public virtual string Surname { get; set; }

        [Required(ErrorMessage = "Введіть iм'я")]
        [Display(Name = "Ім'я:")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "Введіть побатькові")]
        [Display(Name = "Побатькові:")]
        public virtual string FatherName { get; set; }

        [Display(Name = "Фото")]
        public virtual string TitleImagePath { get; set; }

        [Required(ErrorMessage = "Введіть стать")]
        [Display(Name = "Стать:")]
        public virtual string Sex { get; set; }

        [Required(ErrorMessage = "Введіть дату народження")]
        [Display(Name = "Дата народження:")]
        public virtual DateTime Birthday { get; set; }

        [Display(Name = "Телефон +380")]
        public virtual int TelNumb { get; set; }

        [Display(Name = "Ел.пошта:")]
        public virtual string Email { get; set; }

        [Display(Name = "Група крові")]
        public virtual string BloodType { get; set; }

        [Display(Name = "Резус")]
        public virtual string Rhesus { get; set; }

        [Display(Name = "Документ")]
        public virtual string DocumentType { get; set; }

        [Display(Name = "Номер")]
        public virtual int NumbDocument { get; set; }

        [Display(Name = "Серія")]
        public virtual string SerialDocument { get; set; }

        [Display(Name = "РКНОПП")]
        public virtual int Rknopp { get; set; }
        
        [Display(Name = "Примітки")]
        public virtual string Text { get; set; }

        [Display(Name = "SEO метатег Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]//дата створення сутності
        public DateTime DateAdded { get; set; }
    }
}