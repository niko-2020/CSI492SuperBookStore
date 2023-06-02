using CRWBookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Data
{
    public class PDFContext :DbContext
    {

        public DbSet<PDFModel> PDFModel { get; set; }
        //public DbSet<PriceModel> PriceModel { get; set; }
    }
}
