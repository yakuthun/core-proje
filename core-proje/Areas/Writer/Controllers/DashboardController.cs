using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //Weather API
            string api = "5712b6c749ec2fe559aadcf92cd8c16f";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.m5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //Statistics
            Context c = new Context();
            ViewBag.m1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.m2 = c.Announcemets.Count();
            ViewBag.m3 = c.Users.Count();
            ViewBag.m4 = c.Skills.Count();

            return View();
        }
    }
}
/*
https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&appid=5712b6c749ec2fe559aadcf92cd8c16f
*/