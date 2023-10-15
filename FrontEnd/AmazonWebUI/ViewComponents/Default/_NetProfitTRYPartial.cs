using AmazonWebUI.Dto.OrderDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AmazonWebUI.ViewComponents.Default
{
    public class _NetProfitTRYPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _NetProfitTRYPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7268/api/Order");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<OrderResultDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

