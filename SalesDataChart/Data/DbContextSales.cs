using System;
using Microsoft.EntityFrameworkCore;
using SalesDataChart.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDataChart.Data
{
    public class DbContextSales : DbContext
    {
        public DbContextSales( DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesEntity> SalesData { get; set; }
    }
}
