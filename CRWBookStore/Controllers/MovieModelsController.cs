using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRWBookStore.Models;
using SuperBookStore.Data;

namespace SuperBookStore.Controllers
{
    public class MovieModelsController : Controller
    {
        private readonly SuperBookStoreContext _context;

        public MovieModelsController(SuperBookStoreContext context)
        {
            _context = context;
        }

        // GET: MovieModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
        }

        // GET: MovieModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movieModel == null)
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // GET: MovieModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovieModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,movie_name,link,movie_picture")] MovieModel movieModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieModel);
        }

        // GET: MovieModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie.FindAsync(id);
            if (movieModel == null)
            {
                return NotFound();
            }
            return View(movieModel);
        }

        // POST: MovieModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,movie_name,link,movie_picture")] MovieModel movieModel)
        {
            if (id != movieModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieModelExists(movieModel.ID))
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
            return View(movieModel);
        }

        // GET: MovieModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movieModel == null)
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // POST: MovieModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieModel = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movieModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieModelExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }
    }
}
