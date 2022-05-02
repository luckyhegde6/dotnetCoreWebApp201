using CryptoCoinDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace CryptoCoinDemo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CryptoCoinDemoContext(
                serviceProvider.GetRequiredService< DbContextOptions <CryptoCoinDemoContext>>()))
            {
                if (context == null || context.Coin == null)
                {
                    throw new ArgumentNullException("Null CryptoDemo Contexts");
                }

                if(context.Coin.Any())
                {
                    return;
                }

                context.Coin.AddRange(
                    new Coin
                    {
                        Name = "ByteCoin",
                        Price = 12345
                    },
                    new Coin
                    {
                        Name = "BinCoin",
                        Price = 1235
                    },
                    new Coin
                    {
                        Name = "DgeCoin",
                        Price = 12
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
