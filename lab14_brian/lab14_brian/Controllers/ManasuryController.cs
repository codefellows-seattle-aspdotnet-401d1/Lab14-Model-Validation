using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab14_brian.Models;

namespace lab14_brian.Controllers
{
    public class ManasuryController : Controller
    {
        private readonly lab14_brianContext _context;

        public ManasuryController(lab14_brianContext context)
        {
            _context = context;
        }

        // GET: Manasury
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dinosaurs.ToListAsync());
        }

        // GET: Manasury/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaurs = await _context.Dinosaurs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (dinosaurs == null)
            {
                return NotFound();
            }

            return View(dinosaurs);
        }

        // GET: Manasury/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manasury/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,IsCarnivore")] Dinosaurs dinosaurs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dinosaurs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dinosaurs);
        }

        // GET: Manasury/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaurs = await _context.Dinosaurs.SingleOrDefaultAsync(m => m.ID == id);
            if (dinosaurs == null)
            {
                return NotFound();
            }
            return View(dinosaurs);
        }

        // POST: Manasury/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,IsCarnivore")] Dinosaurs dinosaurs)
        {
            if (id != dinosaurs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dinosaurs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DinosaursExists(dinosaurs.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dinosaurs);
        }

        // GET: Manasury/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaurs = await _context.Dinosaurs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (dinosaurs == null)
            {
                return NotFound();
            }

            return View(dinosaurs);
        }

        // POST: Manasury/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dinosaurs = await _context.Dinosaurs.SingleOrDefaultAsync(m => m.ID == id);
            _context.Dinosaurs.Remove(dinosaurs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DinosaursExists(int id)
        {
            return _context.Dinosaurs.Any(e => e.ID == id);
        }
    }
}
