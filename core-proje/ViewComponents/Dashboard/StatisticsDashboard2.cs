using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.d1 = c.Portfolios.Count();
            ViewBag.d2 = c.Messages.Count();
            ViewBag.d3 = c.Services.Count();
            return View();
        }
    }
}
