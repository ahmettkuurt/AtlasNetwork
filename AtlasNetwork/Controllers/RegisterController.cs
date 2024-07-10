using AtlasNetwork.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AtlasNetwork.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        //public RegisterController(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task <IActionResult> Index(UserSignUpViewModel p )
        //{
        //    if(ModelState.IsValid)
        //    {
        //        AppUser user = new AppUser()
        //        {
        //            Email = p.Mail,
        //            UserName = p.username,
        //        };

        //        var result= await _userManager.CreateAsync(user,p.Password);
                
        //        if(result.Succeeded)
        //        {
        //            return RedirectToAction("Index", "Login");
        //        }
        //        else
        //        {
        //            foreach(var item in result.Errors)
        //            {
        //                ModelState.AddModelError("", item.Description);
        //            }
        //        }
        //    }
        //    return View(p);
        //}
    }
}
