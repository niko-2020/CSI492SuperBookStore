using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRWBookStore.Data;

namespace SuperBookStore.Controllers
{
    
    public class PDFController : Controller
    {
        private readonly DataContext _db;

        public PDFController(DataContext db)
        {
            this._db = db;
        }

        [HttpGet("pdfapi/all")]
        public ActionResult<IEnumerable<PDFApiResult>> GetAll()
        {
            var displayData = _db.PDFs.ToList();

            List<PDFApiResult> result = new List<PDFApiResult>();

            foreach (var item in displayData)
            {
                
                result.Add(new PDFApiResult { Name = item.pdf_name });
            }

            return result;
           
        }
    }

     public class PDFApiResult{
        public string Name { get; set; }
        public string Link { get; internal set; }
    }

    
}
