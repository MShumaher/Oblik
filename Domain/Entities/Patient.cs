using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Patient : EntityBase
    {
        [Required(ErrorMessage = "Заповніть всі поля")]
        public string CodeWord { get; set; }

        [Display(Name = "Прізвище:")]
        public override string Title { get; set; }

        [Display(Name = "Ім'я:")]
        public override string Subtitle { get; set; }
        //===================================================
        [Display(Name = "Побатькові:")]
        public virtual string FatherName { get; set; }

        [Display(Name = "Стать:")]
        public virtual string Sex { get; set; }

        [Display(Name = "Дата народження:")]
        public virtual string Birthday { get; set; }

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
        //====================================================

        [Display(Name = "Примітки")]
        public override string Text { get; set; }
    }
}
