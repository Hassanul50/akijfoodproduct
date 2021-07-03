using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkijFood.Models;
using Microsoft.EntityFrameworkCore;
using static AkijFood.Models.FoodClass;

namespace AkijFood.Controllers
{
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FoodController(ApplicationDbContext db)
        {
            _db = db;    
        }

        public IActionResult Index()
        {
            var displayData = _db.tblColdDrinks.ToList();
            return View(displayData);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(FoodClass nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.tblColdDrinks.FindAsync(id);
            return View(getempdetails);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(FoodClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.tblColdDrinks.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            
            var getempdetails = await _db.tblColdDrinks.FindAsync(id);
            _db.tblColdDrinks.Remove(getempdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

            return View(getempdetails);
        }


        

        
    }
}
