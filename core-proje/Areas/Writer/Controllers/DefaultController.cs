using BusinessLayer.Concrete;
using core_proje.Areas.Writer.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_proje.Areas.Writer.Controllers
{
    [Area("Writer")] //writer isimi area ile çalışacaksın.
    public class DefaultController : Controller
    {
        AnnouncemetManager announcemetManager = new AnnouncemetManager(new EfAnnouncemetDal());
        [Authorize]
        public IActionResult Index()
        {
            var values = announcemetManager.TGetList();
            return View(values);
        }
        public IActionResult AnnouncementDetalis(int id)
        {
            var values = announcemetManager.TGetByID(id);
            return View(values);
        }
    }
}
