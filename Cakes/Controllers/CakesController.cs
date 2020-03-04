using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cakes.DAL.Interfaces;
using Cakes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cakes.Controllers
{
    public class CakesController : Controller
    {
        private readonly ICakes _cakes;

        public CakesController(ICakes cakes)
        {
            _cakes = cakes;
        }
        
        public IActionResult Cakes()
        {
            CakesListViewModel obj = new CakesListViewModel();
            obj.GetCakes = _cakes.GetCakes;
            ViewBag.Title = "Sweet-Shop";
            return View(obj);
        }
    }
}