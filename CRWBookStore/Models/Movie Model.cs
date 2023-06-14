using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Models
{
    public class MovieModel
    {
        [Key]
        public int ID { get; set; }
        public string movie_name { get; set; }
        public string link { get; set; }
        public string movie_picture { get; set; }
        
    }
}


