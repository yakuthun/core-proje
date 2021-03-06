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
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        [HttpGet]
        public IActionResult Index()
        {
            NavigationBar("Öne Çıkan Listesi", "Öne Çıkanlar", "Öne Çıkan Listesi");
            var values = featureManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            NavigationBar("Düzenleme", "Öne Çıkanlar", "Öne Çıkan Güncelleme");
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Feature");
        }
    }
}
