using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
// using ServerWApp.Data;
using ServerWApp.Models;

namespace ServerWApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

public class ProductsController : ControllerBase
{
    private readonly FoodContext _context;

    public ProductsController(FoodContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        var products = await _context
        .Products
        .ToListAsync();
        if (products == null)
        {
            return NotFound();
        }
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var product = await _context.Products
        .FirstOrDefaultAsync(i => i.RestorantId == id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    

    [HttpPost]
    public async Task<IActionResult> CreateProducts(Product product){
        
        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProduct), new {id=product.ProductId}, product);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, Product entity){
        if(id != entity.ProductId){
            return BadRequest();
        }

        var product = await _context.Products.FindAsync(id);

        if(product==null){
            return NotFound();
        }
        product.Name =entity.Name;
        product.Price= entity.Price;
        product.Aciklama= entity.Aciklama;
            try
            {
            
        }
        catch (Exception)
            {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id){
        var product = await _context.Products.FindAsync(id);
        if(product==null){
            return NotFound();
        }
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}

}