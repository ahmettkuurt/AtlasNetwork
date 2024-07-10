using AtlasNetwork.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AtlasNetwork.Controllers
{
	[AllowAnonymous]

	public class LoginController : Controller
    {
		
		public IActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Index(Admin p)
		{
            Context c = new Context();
            var datavalue = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if (datavalue != null)
            {
                HttpContext.Session.SetString("username", p.AdminUserName);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

    }
}



//[HttpPost]
//public async Task<IActionResult> Index(UserSignInViewModel p)
//{
//    if (ModelState.IsValid)
//    {
//        var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
//        if (result.Succeeded)
//        {
//            return RedirectToAction("Index", "Admin");

//        }
//        else
//        {
//            return RedirectToAction("Index", "Login");
//        }


//    }
//    return View();
//}



//Context c = new Context();
//var datavalue = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
//if (datavalue != null)
//{
//	HttpContext.Session.SetString("username", p.AdminUserName);
//	return RedirectToAction("Index", "Admin");
//}
//else
//{
//	return View();
//}
