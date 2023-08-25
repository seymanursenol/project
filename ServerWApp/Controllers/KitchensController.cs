using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{    
    
    [ApiController]
    // [EnableCors("CORSOpenPolicy")]
    [Route("api/[controller]")]
    


    public class KitchensController:ControllerBase
    {
        private readonly FoodContext _context;

        public KitchensController(FoodContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kitchen>>>GetKitchens(){
            var kitchens = await _context
            .Kitchens
            .ToListAsync();
            if(kitchens== null){
                return NotFound();
            }
            return Ok(kitchens);

            
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKitchen(int id){
            var kitchens = await _context
            .Kitchens
            .FirstOrDefaultAsync(i=>i.KitchenId ==id);

            if(kitchens== null){
                return NotFound();
            }
            return Ok(kitchens);
        }

        [HttpGet("restorant/{id}")]
        public async Task<IActionResult> GetRestorantById(int id){
            var restorants = await _context
            .Restorants
            .Where(i=>i.KitchenId ==id)
            .ToListAsync();

             if (restorants == null || restorants.Count == 0)
            {
                return NotFound();
            }

            return Ok(restorants);
        }
    }

    
}