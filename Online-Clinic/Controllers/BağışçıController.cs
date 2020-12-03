using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Clinic.DataAccess;

namespace Online_Clinic.Controllers
{
    public class BağışçıController : Controller
    {
        private readonly AppDbContext _context;

        public BağışçıController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bağışçı
        public async Task<IActionResult> Index()
        {
            await _context.Bağışçılar.ToListAsync();
            return View();
        }

        // GET: Bağışçı/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bağışçı = await _context.Bağışçılar
                .FirstOrDefaultAsync(m => m.BağışçıID == id);
            if (bağışçı == null)
            {
                return NotFound();
            }

            return View(bağışçı);
        }

        // GET: Bağışçı/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bağışçı/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BağışçıID,AdSoyad,DoğumTarihi,Cinsiyet,Tür,Kurum,Özgeçmiş,Adres,Email,Şifre")] Bağışçı bağışçı)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bağışçı);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bağışçı);
        }

        // GET: Bağışçı/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bağışçı = await _context.Bağışçılar.FindAsync(id);
            if (bağışçı == null)
            {
                return NotFound();
            }
            return View(bağışçı);
        }

        // POST: Bağışçı/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BağışçıID,AdSoyad,DoğumTarihi,Cinsiyet,Tür,Kurum,Özgeçmiş,Adres,Email,Şifre")] Bağışçı bağışçı)
        {
            if (id != bağışçı.BağışçıID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bağışçı);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BağışçıExists(bağışçı.BağışçıID))
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
            return View(bağışçı);
        }

        // GET: Bağışçı/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bağışçı = await _context.Bağışçılar
                .FirstOrDefaultAsync(m => m.BağışçıID == id);
            if (bağışçı == null)
            {
                return NotFound();
            }

            return View(bağışçı);
        }

        // POST: Bağışçı/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bağışçı = await _context.Bağışçılar.FindAsync(id);
            _context.Bağışçılar.Remove(bağışçı);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BağışçıExists(int id)
        {
            return _context.Bağışçılar.Any(e => e.BağışçıID == id);
        }
    }
}
