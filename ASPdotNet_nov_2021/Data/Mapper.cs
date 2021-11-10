using ASPdotNet_nov_2021.Models;
using ASPdotNet_nov_2021.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Data
{
    public class Mapper
    {
        public Vendor Map(VendorDto input)
        {
            return new Vendor { 
                V_code = input.V_code,
                V_AreaCode = input.V_AreaCode,
                V_contact = input.V_contact,
                V_name = input.V_name,
                V_order = input.V_order,
                V_phone = input.V_phone,
                V_state = input.V_state
            };
        }

        public VendorDto Map(Vendor input)
        {
            return new VendorDto
            {
                V_code = input.V_code,
                V_AreaCode = input.V_AreaCode,
                V_contact = input.V_contact,
                V_name = input.V_name,
                V_order = input.V_order,
                V_phone = input.V_phone,
                V_state = input.V_state
            };
        }

        public Product Map(ProductDto input)
        {
            return new Product { 
                P_Code = input.P_Code,
                P_descript = input.P_descript,
                P_Discount = input.P_Discount,
                P_InDate = input.P_InDate,
                P_Min = input.P_Min,
                P_Price = input.P_Price,
                P_QOH = input.P_QOH,
                V_code = input.V_code
            };
        }

        public ProductDto Map(Product input)
        {
            return new ProductDto
            {
                P_Code = input.P_Code,
                P_descript = input.P_descript,
                P_Discount = input.P_Discount,
                P_InDate = input.P_InDate,
                P_Min = input.P_Min,
                P_Price = input.P_Price,
                P_QOH = input.P_QOH,
                V_code = input.V_code
            };
        }
    }
}
