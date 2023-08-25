using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ServerWApp.DTO;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [ControllerConstructor]
    public class UsersController: ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public readonly IConfiguration _configuration;

        private readonly FoodContext _context;

        public UsersController(FoodContext context,UserManager<User> userManager, SignInManager<User> signInManager,IConfiguration configuration){
            _userManager = userManager; 
            _signInManager = signInManager;
            _configuration = configuration ;
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var user = await _context
            .Users
            .ToListAsync();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        [HttpPost("register")]
        public async Task<ActionResult> Register(UserForRegisterDTO model){
            var user = new User{
                UserName = model.UserName,
                Name= model.Name,
                Email= model.Email,
                Created =DateTime.Now

            };

            var result = await _userManager.CreateAsync(user,model.PasswordHash);

            if(result.Succeeded){

                return StatusCode(201);

            }
        return BadRequest(result.Errors);
        }

        [HttpPost("login")]
         public async Task<IActionResult> Login(UserForLoginDTO model){

            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user==null)
                return BadRequest(new {message= "Bu E-Mail adresine ait hesap bulunmamakta."});
             
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.PasswordHash,false);
            if(result.Succeeded){

                //login
                return Ok(new{
                    token =GenerateJwtToken(user),
                    email = user.Email,
                });
            }
            return Unauthorized();

         }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key =Encoding.ASCII.GetBytes(_configuration.GetSection("AppSettings:Secret").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim("UserId", user.Id.ToString()),
                    new Claim("UserEmail", user.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

    internal class ControllerConstructorAttribute : Attribute
    {
    }
}