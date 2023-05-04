using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Models
{
    public class PriceModel
    {
        
        [Key]
        public int book_id { get; set; }
        public int price_id { get; set; }
        public decimal price { get; set; }

        public ICollection<BookModel> BookModel { get; set; }

    }
}
