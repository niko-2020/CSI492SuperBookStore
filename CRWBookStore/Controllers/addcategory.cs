﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace SuperBookStore.Controllers
{
    public class addcategory : Controller
    {
        public IActionResult AddCategory()
        {
            return View("addcategory");
        }
        
    }
}