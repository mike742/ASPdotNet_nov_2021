using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo_2.Data;
using WebApiDemo_2.Models;
using WebApiDemo_2.ModelsDto;

namespace WebApiDemo_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var productInDb = _context.Products
                .FirstOrDefault(p => p.Id == id);

            if (productInDb != null)
            {
                return Ok(productInDb);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Post(ProductDto value)
        {
            // _context.Products.Add(value);
            var productToAdd = _mapper.Map(value);
            _context.Products.Add(productToAdd);
            _context.SaveChanges();
            
            return Ok(productToAdd);
        }
    }
}
