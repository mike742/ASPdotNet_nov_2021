using ASPdotNet_nov_2021.Data.Interfaces;
using ASPdotNet_nov_2021.Models;
using ASPdotNet_nov_2021.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Data.SqlRepos
{
    public class SqlVendorRepo : IVendorRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public SqlVendorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateVendor(VendorDto value)
        {
            Vendor vendorToAdd = _mapper.Map(value);
            _context.Vendors.Add(vendorToAdd);
            _context.SaveChanges();
        }

        public void DeleteVendor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendorDto> GetAllVendors()
        {
            return _context.Vendors
                .Select(v => _mapper.Map(v))
                .ToList();
        }

        public VendorDto GetVendor(int id)
        {
            Vendor vendor = 
                _context.Vendors.FirstOrDefault(v => v.V_code == id);

            if (vendor != null)
            {
                return _mapper.Map(vendor);
            }
            return null;
        }

        public void UpdateVendor(VendorDto value)
        {
            var vendorToUpdate =
                _context.Vendors.FirstOrDefault(v => v.V_code == value.V_code);

            if(vendorToUpdate != null)
            {
                vendorToUpdate.V_AreaCode = value.V_AreaCode;
                vendorToUpdate.V_contact = value.V_contact;
                vendorToUpdate.V_name = value.V_name;
                vendorToUpdate.V_order = value.V_order;
                vendorToUpdate.V_phone = value.V_phone;
                vendorToUpdate.V_state = value.V_state;
            }

            _context.SaveChanges();
        }
    }
}
