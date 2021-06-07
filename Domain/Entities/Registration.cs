using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public enum BloodType
    {
        I = 1, II = 2, III = 3, IV = 4
    }

    public class Registration
    {
        protected Registration() => DateAdded = DateTime.Now;

        [Required]
        public Guid Id { get; set; }

       // [Required (ErrorMessage ="Введіть прізвище та ініціали")]
       // [Display(Name = "ПрізвищеІП:")]
      //  public string CodeWord { get; set; }

        [Required(ErrorMessage = "Введіть прізвище")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Прізвище не може бути довшим за 50 символів та меншим 2!")]
        [Display(Name = "Прізвище:")]
        public virtual string Surname { get; set; }

        [Required(ErrorMessage = "Введіть iм'я")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ім'я не може бути довшим за 50 символів та меншим 2!")]
        [Display(Name = "Ім'я:")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "Введіть побатькові")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Побатькові не може бути довшим за 50 символів та меншим 2!")]
        [Display(Name = "Побатькові:")]
        public virtual string FatherName { get; set; }

        [Display(Name = "Фото")]
        public virtual string TitleImagePath { get; set; }

        [Required(ErrorMessage = "Введіть стать")]
        [Display(Name = "Стать:")]
        public virtual string Sex { get; set; }

        [Required(ErrorMessage = "Введіть дату народження")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата народження:")]
        public virtual DateTime Birthday { get; set; }

        [Display(Name = "Телефон +380")]
        public virtual int TelNumb { get; set; }

        [Display(Name = "Ел.пошта:")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введіть коректний email")]
        public virtual string Email { get; set; }

        [Display(Name = "Група крові")]
        [DisplayFormat(NullDisplayText = "Не вказана")]
        //public virtual string BloodType { get; set; }        
        public BloodType? BloodType { get; set; }

        [Display(Name = "Резус")]
        [StringLength(1)]
        [DisplayFormat(NullDisplayText = "Не вказаний")]
        public virtual string Rhesus { get; set; }

        [Display(Name = "Документ")]
        public virtual string DocumentType { get; set; }

        [Display(Name = "Номер")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Введіть коректний номер")]
        public virtual int NumbDocument { get; set; }

        [Display(Name = "Серія")]
        [RegularExpression(@"^[A-Z]+[A-Z]*$", ErrorMessage = "Великі літери!")]
        public virtual string SerialDocument { get; set; }

        [Display(Name = "РКНОПП")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Введіть коректний номер")]
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