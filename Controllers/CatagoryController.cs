using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Ntwalo_APPR6312.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ntwalo_APPR6312.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ICatagoryRepository _catagoryRepository;

        public CatagoryController(ICatagoryRepository catagoryRepository)
        {
            _catagoryRepository = catagoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Catagory> catagory = await _catagoryRepository.GetAll();
            return View(catagory);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Catagory catagory)
        {
            if (!ModelState.IsValid)
            {
                return View(catagory);
            }
            _catagoryRepository.Add(catagory);
            return RedirectToAction("Index");
        }
    }
}
