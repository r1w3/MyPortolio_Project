using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SkillsController : Controller
    {

        AppDbContext _context = new AppDbContext();
        public IActionResult Index()
        {
            var getSkills = _context.Skills.ToList();
            return View(getSkills);
        }

        [HttpGet]

        public IActionResult CreateSkills()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkills(Skills skills)
        {
            _context.Skills.Add(skills);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkills(int id)
        {
            var getSkillsForUpdate = _context.Skills.Find(id);
            return View(getSkillsForUpdate);
        }
        [HttpPost]

        public IActionResult UpdateSkills(Skills skills)
        {
            var getSkills = _context.Skills.Find(skills.Id);
            getSkills.Name = skills.Name;
            getSkills.IsActive = skills.IsActive;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
