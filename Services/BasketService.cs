using System.Threading.Tasks;
using eShop.Web.Controllers;
using eShop.Web.ViewModels;
using System.Net.Http;
using eShop.Web.Infrastructure;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace eShop.Web.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _apiClient;
        private readonly string _basketUrl;

        public BasketService(IOptions<AppSettings> settings, HttpClient apiClient)
        {
            _apiClient = apiClient;
            _basketUrl = $"{settings.Value.BasketUrl}/api/v1/basket";
        }

        public async Task<Basket> GetBasketAsync(ApplicationUser user)
        {
            var getBasketUri = Api.Basket.GetBasket(_basketUrl, user.Id);

            var dataString = await _apiClient.GetStringAsync(getBasketUri);

            var response = JsonConvert.DeserializeObject<Basket>(dataString);

            return response;
        }
    }
}
