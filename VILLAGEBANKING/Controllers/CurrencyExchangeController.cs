#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using VILLAGEBANKING.Models;

namespace VILLAGEBANKING.Controllers
{
    [Authorize]
    public class CurrencyExchangeController : Controller
    {
        private readonly CurrencyDBContext _context;

        public CurrencyExchangeController(CurrencyDBContext context)
        {
            _context = context;
        }

        // GET: CurrencyExchange
        public async Task<IActionResult> Index()
        {
            return View(await _context.Currency.ToListAsync());
        }

        // GET: CurrencyExchange/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currencyExchangeModel = await _context.Currency
                .FirstOrDefaultAsync(m => m.CurrencyId == id);
            if (currencyExchangeModel == null)
            {
                return NotFound();
            }

            return View(currencyExchangeModel);
        }

        // GET: CurrencyExchange/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CurrencyExchange/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CurrencyId,CurrencyName,Price")] CurrencyExchangeModel currencyExchangeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(currencyExchangeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(currencyExchangeModel);
        }

        // GET: CurrencyExchange/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currencyExchangeModel = await _context.Currency.FindAsync(id);
            if (currencyExchangeModel == null)
            {
                return NotFound();
            }
            return View(currencyExchangeModel);
        }

        // POST: CurrencyExchange/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CurrencyId,CurrencyName,Price")] CurrencyExchangeModel currencyExchangeModel)
        {
            if (id != currencyExchangeModel.CurrencyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(currencyExchangeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurrencyExchangeModelExists(currencyExchangeModel.CurrencyId))
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
            return View(currencyExchangeModel);
        }

        // GET: CurrencyExchange/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currencyExchangeModel = await _context.Currency
                .FirstOrDefaultAsync(m => m.CurrencyId == id);
            if (currencyExchangeModel == null)
            {
                return NotFound();
            }

            return View(currencyExchangeModel);
        }

        // POST: CurrencyExchange/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currencyExchangeModel = await _context.Currency.FindAsync(id);
            _context.Currency.Remove(currencyExchangeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurrencyExchangeModelExists(int id)
        {
            return _context.Currency.Any(e => e.CurrencyId == id);
        }
    }
}
