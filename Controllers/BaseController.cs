using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Electronics_Store.Models;

namespace Electronics_Store.Controllers
{
    public class BaseController : Controller
    {
        protected ElectronicsStoreDbEntities _ctx = new ElectronicsStoreDbEntities();

        public BaseController()
        {
            ViewBag.CartTotalPrice = CartTotalPrice;
            ViewBag.Cart = Cart;
            ViewBag.CartUnits = Cart.Count;
        }

        private List<ShoppingCartData> Cart
        {
            get
            {
                return _ctx.ShoppingCartDatas.ToList();
            }
        }

        private decimal CartTotalPrice
        {
            get
            {
                return Cart.Sum(c => c.Quantity * c.UnitPrice);
            }
        }
    }
}