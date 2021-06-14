using Microsoft.EntityFrameworkCore;
using Oblik.Domain.Entities;
using Oblik.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.EntityFramework
{
    public class EFVisitsRepository : IVisitsRepository
    {
        private readonly AppDbContext context;
        public EFVisitsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Visit> GetVisits()
        {
            return context.Visits;
        }

        public Visit GetVisitById(Guid id)
        {
            return context.Visits.FirstOrDefault(x => x.VisitId == id);
        }

        public void SaveVisit(Visit entity)
        {
            if (entity.VisitId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteVisit(Guid id)
        {
            context.Visits.Remove(new Visit() { VisitId = id });
            context.SaveChanges();
        }
    }
}
