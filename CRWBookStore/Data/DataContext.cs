using Microsoft.EntityFrameworkCore;
using CRWBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using SuperBookStore.Models;

namespace CRWBookStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {       
        
        }

        public DbSet<PDFModel> PDFs { get; set; }
        public DbSet<BookModel> Book { get; set; }
        public DbSet<MovieModel> Movie { get; set; }
        public DbSet<CustomerModel> customers { get; set; }
        //public DbSet<PriceModel> Price { get; set; }

    }
}
