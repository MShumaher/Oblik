using Microsoft.AspNetCore.Mvc;
using Oblik.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Controllers
{
    public class DoctorServicesController : Controller
    {
        private readonly DataManager dataManager;

        public DoctorServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Doctors.GetDoctorById(id));
            }

            //ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.Doctors.GetDoctors());
        }
    }
}
