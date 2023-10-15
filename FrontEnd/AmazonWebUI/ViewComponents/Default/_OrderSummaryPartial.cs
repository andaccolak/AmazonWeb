using Microsoft.AspNetCore.Mvc;

namespace AmazonWebUI.ViewComponents.Default
{
    public class _OrderSummaryPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
