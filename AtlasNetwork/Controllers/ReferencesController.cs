using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtlasNetwork.Controllers
{
    public class ReferencesController : Controller
    {
        ReferenceManager rm = new ReferenceManager(new EfReferencesRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = rm.GetAllList();
            return View(values);
        }
    }
}
