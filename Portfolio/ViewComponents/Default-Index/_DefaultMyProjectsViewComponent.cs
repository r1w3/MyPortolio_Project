using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultMyProjectsViewComponent : ViewComponent
    {

        AppDbContext _context = new AppDbContext();
        public IViewComponentResult Invoke()
        {
            var getProjects = _context.Projects
                              .Include(p => p.ProjectTechStacks)
                              .ThenInclude(pts=>pts.TechStack)
                              .ToList();
            return View(getProjects);
        }
    }
}
