using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController: ControllerBase
    {
        public readonly FoodContext _context;

        public SiparisController(FoodContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetSiparisler(){
            var siparis = await _context
            .Siparisler
            .ToListAsync();
            if (siparis == null)
            {
                return NotFound();
            }
            return Ok(siparis);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducts(Siparis siparis){
            
            _context.Siparisler.Add(siparis);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSiparisler), new {id=siparis.SiparisId}, siparis);
        }
    }
}