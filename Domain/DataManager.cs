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
        
                

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, 
            IDoctorsRepository doctorsRepository, IPatientsRepository patientsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            Patients = patientsRepository;
            Doctors = doctorsRepository;
            
        }
    }
}
