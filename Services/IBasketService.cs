using System.Threading.Tasks;
using eShop.Web.ViewModels;

namespace eShop.Web.Services
{
    public interface IBasketService
    {
        Task<Basket> GetBasketAsync(ApplicationUser user);
    }
}