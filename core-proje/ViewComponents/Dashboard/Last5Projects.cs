using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_proje.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
