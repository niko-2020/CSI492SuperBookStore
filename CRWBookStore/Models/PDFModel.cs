using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBookStore.Models
{
    public class PDFModel
    {
        [Key]
        public int ID { get; set; }
        public string pdf_name { get; set; }
        public string link { get; set; }
        public string pdf_picture { get; set; }
    }
}
