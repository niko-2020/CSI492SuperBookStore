using CRWBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        //[] is for attribut routing.
        /*[Route("")]
        [Route("Index")]
        [Route("~/")]*/
        public IActionResult Index()
        {
            return View();
        }

        [Route("~/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
