using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.ViewComponents.Default
{
    public class _ContentBodyPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}