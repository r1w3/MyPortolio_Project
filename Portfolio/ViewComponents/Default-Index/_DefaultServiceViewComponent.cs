using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultServiceViewComponent : ViewComponent
    {
        private readonly AppDbContext _context = new AppDbContext();

        public _DefaultServiceViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var getService = _context.Services.ToList();
            
            return View(getService);
        }
    }
}
