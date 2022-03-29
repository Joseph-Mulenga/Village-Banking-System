using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VILLAGEBANKING.Models;
using Microsoft.AspNetCore.Authorization;

namespace VILLAGEBANKING.Controllers
{
    [Authorize]
    public class LoansController : Controller
    {
        private readonly LoansDBContext _context;

        public LoansController(LoansDBContext context)
        {
            _context = context;
        }

        // GET: Loans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Loans.ToListAsync());
        }

        // GET: Loans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loansModel = await _context.Loans
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loansModel == null)
            {
                return NotFound();
            }

            return View(loansModel);
        }

        // GET: Loans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoanId,AccountName,AccountType,AccountId,LoanInterestRate,LoanPrincipal,LoanBalance,LoanPayementPeriod,LoanInstallmentStartDate,LoanInstallmentEndDate")] LoansModel loansModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loansModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loansModel);
        }

        // GET: Loans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loansModel = await _context.Loans.FindAsync(id);
            if (loansModel == null)
            {
                return NotFound();
            }
            return View(loansModel);
        }

        // POST: Loans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoanId,AccountName,AccountType,AccountId,LoanInterestRate,LoanPrincipal,LoanBalance,LoanPayementPeriod,LoanInstallmentStartDate,LoanInstallmentEndDate")] LoansModel loansModel)
        {
            if (id != loansModel.LoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loansModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoansModelExists(loansModel.LoanId))
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
            return View(loansModel);
        }

        // GET: Loans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loansModel = await _context.Loans
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loansModel == null)
            {
                return NotFound();
            }

            return View(loansModel);
        }

        // POST: Loans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loansModel = await _context.Loans.FindAsync(id);
            _context.Loans.Remove(loansModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoansModelExists(int id)
        {
            return _context.Loans.Any(e => e.LoanId == id);
        }
    }
}
