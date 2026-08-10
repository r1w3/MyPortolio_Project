using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Models;
using System.Security.Claims;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {

        private readonly AppDbContext _context = new AppDbContext();

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var admin = _context.Admins.FirstOrDefault(x=>x.Username==model.UserName && x.Password == model.Password);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (admin==null)
            {
                ModelState.AddModelError(string.Empty,"Kullanıcı veya şifre hatalı!");
                return View(model);
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,admin.Username),
                new Claim("fullname",admin.Fullname)
            };

            var claimsIdedinty = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

            var authProps = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.UtcNow.AddMinutes(30),
                IsPersistent = false

            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                new ClaimsPrincipal(claimsIdedinty), authProps);

            HttpContext.Session.SetString("Fullname",admin.Fullname);

            return RedirectToAction("Index","Dashboard");
        
        }

        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove("Fullname");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Default");
        }
    }
}
