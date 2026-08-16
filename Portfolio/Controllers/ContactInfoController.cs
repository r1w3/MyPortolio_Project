using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ContactInfoController : Controller
    {

        private readonly AppDbContext _context = new AppDbContext();

        public ContactInfoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var getInfos = _context.ContactInfos.FirstOrDefault();
            return View(getInfos);
            
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();

        }
        public IActionResult Create(Contactinfo contactinfo)
        {
            _context.ContactInfos.Add(contactinfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update()
        {
            var getContactId = _context.ContactInfos.FirstOrDefault();
            return View(getContactId);
        }

        [HttpPost]
        public IActionResult Update(Contactinfo contactinfo)
        {
            var updateContactId = _context.ContactInfos.FirstOrDefault();
            updateContactId.Email = contactinfo.Email;
            updateContactId.Address = contactinfo.Address;
            updateContactId.LinkedinUrl = contactinfo.LinkedinUrl;
            updateContactId.GithubUrl = contactinfo.GithubUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
