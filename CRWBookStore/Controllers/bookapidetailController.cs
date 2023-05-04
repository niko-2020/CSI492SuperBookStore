using CRWBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRWBookStore.Controllers
{
    [ApiController]
    public class bookapidetailController : Controller
    {
        private readonly DataContext _db;
        public bookapidetailController(DataContext db)
        {
            this._db = db;
        }
        [HttpGet("bookapi/detail/{id}")]
        public ActionResult<bookapidetailResult> Get(int id)
        {
           bookapidetailResult Robject = new bookapidetailResult();
            var a = _db.Book.Find(id);

            if (a == null){
                Robject.BookId = id;
                Robject.Name = null;
                Robject.Found = false;
            }
            else
            {
                Robject.BookId = a.Book_id;
                Robject.Name = a.Title;
                Robject.Found = true;
            }
            return Robject;
        }
    }
    public class bookapidetailResult
    {
        public double BookId { get; set; }
        public string Name { get; set; }
        public bool Found { get; set; }

    }
}
