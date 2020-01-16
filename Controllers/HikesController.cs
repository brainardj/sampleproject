using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sampleproject.Models;

namespace sampleproject.Controllers
{
    public class HikesController : Controller
    {
        HikesDataAccessLayer obj_hike = new HikesDataAccessLayer();

        public IActionResult Index()
        {
            List<Hike> list_hike = new List<Hike>();
            list_hike = obj_hike.GetAllHikes().ToList();

            return View(list_hike);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Hike hike)
        {
            if (ModelState.IsValid)
            {
                obj_hike.AddHike(hike);
                return RedirectToAction("Index");
            }
            return View(hike);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Hike hike = obj_hike.GetHikeData(id);

            if (hike == null)
            {
                return NotFound();
            }
            return View(hike);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Hike hike)
        {
            if (id != hike.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                obj_hike.UpdateEmployee(hike);
                return RedirectToAction("Index");
            }
            return View(hike);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Hike hike = obj_hike.GetHikeData(id);

            if (hike == null)
            {
                return NotFound();
            }
            return View(hike);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Hike hike = obj_hike.GetHikeData(id);

            if (hike == null)
            {
                return NotFound();
            }
            return View(hike);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            obj_hike.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}