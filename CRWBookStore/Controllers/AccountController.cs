using Microsoft.AspNetCore.Mvc;
using CRWBookStore.Data;
using CRWBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Graph;
using CRWBookStore.Models;
using Admin = CRWBookStore.Models.Admin;

namespace CRWBookStore.Controllers
{
    public class AccountController : Controller
    {

        //Get:Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin model)
        {
            if (model.Username == "niko" && model.Password == "1234")
            {
                return View("AdminPage");
            }
            else
            {
                return Content("Sorry " + model.Username);
            }
        }
    }
}

            /*//Primitive model binding
            [HttpPost]
            public ContentResult Login(string username, string password )
            {
                if(username=="niko"&& password == "1234")
                {
                    return Content("Welcome Niko Wu");
                }
                else
                {
                    return Content("Sorry " + username);
                }
            }*/

            //complex model binding
            /*[HttpPost]
            public ContentResult Login(Admin model)
            {
                if (model.Username == "niko" && model.Password == "1234")
                {
                    return Content("Welcome Niko Wu");
                }
                else
                {
                    return Content("Sorry " + model.Username);
                }
            }*/

            //private readonly IEmployeeRepository 


            /* 
             * /*private readonly DataContext _db;

             public AccountController(DataContext db)
             {
                 _db = db;
             }
             public IActionResult Info()
             {
                 var displayData = _db.customers.ToList();
                 return View("Login",displayData);
             }
            public async Task<IActionResult> Login(int Customer_id)
            {
                if (ModelState.IsValid)
                {
                    _db.Add(Customer_id);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("ContactInfo");
                }
                return View(Customer_id);
            }
            }*/

        

