using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestorantsController: ControllerBase
    {
        private readonly FoodContext _context;

        public RestorantsController(FoodContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restorant>>>GetRestorants(){
            var restorants = await _context.Restorants.ToListAsync();
            if(restorants==null){
                return NotFound();
            }
            return Ok(restorants);
        }


        [HttpPost]
        public async Task<IActionResult> AddRestorant(Restorant restorant){
            
                _context.Restorants.Add(restorant);
                await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetRestorants), new {id=restorant.RestorantId}, restorant);
        }


        [HttpGet("kitchen/{id}")]
        public async Task<IActionResult> GetRestorantKitchenById(int id){
            var restorants = await _context
            .Restorants
            .Where(i=>i.KitchenId ==id)
            .ToListAsync();

            if(restorants== null){
                return NotFound();
            }
            return Ok(restorants);
        }

        // [HttpPost("login")]
        // public async Task<IActionResult> Login(Restorant restorant ){
        //     var user = await _context.Restorants
        //     (restorant.RestorantEMail, restorant.Parola).ToListAsync();
        // }
        
    }
}