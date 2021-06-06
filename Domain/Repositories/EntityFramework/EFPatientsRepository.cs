using Microsoft.EntityFrameworkCore;
using Oblik.Domain.Entities;
using Oblik.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.EntityFramework
{
    
    public class EFPatientsRepository : IPatientsRepository
    {
        private readonly AppDbContext context;
        public EFPatientsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Patient> GetPatients()
        {
            return context.Patients;
        }

        public Patient GetPatientById(Guid id)
        {
            return context.Patients.FirstOrDefault(x => x.Id == id);
        }

        public void SavePatient(Patient entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePatient(Guid id)
        {
            context.Patients.Remove(new Patient() { Id = id });
            context.SaveChanges();
        }
    }
}
