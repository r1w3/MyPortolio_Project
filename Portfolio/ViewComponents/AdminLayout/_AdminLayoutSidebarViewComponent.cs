using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarViewComponent : ViewComponent
    {
        AppDbContext _context = new AppDbContext();

        public _AdminLayoutSidebarViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
           var getUrl = _context.Admins.ToList().First();

            ViewBag.ImageUrl = getUrl.ImageUrl;

            ViewBag.Fullname = HttpContext.Session.GetString("Fullname");
            return View();
        }

    }
}
