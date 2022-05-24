using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Paqueteria.Models.dbModels;

namespace Paqueteria.Controllers
{
    public class RepartidoresController : Controller
    {
        private readonly paqueteriaContext _context;

        public RepartidoresController(paqueteriaContext context)
        {
            _context = context;
        }

        // GET: Repartidores
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Repartidores.ToListAsync());
        }

        // GET: Repartidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repartidore = await _context.Repartidores
                .FirstOrDefaultAsync(m => m.IdRepartidor == id);
            if (repartidore == null)
            {
                return NotFound();
            }

            return View(repartidore);
        }

        // GET: Repartidores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Repartidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRepartidor,Nombre,Paterno,Materno,Telefono,Usuario,Contraseña")] Repartidore repartidore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(repartidore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(repartidore);
        }

        // GET: Repartidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repartidore = await _context.Repartidores.FindAsync(id);
            if (repartidore == null)
            {
                return NotFound();
            }
            return View(repartidore);
        }

        // POST: Repartidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRepartidor,Nombre,Paterno,Materno,Telefono,Usuario,Contraseña")] Repartidore repartidore)
        {
            if (id != repartidore.IdRepartidor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repartidore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepartidoreExists(repartidore.IdRepartidor))
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
            return View(repartidore);
        }

        // GET: Repartidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repartidore = await _context.Repartidores
                .FirstOrDefaultAsync(m => m.IdRepartidor == id);
            if (repartidore == null)
            {
                return NotFound();
            }

            return View(repartidore);
        }

        // POST: Repartidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var repartidore = await _context.Repartidores.FindAsync(id);
            _context.Repartidores.Remove(repartidore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepartidoreExists(int id)
        {
            return _context.Repartidores.Any(e => e.IdRepartidor == id);
        }
    }
}
