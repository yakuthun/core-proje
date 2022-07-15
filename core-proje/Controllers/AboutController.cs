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
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        [HttpGet]
        public IActionResult Index()
        {
            NavigationBar("Hakkımda Listesi", "Hakkımda", "Hakkımda Listesi");
            var values = aboutManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            NavigationBar("Hakkımda Listesi", "Hakkımda", "Hakkımda Listesi");
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "About");
        }
    }
}
