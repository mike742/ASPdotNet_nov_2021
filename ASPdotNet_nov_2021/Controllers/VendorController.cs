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
        private readonly IProductRepo _prodRepo;

        public VendorController(IVendorRepo repo, IProductRepo prodRepo)
        {
            _repo = repo;
            _prodRepo = prodRepo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllVendors());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VendorDto input)
        {
            _repo.CreateVendor(input);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_repo.GetVendor(id));
        }

        [HttpPost]
        public IActionResult Update(VendorDto input)
        {
            _repo.UpdateVendor(input);
            return RedirectToAction("Index");
        }
        public IEnumerable<string> GetProductsByVendorId(int id)
        {
            var result = _prodRepo.GetAll()
                .Where(p => p.V_code == id)
                .Select(p => p.P_descript + "\t" + p.P_Price + "<br>");

            if (result == null || result.Count() == 0)
            {
                return new List<string> { "No Product found " };
            }

            return result;
        }
    }
}
