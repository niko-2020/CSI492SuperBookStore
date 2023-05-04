using CRWBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _db;
        public CartController(DataContext db)
        {
            _db = db;
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public async Task<IActionResult> AddToCart(int customer_id,int book_id,int count)
        {
            return View();
        }
    }
}
