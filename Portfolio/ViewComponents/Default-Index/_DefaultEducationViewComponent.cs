using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{


    public class _DefaultEducationViewComponent : ViewComponent
    {

        AppDbContext _context = new AppDbContext();

        public _DefaultEducationViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var getData = _context.Educations.ToList();
            return View(getData);
        }
    }
}
