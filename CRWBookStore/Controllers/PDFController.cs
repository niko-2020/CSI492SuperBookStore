using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBookStore.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult BrowsePDF()
        {
            return View();
        }
    }
}
