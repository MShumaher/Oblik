using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Visit : DateAdd
    {        
        [Key]
        [Required]
        public virtual Guid VisitId { get; set; }

        [Required]
        [Display(Name = "Лікар:")]
        public Guid DoctorId { get; set; }
        
        [Required]
        [Display(Name = "Пацієнт:")]
        public Guid PatientId { get; set; }
        
        [Display(Name = "Скарги:")]
        public virtual string Text { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
