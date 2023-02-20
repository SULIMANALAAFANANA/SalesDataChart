using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesDataChart.Data;
using SalesDataChart.Models;

namespace SalesDataChart.Controllers
{
    public class SalesRecordController : Controller
    {
        private readonly DbContextSales _context;

        public SalesRecordController(DbContextSales context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.SalesData.Select(p => p.Monthname).ToList();

            data.Add(labels);

            List<int> SalesNumber = _context.SalesData.Select(p => p.TotalSales).ToList();

            data.Add(SalesNumber);

            return data;

        }
    }
}
