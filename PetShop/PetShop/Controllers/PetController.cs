using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.Controllers
{
    public class PetController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}