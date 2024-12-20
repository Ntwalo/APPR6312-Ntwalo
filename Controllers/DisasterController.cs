﻿using Ntwalo_APPR6312.Data;
using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ntwalo_APPR6312.Repository;
using Ntwalo_APPR6312.ViewModels;

namespace Ntwalo_APPR6312.Controllers
{
    public class DisasterController : Controller
    {
        private readonly IDisasterRepository _disasterRepository;

        public DisasterController(IDisasterRepository disasterRepository)
        {
            _disasterRepository = disasterRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Disaster> disaster = await _disasterRepository.GetAll();
            return View(disaster);
        }

        public async Task<IActionResult> Details(int id)
        {
            Disaster disaster = await _disasterRepository.GetByIdAsync(id);
            return View(disaster);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Disaster disaster)
        {
            if (!ModelState.IsValid)
            {
                return View(disaster);
            }
            _disasterRepository.Add(disaster);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var disaster = await _disasterRepository.GetByIdAsync(id);
            if (disaster == null) return View("Error");
            var disasterVM = new EditDisasterViewModel
            {
                Title = disaster.Title,
                Location = disaster.Location,
                Description = disaster.Description,
                StartDate = disaster.StartDate,
                EndDate = disaster.EndDate
            };
            return View(disasterVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditDisasterViewModel disasterVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit disastser");
                return View("Edit", disasterVM);
            }

            var userDisaster = await _disasterRepository.GetByIdAsync(id);

            if (userDisaster != null)
            {

            }
            return View("Edit", disasterVM);
        }
    }
}
