using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Models
{
    public class PDFModel
    {
        [Key]
        public int ID { get; set; }
        public string pdf_name { get; set; }
        public string link { get; set; }
        /*
        public int Book_id { get; set; }
        public string Title { get; set; }
        public int Publisher_id { get; set; }
        public int Num_pages { get; set; }
        public int Language_id { get; set; }
        public string isbn13 { get; set; }

        public DateTime Publication_date { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }
        public string picture { get; set; }
        */
    }
}


