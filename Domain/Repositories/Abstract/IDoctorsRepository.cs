using Oblik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.Abstract
{
    public interface IDoctorsRepository
    {
        IQueryable<Doctor> GetDoctors();
        Doctor GetDoctorById(Guid id);
        void SaveDoctor(Doctor entity);
        void DeleteDoctor(Guid id);
    }
}
