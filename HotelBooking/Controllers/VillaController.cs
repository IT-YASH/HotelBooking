﻿using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        } 
        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();  
            return View(villas);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj) 
        {
            if(obj.Name == obj.Descrition) {
                ModelState.AddModelError("", "The Description cannot Exactly match the name");
            }
            if (ModelState.IsValid)
            {
            _db.Villas.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Update(int villaID)
        {
            Villa? obj = _db.Villas.FirstOrDefault(u=>u.Id == villaID);
           // Villa? obj = _db.Villas.Find(villaId);
           // var villalist = _db.Villas.Where(u=>u.Price > 50 && u.Occupancy > 0).FirstOrDefault();
            if(obj == null)
            {
                return RedirectToAction("Error","Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Villa obj)
        {
            if (ModelState.IsValid )
            {
                _db.Villas.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
