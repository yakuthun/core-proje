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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public void NavigationBar(string v1, string v2, string v3)
        {
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
        }
        public IActionResult Index()
        {
            NavigationBar("Yetenek Listesi", "Yetenekler", "Yetenek Listesi");
            var values = skillManager.TGetList();
            return View(values);
        }
     
        [HttpGet]
        public IActionResult AddSkill()
        {
            NavigationBar("Yetenek Ekleme","Yetenekler", "Yetenek Ekleme");
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            NavigationBar("Düzenleme", "Yetenekler", "Yetenek Güncelleme");
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            NavigationBar("Düzenleme", "Yetenekler", "Yetenek Güncelleme");
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
