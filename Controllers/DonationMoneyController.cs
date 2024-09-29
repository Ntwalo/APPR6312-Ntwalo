using Ntwalo_APPR6312.Data;
using Microsoft.AspNetCore.Mvc;
using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Ntwalo_APPR6312.Repository;

namespace Ntwalo_APPR6312.Controllers
{
    public class DonationMoneyController : Controller
    {
        private readonly IDonationMoneyRepository _donationMoneyRepository;
        public DonationMoneyController(IDonationMoneyRepository donationMoneyRepository)
        {
            _donationMoneyRepository = donationMoneyRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<DonationMoney> donationsMoney = await _donationMoneyRepository.GetAll();
            return View(donationsMoney);
        }

        public async Task<IActionResult> Details(int id)
        {
            DonationMoney donationMoney = await _donationMoneyRepository.GetByIdAsync(id);
            return View(donationMoney);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DonationMoney donationMoney)
        {
            if (!ModelState.IsValid)
            {
                return View(donationMoney);
            }
            _donationMoneyRepository.Add(donationMoney);
            return RedirectToAction("Index");
        }
    }
}
