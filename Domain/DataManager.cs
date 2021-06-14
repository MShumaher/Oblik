using Oblik.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public IDoctorsRepository Doctors { get; set; }
        public IPatientsRepository Patients { get; set; }
        public IProfsRepository Profs { get; set; }
        public IVisitsRepository Visits { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, 
            IDoctorsRepository doctorsRepository, IPatientsRepository patientsRepository, IProfsRepository profsRepository,
            IVisitsRepository visitsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            Patients = patientsRepository;
            Doctors = doctorsRepository;
            Profs = profsRepository;
            Visits = visitsRepository;
            
        }
    }
}
