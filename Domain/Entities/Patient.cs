using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Patient : Registration
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название (заголовок)")]
        public virtual string Specialization { get; set; }
    }
}
