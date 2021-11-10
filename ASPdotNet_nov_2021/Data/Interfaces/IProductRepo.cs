using ASPdotNet_nov_2021.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Data.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(string id);
        void Create(ProductDto product);
    }
}
