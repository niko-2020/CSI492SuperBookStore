using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRWBookStore.Models;
using SuperBookStore.Models;

namespace SuperBookStore.Data
{
    public class SuperBookStoreContext : DbContext
    {
        public SuperBookStoreContext (DbContextOptions<SuperBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BookModel> Book { get; set; }

        public DbSet<PDFModel> PDFs { get; set; }

        public DbSet<OrderModel> order { get; set; }

        public DbSet<MovieModel> Movie { get; set; }
    }
}
