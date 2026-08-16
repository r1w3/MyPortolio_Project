using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{

    
    public class ProfileSettings : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public IActionResult Index()
        {

            return View();
           
        }


        [HttpGet]
        public IActionResult Update(int id)
        {

            var getUser = _context.Admins.FirstOrDefault();
            return View(getUser);

        }
        [HttpPost]
        public IActionResult Update(Admin admin)
        {
            var existing = _context.Admins.Find(admin.Id);

            existing.Username = admin.Username;
            existing.Fullname = admin.Fullname;

            // Şifre alanı boş bırakıldıysa mevcut şifreye dokunma
            if (!string.IsNullOrWhiteSpace(admin.Password))
            {
                existing.Password = admin.Password;
            }

            _context.SaveChanges();
            return RedirectToAction("Update");

        }

    }
}
