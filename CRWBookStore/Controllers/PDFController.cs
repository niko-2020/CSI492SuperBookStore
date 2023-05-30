using CRWBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBookStore.Controllers
{
    //[ApiController]
    public class PDFController : Controller
    {
        private readonly DataContext _db;
        public IActionResult BrowsePDF()
        {
            return View();
        }
    }
}
