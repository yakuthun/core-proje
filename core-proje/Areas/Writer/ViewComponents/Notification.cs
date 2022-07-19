using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace core_proje.Areas.Writer.ViewComponents
{
    public class Notification:ViewComponent
    {
        AnnouncemetManager announcemetManager = new AnnouncemetManager(new EfAnnouncemetDal());
        public IViewComponentResult Invoke()
        {
            var values = announcemetManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
