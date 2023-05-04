using Microsoft.EntityFrameworkCore;
using CRWBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Data {
    public class StoreDbContext : DbContext {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<BookModel> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
