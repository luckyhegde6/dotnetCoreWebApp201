using System;
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
    public class IndexModel : PageModel
    {
        private readonly CryptoCoinDemo.Data.CryptoCoinDemoContext _context;

        public IndexModel(CryptoCoinDemo.Data.CryptoCoinDemoContext context)
        {
            _context = context;
        }

        public IList<Coin> Coin { get;set; }

        public async Task OnGetAsync()
        {
            Coin = await _context.Coin.ToListAsync();
        }
    }
}
