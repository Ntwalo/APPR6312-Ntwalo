using Ntwalo_APPR6312.Data;
using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Ntwalo_APPR6312.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ntwalo_APPR6312.Controllers.Controllers
{
    public class DonationItemController : Controller
    {
        //private readonly ApplicationDbContext? _context;
        private readonly IDonationItemRepository _donationItemRepository;

        public DonationItemController(IDonationItemRepository donationItemRepository)
        {
            _donationItemRepository = donationItemRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<DonationItem> donationsItems = await _donationItemRepository.GetAll();
            return View(donationsItems);
        }

        public async Task<IActionResult> Details(int id)
        {
            DonationItem donationItem = await _donationItemRepository.GetByIdAsync(id);
            //DonationItem donationItem2 = await _context.Include(a => a.Catagory).FirstOrDefault(c => c.Id == id);
            return View(donationItem);
        }

        public IActionResult Create()
        {
            //var categories = await _context.Catagories.ToListAsync();

            // ViewData["Categories"] = new SelectList(categories, "CategoryId", "CategoryName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(DonationItem donationItem)
        {
            if (!ModelState.IsValid)
            {
                return View(donationItem);
            }
            _donationItemRepository.Add(donationItem);
            return RedirectToAction("Index");
        }
    }
}
