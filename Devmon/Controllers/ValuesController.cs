using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devmon.Models;
using Npgsql;
using System.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Devmon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AppDbContext db = new AppDbContext();
        // GET: api/<ValuesController>
        [HttpGet("ms02")]
        public IActionResult ms02()
        {
            var item = db.ms_02.ToList();
            return Ok(item);
        }
        [HttpGet("ms04")]

        public IActionResult ms04()
        {
            var item = db.ms_04.ToList();
            return Ok(item);
        }
        public IActionResult ms06()
        {
            var item = db.ms_02.ToList();
            return Ok(item);
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = db.ms_02.Find(id);
            return Ok(item);
            
        }
        // POST api/<ValuesController>
        [HttpPost("ms02")]
        public string ms02([FromBody] ms02 item)
        {

            try
            {
                var max_id = db.ms_02.Select(c => c.id).Max();
                if (ModelState.IsValid)
                {
                    var max = Convert.ToInt32( max_id + 1);
                    item.id = max;
                    db.ms_02.Add(item);
                    db.SaveChanges();
                }
                return "berhasil";

            }
            catch
            {
                return "Gagal";
            }
        }
        [HttpPost("ms04")]
        public string ms04([FromBody] ms04 item)
        {

            try
            {
                var max_id = db.ms_04.Select(c => c.id).Max();
                if (ModelState.IsValid)
                {
                    var max = Convert.ToInt32(max_id + 1);
                    item.id = max;
                    db.ms_04.Add(item);
                    db.SaveChanges();
                }
                return "berhasil";

            }
            catch
            {
                return "Gagal";
            }
        }

        [HttpPost("ms06")]
        public string ms06([FromBody] ms06 item)
        {

            try
            {
                var max_id = db.ms_06.Select(c => c.id).Max();
                if (ModelState.IsValid)
                {
                    var max = Convert.ToInt32(max_id + 1);
                    item.id = max;
                    var id = max_id + 1;
                    db.ms_06.Add(item);
                    db.SaveChanges();
                }
                return "berhasil";

            }
            catch
            {
                return "Gagal";
            }
        } 



       
    }
}
