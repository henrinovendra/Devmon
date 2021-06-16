using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devmon.Models;

namespace Devmon.Controllers
{
    public class DataController : Controller
    {
        AppDbContext db = new AppDbContext(); 
        public IActionResult Index()
        {
            var item_02 = db.ms_02.ToList();
            var item_04 = db.ms_04.ToList();
            var item_06 = db.ms_06.ToList();
            ViewBag.item02 = item_02;
            ViewBag.item04 = item_04;
            ViewBag.item06 = item_06;

            return View();
        }
        [HttpPost("post")]
        public IActionResult post(ms02 ms_02, ms04 ms_04, ms06 ms_06)
        {
            var ms2 = db.ms_02.Add(ms_02);
            var ms4 = db.ms_04.Add(ms_04);
            var ms6 = db.ms_06.Add(ms_06);
            return View();
        }
        public JsonResult GetRealTimeData()
        {
            
            var suhu = db.ms_02.Where(c=> c.lokasi=="enginer").Select(c => new { c.sensorsuhu_out }).ToList();
            return Json(suhu);
        }
        
    }
}
