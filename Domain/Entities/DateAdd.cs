using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Entities
{
    public abstract class DateAdd
    {
        protected DateAdd() => DateAdded = DateTime.Now;

        [DataType(DataType.Time)]//дата створення сутності
        public DateTime DateAdded { get; set; }
    }
}
