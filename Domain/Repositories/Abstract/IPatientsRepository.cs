using Oblik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain.Repositories.Abstract
{
    public interface IPatientsRepository
    {
        IQueryable<Patient> GetPatients();
        Patient GetPatientById(Guid id);
        Patient GetPatientByCodeWord(string codeWord);
        Patient GetPatientByTelNumb (int TelNumb);
        void SavePatient(Patient entity);
        void DeletePatient(Guid id);

    }
}
