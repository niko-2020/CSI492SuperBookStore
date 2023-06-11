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
    public class PDFModelsController : Controller
    {
        private readonly SuperBookStoreContext _context;

        public PDFModelsController(SuperBookStoreContext context)
        {
            _context = context;
        }

        // GET: PDFModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PDFs.ToListAsync());
        }

        // GET: PDFModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDFModel = await _context.PDFs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pDFModel == null)
            {
                return NotFound();
            }

            return View(pDFModel);
        }

        // GET: PDFModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PDFModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,pdf_name,link")] PDFModel pDFModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pDFModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pDFModel);
        }

        // GET: PDFModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDFModel = await _context.PDFs.FindAsync(id);
            if (pDFModel == null)
            {
                return NotFound();
            }
            return View(pDFModel);
        }

        // POST: PDFModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,pdf_name,link")] PDFModel pDFModel)
        {
            if (id != pDFModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pDFModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PDFModelExists(pDFModel.ID))
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
            return View(pDFModel);
        }

        // GET: PDFModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDFModel = await _context.PDFs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pDFModel == null)
            {
                return NotFound();
            }

            return View(pDFModel);
        }

        // POST: PDFModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pDFModel = await _context.PDFs.FindAsync(id);
            _context.PDFs.Remove(pDFModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PDFModelExists(int id)
        {
            return _context.PDFs.Any(e => e.ID == id);
        }
    }
}
