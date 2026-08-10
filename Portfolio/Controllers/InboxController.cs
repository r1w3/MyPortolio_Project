using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class InboxController : Controller
    {

        AppDbContext _context = new AppDbContext();

        public InboxController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inbox = _context.UserMessages.ToList();
            return View(inbox);
        }

        public IActionResult DeleteMessage(int id)
        {
            var delete = _context.UserMessages.Find(id);
            _context.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ViewMessage(int id)
        {
            var message = await _context.UserMessages.FindAsync(id);
            if (message == null)
                return NotFound();

            if (!message.IsRead)
            {
                message.IsRead = true;
                await _context.SaveChangesAsync();
            }

            return View(message);
        }
    }
}
