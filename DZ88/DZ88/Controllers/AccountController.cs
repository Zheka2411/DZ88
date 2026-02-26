
using Microsoft.AspNetCore.Mvc;
using RegisterValidationApp.Models;

namespace RegisterValidationApp.Controllers
{
public class AccountController:Controller
{
static List<RegisterViewModel> users=new();

[HttpGet]
public IActionResult Register(){return View();}

[HttpPost]
public IActionResult Register(RegisterViewModel model)
{
if(ModelState.IsValid)
{
users.Add(model);
return Content("User registered");
}
return View(model);
}

public IActionResult VerifyUsername(string username)
{
var exists=users.Any(u=>u.Username==username);
if(exists) return Json("Username already taken");
return Json(true);
}
}
}
