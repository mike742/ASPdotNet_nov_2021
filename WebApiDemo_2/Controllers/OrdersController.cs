using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo_2.Data;
using WebApiDemo_2.Models;

namespace WebApiDemo_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var ordersDto = _context.Orders
                                .Select(o => _mapper.Map(o))
                                .ToList();
            var products = _context.Products.ToList();
            var orderProducts = _context.OrderProducts.ToList();

            foreach (var order in ordersDto)
            {
                List<Product> productToAdd = new List<Product>();

                foreach (var op in orderProducts)
                {
                    if (op.OrderId == order.Id)
                    {
                        var obj =
                            products.FirstOrDefault(p => p.Id == op.PoductId);
                        productToAdd.Add(obj);
                    }
                }

                order.Products = productToAdd;
            }

            return Ok(ordersDto); 
        }
    }
}
