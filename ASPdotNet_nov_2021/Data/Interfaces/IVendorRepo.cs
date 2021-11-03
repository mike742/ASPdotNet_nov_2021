using ASPdotNet_nov_2021.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Data.Interfaces
{
    public interface IVendorRepo
    {
        // CRUD
        void CreateVendor(VendorDto value);

        IEnumerable<VendorDto> GetAllVendors();
        VendorDto GetVendor(int id);

        void UpdateVendor(VendorDto value);

        void DeleteVendor(int id);
    }
}
