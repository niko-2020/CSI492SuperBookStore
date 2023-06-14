using Microsoft.AspNetCore.Mvc;
using CRWBookStore.Models;
using System.Linq;
namespace CRWBookStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        [HttpGet]
        public ViewResult ShowOrder(Order order)
        {
            return View("ThankYou");
        }

        [HttpGet]
        public ViewResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                // insert to database
                cart.Clear();
                return View("ThankYou", order);
            }
            else
            {
                return View();
            }
        }
        public IActionResult PaymentInfo()
        {
            return View();
        }

        /*
        [HttpPost]
        public IActionResult PaymentInfo()
        {

        }*/

    }
}
