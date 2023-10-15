using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
    public PartialViewResult PreLoader()
        {
            return PartialView();
        }
        public PartialViewResult NavHeader()
        {
            return PartialView();
        }
   public PartialViewResult SideBar()
        {
            return PartialView();
        }
    public PartialViewResult ContentBody()
        {
            return PartialView();
        }
   public PartialViewResult Footer()
        {
            return PartialView();
        }
   public PartialViewResult Scripts()
        {
            return PartialView();
        }
   
    }
}
