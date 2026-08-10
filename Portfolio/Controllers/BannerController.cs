using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class BannerController : Controller
    {
        AppDbContext _context = new AppDbContext();

        public BannerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var getBanners = _context.Banners.FirstOrDefault();
            return View(getBanners);
        }


        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }
        public IActionResult CreateBanner(Banner banner)
        {
            _context.Banners.Add(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]

        public IActionResult UpdateBanner(int id)
        {
            var getBanner = _context.Banners.Find(id);

            return View(getBanner);
        }

        [HttpPost]
        public IActionResult UpdateBanner(Banner banner)
        {
            var bannerForUpdate = _context.Banners.Find(banner.Id);
            bannerForUpdate.Title = banner.Title;
            bannerForUpdate.Comment = banner.Comment;
            bannerForUpdate.ImageUrl = banner.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
