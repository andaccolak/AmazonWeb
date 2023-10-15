using AmazonWebUI.Dto.CreditCardDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace AmazonWebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessageCC = await client.GetAsync("https://localhost:7268/api/CreditCard");
            var responseMessageOrder = await client.GetAsync("https://localhost:7268/api/CreditCard");
            var responseMessageTodo = await client.GetAsync("https://localhost:7268/api/CreditCard");
            if (responseMessageCC.IsSuccessStatusCode && responseMessageOrder.IsSuccessStatusCode && responseMessageTodo.IsSuccessStatusCode)
            {
                var jsonDataCC = await responseMessageCC.Content.ReadAsStringAsync();
                var jsonDataOrder = await responseMessageCC.Content.ReadAsStringAsync();
                var jsonDataTodo = await responseMessageCC.Content.ReadAsStringAsync();
                var valuesCC = JsonConvert.DeserializeObject<List<ResultCreditCardDto>>(jsonDataCC);
                var valuesOrder = JsonConvert.DeserializeObject<List<ResultCreditCardDto>>(jsonDataOrder);
                var valuesTodo = JsonConvert.DeserializeObject<List<ResultCreditCardDto>>(jsonDataTodo);
                ViewBag.CreditCards = valuesCC;
                return View(valuesCC);
               
            }
            return View();
        }
    }
}
