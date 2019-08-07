using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetShop.Models;
using PetShopLibrary.Entities;
using PetShopLibrary.Services.Interfaces;

namespace PetShop.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetServices _petServices;
        private readonly ILogger<PetController> _logger;
        public ActionResult Index()
        {
            try
            {
                _logger.LogInformation("Action Index on Pet controller");
                var pets = _petServices.PetQueryAll();

                ViewBag.Pets = pets;

                return View();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        public ActionResult InsertPet()
        {
            try
            {
                _logger.LogInformation("Action Index on Pet controller");
                var pets = _petServices.PetQueryAll().Last();

                ViewBag.Pets = pets.Id;

                return View();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        public ActionResult PetInsert(PetModel newPet)
        {

            Pet pet = new Pet()
            {
                PetName = newPet.PetName,
                Brand = newPet.Brand,
                Gender = newPet.Gender,
                Species = newPet.Species,
                Age = newPet.Age
            };

            _petServices.PetInsert(pet);
            return View();
        }
    }
}