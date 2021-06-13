using Microsoft.EntityFrameworkCore;
using Oblik.Domain.Entities;
using Oblik.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.EntityFramework
{
    public class EFProfsRepository : IProfsRepository
    {
        private readonly AppDbContext context;
        public EFProfsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Prof> GetProfs()
        {
            return context.Profs;
        }

        public Prof GetProfById(int id)
        {
            return context.Profs.FirstOrDefault(x => x.ProfId == id);
        }

        public void SaveProf(Prof entity)
        {
            if (entity.ProfId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
