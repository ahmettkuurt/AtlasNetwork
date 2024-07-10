using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office.CustomUI;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace AtlasNetwork.Controllers
{
    [Authorize]
    [AllowAnonymous]
    public class AdminController : Controller
    {
        MainPageManager mpm= new MainPageManager(new EfMainPageRepository());
        AboutManager am = new AboutManager(new EfAboutRepository());
        ServicesManager sm = new ServicesManager(new  EfServicesRepository());
        ReferenceManager rm = new ReferenceManager(new EfReferencesRepository());
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values = mpm.GetAllList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditFact(int id)
        {
            var value = mpm.GetTById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditFact(MainPage p)
        {
            mpm.UpdateT(p);
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult About(int id)
        {
            var values = am.GetAllList();
            return View(values);
        }
        [HttpPost]
        public IActionResult About(About p)
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var value = am.GetTById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            am.UpdateT(p);
            return RedirectToAction("About", "Admin");
        }



        public IActionResult Services()
        {
            var values = sm.GetAllList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Services p)
        {
            ServicesValidator sv = new ServicesValidator();
            ValidationResult results = sv.Validate(p);
            if (results.IsValid)
            {
                sm.AddT(p);
                RedirectToAction("Services", "Admin");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteService(int id)
        {
            var values = sm.GetTById(id);
            sm.DeleteT(values);
            return RedirectToAction("Services", "Admin");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var value=sm.GetTById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Services p)
        {
            sm.UpdateT(p);
            return RedirectToAction("Services", "Admin");
        }
        public IActionResult References()
        {
            var values = rm.GetAllList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddReferences()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReferences(References p)
        {
            ReferencesValidator rv= new ReferencesValidator();
            ValidationResult results=rv.Validate(p);
            if(results.IsValid)
            {
                rm.AddT(p);
                RedirectToAction("References","Admin");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteReferences(int id)
        {
            var values=rm.GetTById(id);
            rm.DeleteT(values);
            return RedirectToAction("References", "Admin");
        }
        [HttpGet]
        public IActionResult EditReferences(int id)
        {
            var value = rm.GetTById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditReferences(References p)
        {
            rm.UpdateT(p);
            return RedirectToAction("References", "Admin");
        }

        public IActionResult Contact()
        {
            var values = cm.GetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var value= cm.GetTById(id);
            return View(value);
        }
        [HttpPost]
		public IActionResult EditContact(Contact p)
		{
            cm.UpdateT(p);
            return RedirectToAction("EditContact", "Admin");
		}




	}
}
