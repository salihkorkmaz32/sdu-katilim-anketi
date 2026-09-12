using Microsoft.AspNetCore.Mvc;
using anket.Models; 

namespace anket.Controllers 
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Katilimci model)
        {
            if (ModelState.IsValid)
            {
                if (!model.QrKodOlusturulduMu)
                {
                    ModelState.AddModelError("QrKodOlusturulduMu", "Lütfen QR kod oluşturduğunuzu onaylayın.");
                    return View(model);
                }

                _context.Katilimcilar.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Basarili");
            }
            return View(model);
        }

        public IActionResult Basarili()
        {
            return View();
        }
    }
}