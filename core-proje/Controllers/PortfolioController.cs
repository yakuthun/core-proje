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
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        public IActionResult Index()
        {
            NavigationBar("Proje Listesi", "Projeler", "Proje Listesi");
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            NavigationBar("Proje Ekleme", "Projeler", "Proje Ekleme");
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            NavigationBar("Proje Ekleme", "Projeler", "Proje Ekleme");
            if (portfolio.Name != null && portfolio.ImageUrl == "" && portfolio.Name.Length <= 100 && portfolio.Name.Length >= 5)
            {
                portfolioManager.TAdd(portfolio);
            }
            else
            {
                //
            }
           
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            NavigationBar("Düzenleme", "Projeler", "Proje Güncelleme");
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            NavigationBar("Düzenleme", "Projeler", "Proje Güncelleme");
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
