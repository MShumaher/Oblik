using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Doctor : Registration
    {
        [Key]
        [Required]
        public virtual Guid DoctorId { get; set; }

        [Required]
        public Guid ProfID { get; set; }

        //[Required(ErrorMessage = "Спеціалізація")]
        [Display(Name = "Спеціалізація:")]
        public Prof Prof { get; set; }
    }
}
