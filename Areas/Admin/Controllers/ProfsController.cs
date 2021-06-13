using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oblik.Domain;
using Oblik.Domain.Entities;
using Oblik.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ProfsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Prof() : dataManager.Profs.GetProfById(id);
            return View(entity);
        }

        
        [HttpPost]
        public IActionResult Edit(Prof model)
        {
            if (ModelState.IsValid)
            {
                
                dataManager.Profs.SaveProf(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
                
    }
}
