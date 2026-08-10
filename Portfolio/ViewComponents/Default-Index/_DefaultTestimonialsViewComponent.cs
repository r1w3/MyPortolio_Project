using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultTestimonialsViewComponent : ViewComponent
    {
        AppDbContext _context = new AppDbContext();

        public _DefaultTestimonialsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var getData = _context.Testimonials.ToList();

            return View(getData);

        }
    }
}
