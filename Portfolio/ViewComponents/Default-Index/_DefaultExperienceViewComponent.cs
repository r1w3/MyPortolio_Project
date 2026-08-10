using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultExperienceViewComponent : ViewComponent
    {

        AppDbContext _context = new AppDbContext();

        public _DefaultExperienceViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var datas = _context.Experiences.ToList();

            return View(datas);
        }

    }
}
