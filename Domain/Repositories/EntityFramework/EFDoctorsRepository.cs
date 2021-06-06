using Microsoft.EntityFrameworkCore;
using Oblik.Domain.Entities;
using Oblik.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.EntityFramework
{
    public class EFDoctorsRepository : IDoctorsRepository
    {
        private readonly AppDbContext context;
        public EFDoctorsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Doctor> GetDoctors()
        {
            return context.Doctors;
        }

        public Doctor GetDoctorById(Guid id)
        {
            return context.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDoctor(Doctor entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteDoctor(Guid id)
        {
            context.Doctors.Remove(new Doctor() { Id = id });
            context.SaveChanges();
        }
    }
}
