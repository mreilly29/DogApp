using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Controlleres
{
    public class HomeController : Controller
    {
        private IDogRepository dogRepo;

        public HomeController(IDogRepository dogRepo)
        {
            this.dogRepo = dogRepo;
        }

        public ViewResult Index()
        {
            var model = dogRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = dogRepo.FindById(id);
            return View(model);
        }
    }
}
