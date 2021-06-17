using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.Now;
        
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Назва (заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Короткий опис")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Розгорнутий опис")]
        public virtual string Text { get; set; }

        [Display(Name = "Титульне зображення")]
        public virtual string TitleImagePath { get; set; }

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
