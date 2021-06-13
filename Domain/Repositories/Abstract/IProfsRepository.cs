using Oblik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.Abstract
{
    public interface IProfsRepository
    {
        IQueryable<Prof> GetProfs();
        Prof GetProfById(Guid id);
        void SaveProf(Prof entity);
    }
}
