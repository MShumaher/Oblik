using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Doctor : Registration
    {

        [Required(ErrorMessage = "Спеціалізація")]
        [Display(Name = "Спеціалізація:")]
        public virtual string Prof { get; set; } = "сімейний лікар";
    }
}
