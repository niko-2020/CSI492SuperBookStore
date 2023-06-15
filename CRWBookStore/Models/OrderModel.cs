using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperBookStore.Models
{
    public class OrderModel
    {

        [Key]
        public int Id { get; set; }
        public int book_id { get; set; }
        public int user_id { get; set; }
        public int quantity { get; set; }
        public string orderdate { get; set; }

        public string price { get; set; }
        public string delivery_address { get; set; }
    }
}
