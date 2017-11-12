using System.Threading.Tasks;
using eShop.Web.ViewModels;

namespace eShop.Web.Controllers
{
    public interface IBasketService
    {
        Task<Basket> GetBasketAsync(ApplicationUser user);
    }
}