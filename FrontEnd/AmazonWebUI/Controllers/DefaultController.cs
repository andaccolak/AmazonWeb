using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
