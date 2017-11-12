using System.Collections.Generic;

namespace eShop.Web.ViewModels
{
    public class Basket
    {
        public List<BasketItem> Items { get; set; }
        public string CustomerId { get; set; }
    }
}