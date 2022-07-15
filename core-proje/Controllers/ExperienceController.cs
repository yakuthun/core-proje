using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        public IActionResult Index()
        {
            NavigationBar("Deneyim Listesi", "Deneyimler", "Deneyim Listesi");
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            NavigationBar("Deneyim Listesi", "Deneyimler", "Deneyim Ekleme");
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            NavigationBar("Deneyim Listesi", "Deneyimler", "Deneyim Ekleme");
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            NavigationBar("Düzenleme", "Deneyimler", "Deneyim Güncelleme");
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            NavigationBar("Düzenleme", "Deneyimler", "Deneyim Güncelleme");
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
