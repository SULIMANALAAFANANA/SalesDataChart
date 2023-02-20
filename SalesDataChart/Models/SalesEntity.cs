using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDataChart.Models
{
    public class SalesEntity
    {
        public int Id { get; set; }
        public string Monthname { get; set; }
        public int TotalSales { get; set; }
    }
}
