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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        public IActionResult Index()
        {
            NavigationBar("Hizmet Listesi", "Hizmetler", "Hizmet Listesi");
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            NavigationBar("Hizmet Ekleme", "Hizmetler", "Hizmet Ekleme");
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            NavigationBar("Düzenleme", "Hizmetler", "Hizmet Güncelleme");
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            NavigationBar("Düzenleme", "Hizmetler", "Hizmet Güncelleme");
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
