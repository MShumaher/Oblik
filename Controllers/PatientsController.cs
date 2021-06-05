using Microsoft.AspNetCore.Mvc;
using Oblik.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Controllers
{
    public class PatientsController : Controller
    {
        private readonly DataManager dataManager;

        public PatientsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Patients.GetPatientById(id));
            }
            //TODO 
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PagePatients");
            return View(dataManager.Patients.GetPatients());
        }
    }
}
