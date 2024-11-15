using fDSignUp.Models;
using Microsoft.AspNetCore.Mvc;

namespace fDSignUp.Controllers
{
    public class SignUpController : Controller
{
    private readonly ApplicationDbContext _context;

    public SignUpController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(SignUpModel model)
    {
        if (ModelState.IsValid)
        {
            _context.SignUps.Add(model);
            _context.SaveChanges();
            TempData["Message"] = "Your registration has been successfully submitted!";
            return RedirectToAction("Index");
        }
        return View(model);
    }
}

}
