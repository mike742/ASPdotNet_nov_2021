using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo_2.Models;
using WebApiDemo_2.ModelsDto;

namespace WebApiDemo_2.Data
{
    public class Mapper
    {
        public Product Map(ProductDto input)
        {
            return new Product
            {
               Name = input.Name,
               Price = input.Price
            };
        }

        public OrderDto Map(Order input)
        {
            return new OrderDto
            {
                Id = input.Id,
                Name = input.Name,
                Date = input.Date
            };
        }
    }
}
