using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {

        AppDbContext _context = new AppDbContext();

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var getExperience = _context.Experiences.ToList();
            return View(getExperience);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {

            return View();
           
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {

            var createEx = _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var getExperienceForUpdate = _context.Experiences.Find(id);
            return View(getExperienceForUpdate);

        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {

            var updateEx = _context.Experiences.Find(experience.Id);
            updateEx.Name = experience.Name;
            updateEx.Comment = experience.Comment;
            updateEx.Company = experience.Company;
            updateEx.StartYear = experience.StartYear;
            updateEx.FinishedYear = experience.FinishedYear;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
