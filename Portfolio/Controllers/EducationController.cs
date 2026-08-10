using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {

        AppDbContext _context= new AppDbContext();

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var listEducation = _context.Educations.ToList();

            return View(listEducation);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Education education)
        {
            var newEducation = _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var getUpdateEducation = _context.Educations.Find(id);
            return View(getUpdateEducation);
        }

        [HttpPost]
        public IActionResult Update(Education education)
        {
            var getData =_context.Educations.Find(education.Id);
            getData.SchoolName = education.SchoolName;
            getData.Comment = education.Comment;
            getData.Department = education.Department;
            getData.StartYear = education.StartYear;
            getData.GraduationYear= education.GraduationYear;
            getData.GPA = education.GPA;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
