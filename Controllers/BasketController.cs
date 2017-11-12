using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Web.Services;
using eShop.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketSvc;

        public BasketController(IBasketService basketSvc)
        {
            _basketSvc = basketSvc;
        }

        // GET: Basket
        public async Task<IActionResult> Index()
        {
            var user = new ApplicationUser(); //TODO:create an applicationUser class
            var viewModel = await _basketSvc.GetBasketAsync(user);
            return View(viewModel);
        }
    }
}