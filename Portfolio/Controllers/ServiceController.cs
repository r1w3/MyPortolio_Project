using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Services.ToList();
            return View(list);
        }
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult UpdateService(int id)
        {
            var getService = _context.Services.Find(id);
            return View(getService);

        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            var getService = _context.Services.Find(service.Id);
            getService.Title = service.Title;
            getService.Description = service.Description;
            getService.Icon = service.Icon;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {

            var deleteServices = _context.Services.Find(id);
            _context.Services.Remove(deleteServices);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
