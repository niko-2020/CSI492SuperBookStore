using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using CRWBookStore.Infrastructure;
using CRWBookStore.Models;

namespace CRWBookStore.Models
{

    public class SessionCart : Cart {

        public static Cart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(BookModel book, int quantity)
        {
            base.AddItem(book, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(BookModel book) {
            base.RemoveLine(book);
            Session.SetJson("Cart", this);
        }

        public override void Clear() {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
