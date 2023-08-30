using Microsoft.AspNetCore.Mvc;

namespace MortageCalculaterC_.Controllers
{
    public class MortgageController : Controller
    {
        // 
        // GET: /Mortgage/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Mortgage/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
