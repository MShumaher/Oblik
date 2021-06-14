using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public class Patient : Registration
    {
        [Key]
        [Required]
        public virtual Guid PatientId { get; set; }

        public ICollection<Visit> Visits { get; set; }

    }
}
