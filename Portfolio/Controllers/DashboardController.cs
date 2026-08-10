using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;


namespace Portfolio.Controllers
{
    public class DashboardController : Controller
    {

        AppDbContext _context = new AppDbContext();

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var messageCount = _context.UserMessages.Count();
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.ProjectCount = _context.Projects.Count();
            ViewBag.RecentMessages = _context.UserMessages
                                    .OrderByDescending(m => m.Id)
                                    .Take(5)
                                    .ToList();

            return View(messageCount);

        }


    }
}
