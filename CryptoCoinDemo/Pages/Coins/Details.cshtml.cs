﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CryptoCoinDemo.Data;
using CryptoCoinDemo.Models;

namespace CryptoCoinDemo.Pages.Coins
{
    public class DetailsModel : PageModel
    {
        private readonly CryptoCoinDemo.Data.CryptoCoinDemoContext _context;

        public DetailsModel(CryptoCoinDemo.Data.CryptoCoinDemoContext context)
        {
            _context = context;
        }

        public Coin Coin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coin = await _context.Coin.FirstOrDefaultAsync(m => m.Id == id);

            if (Coin == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
