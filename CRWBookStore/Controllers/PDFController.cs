using Microsoft.AspNetCore.Mvc;
using CRWBookStore.Data;
using CRWBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRWBookStore.Controllers
{
    //[ApiController]
    public class PDFController : Controller
    {
        private readonly DataContext _db;


        public PDFController(DataContext db)
        {
            _db = db;
        }

        public IActionResult BrowsePDF()
        {
            var displayData = _db.PDFs.ToList();
            return View("BrowsePDF", displayData);
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
