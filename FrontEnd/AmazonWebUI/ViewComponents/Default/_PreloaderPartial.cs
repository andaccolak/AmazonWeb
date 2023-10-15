using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.ViewComponents.Default
{
    public class _PreloaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}