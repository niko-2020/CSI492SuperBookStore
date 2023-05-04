using CRWBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRWBookStore.Controllers
{
    [ApiController]
    public class BookApiController1 : Controller
    {
        private readonly DataContext _db;
        public BookApiController1(DataContext db)
        {
            this._db = db;
        }

        [HttpGet("bookapi/all")]
        public ActionResult<IEnumerable<BookApiResult>> GetAll()
        {
            var displayData = _db.Book.ToList();

            List<BookApiResult> result = new List<BookApiResult>();

            foreach (var item in displayData)
            {
                
                result.Add(new BookApiResult { Name = item.Title });
            }

            return result;
           
        }
    }

    public class BookApiResult
    {
        public string Name { get; set; }
        public decimal Price { get; internal set; }
    }
}
