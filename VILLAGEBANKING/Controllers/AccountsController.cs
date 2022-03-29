﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VILLAGEBANKING.Models;

namespace VILLAGEBANKING.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AccountsDBContext _context;

        public AccountsController(AccountsDBContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsModel = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (accountsModel == null)
            {
                return NotFound();
            }

            return View(accountsModel);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountId,FirstName,LastName,Address,Phone,Email")] AccountsModel accountsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountsModel);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsModel = await _context.Accounts.FindAsync(id);
            if (accountsModel == null)
            {
                return NotFound();
            }
            return View(accountsModel);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountId,FirstName,LastName,Address,Phone,Email")] AccountsModel accountsModel)
        {
            if (id != accountsModel.AccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountsModelExists(accountsModel.AccountId))
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
            return View(accountsModel);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsModel = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (accountsModel == null)
            {
                return NotFound();
            }

            return View(accountsModel);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountsModel = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(accountsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountsModelExists(int id)
        {
            return _context.Accounts.Any(e => e.AccountId == id);
        }
    }
}
