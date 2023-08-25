using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController:ControllerBase
    {
        private readonly FoodContext _context;
        private readonly UserManager<User> _userManager;
        public LoginController(FoodContext context, UserManager<User> userManager)
    {
        _context = context;
        _userManager= userManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetProducts()
    {
        var products = await _userManager
        .Users
        .ToListAsync();
        if (products == null)
        {
            return NotFound();
        }
        return Ok(products);
    }


    
        
    }
}