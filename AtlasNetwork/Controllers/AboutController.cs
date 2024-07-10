using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtlasNetwork.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values= am.GetAllList();
            return View(values);
        }
    }
}
