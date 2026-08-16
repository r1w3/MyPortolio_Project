using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class TechstackController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public TechstackController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var getTechstacks = _context.TechStacks.ToList();
            return View(getTechstacks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TechStack techStack)
        {

            _context.TechStacks.Add(techStack);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var getTechstackId = _context.TechStacks.Find(id);
            return View(getTechstackId);
        }


        [HttpPost]
        public IActionResult Update(TechStack techStack)
        {

            var getTechstackId = _context.TechStacks.Find(techStack.Id);
            getTechstackId.Name = techStack.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id) {

            var getDeleteId = _context.TechStacks.Find(id);
            _context.TechStacks.Remove(getDeleteId);
            return RedirectToAction("Index");

        }
    }
}
