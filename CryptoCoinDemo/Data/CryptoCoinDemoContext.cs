using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CryptoCoinDemo.Models;

namespace CryptoCoinDemo.Data
{
    public class CryptoCoinDemoContext : DbContext
    {
        public CryptoCoinDemoContext (DbContextOptions<CryptoCoinDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CryptoCoinDemo.Models.Coin> Coin { get; set; }
    }
}
