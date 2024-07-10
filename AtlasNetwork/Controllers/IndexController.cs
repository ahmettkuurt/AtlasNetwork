using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtlasNetwork.Controllers
{
    [AllowAnonymous]
    public class IndexController : Controller
    {
        MainPageManager mpm = new MainPageManager(new EfMainPageRepository());
        AboutManager am = new AboutManager(new EfAboutRepository());

       
        public IActionResult Index()
        {
            var values =mpm.GetAllList();
            return View(values);
        }
        public PartialViewResult Partial1()
        {
            var values = am.GetAllList();
            return PartialView(values);
        }

    }
}
