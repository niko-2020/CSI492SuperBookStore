using Microsoft.AspNetCore.Mvc;
using CRWBookStore.Models;
using System.Linq;
using CRWBookStore.Data;
using System.Threading.Tasks;
using SuperBookStore.Models;
using SuperBookStore.Data;

namespace CRWBookStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        private SuperBookStoreContext _db;


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
        public IActionResult Checkout(Order order,OrderModel od )
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                /*// insert to database
                _db.Add(od);
                //await _db.SaveChanges();
                OrderModel ord = new OrderModel();
                od.Id = order.OrderID;               
                od.delivery_address = order.Line1+order.City+","+order.State+order.Zip;
                */
                
                return View("ThankYou", order);
                cart.Clear();
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
