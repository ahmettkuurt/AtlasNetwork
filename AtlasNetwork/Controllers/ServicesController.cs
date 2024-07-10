using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtlasNetwork.Controllers
{
    public class ServicesController : Controller
    {
        ServicesManager sm = new ServicesManager(new EfServicesRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = sm.GetAllList();
            return View(values);
        }
    }
}
