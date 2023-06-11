using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using CRWBookStore.Data;
using CRWBookStore.Models;


namespace SuperBookStore.Controllers
{
    public class addBook : Controller
    {
        public IActionResult Addbook()
        {
            return View("addBook");
        }

        private readonly DataContext _db;

        public addBook(DataContext db)
        {
            _db = db;
        }
        public IActionResult BrowseBooks()
        {
            var displayData = _db.Book.ToList();
            return View("BrowseBooks", displayData);
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }
        [HttpPost]

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


    }
}
