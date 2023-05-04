using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Areas.Identity.Data
{
    public class PaymentCardInformation : Controller
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string PhoneNumber { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public int ZipCode { get; set; }

    }
}
