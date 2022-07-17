using core_proje.Areas.Writer.Models;
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
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }
}
