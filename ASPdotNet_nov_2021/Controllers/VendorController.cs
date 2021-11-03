using ASPdotNet_nov_2021.Data.Interfaces;
using ASPdotNet_nov_2021.ModelsDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNet_nov_2021.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _repo;

        public VendorController(IVendorRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllVendors());
        }
    }
}
