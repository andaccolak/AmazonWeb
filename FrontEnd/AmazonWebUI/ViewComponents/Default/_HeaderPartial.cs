using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.ViewComponents.Default
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}