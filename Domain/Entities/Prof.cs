using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Prof
    {
        [Required]
        [Key]
        public Guid ProfID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не може бути довшим за 50 символів та меншим 3!")]
        [Display(Name = "Спеціалізація")]
        public virtual string ProfName { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
