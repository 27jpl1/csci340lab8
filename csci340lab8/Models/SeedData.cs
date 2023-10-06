using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;
using RazorPagesMovie.Models;

namespace csci340lab8.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new csci340lab8Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<csci340lab8Context>>()))
        {
            if (context == null || context.Session == null)
            {
                throw new ArgumentNullException("Null csci340lab8Context");
            }

            // Look for any movies.
            if (context.Session.Any())
            {
                return;   // DB has been seeded
            }

            context.Session.AddRange(
                new Session
                {
                    GameTitle = "RocketLeauge",
                    Date = DateTime.Parse("2023-10-05"),
                    Wins = 10,
                    Losses = 2,
                    StartTime = TimeOnly.Parse("17:30:25"),
                    EndTime = TimeOnly.Parse("19:30:25"),
                    RankChange = "Up a Rank"
                },

                new Session
                {
                    GameTitle = "RocketLeauge",
                    Date = DateTime.Parse("2023-10-04"),
                    Wins = 2,
                    Losses = 1,
                    StartTime = TimeOnly.Parse("14:00:25"),
                    EndTime = TimeOnly.Parse("14:30:25"),
                    RankChange = "Up a Division"
                },

                new Session
                {
                    GameTitle = "TFT",
                    Date = DateTime.Parse("2023-10-03"),
                    Wins = 3,
                    Losses = 3,
                    StartTime = TimeOnly.Parse("12:45:25"),
                    EndTime = TimeOnly.Parse("15:15:25"),
                    RankChange = "No Change"
                },

                new Session
                {
                    GameTitle = "Smash Bros Ultimate",
                    Date = DateTime.Parse("2023-10-01"),
                    Wins = 5,
                    Losses = 5,
                    StartTime = TimeOnly.Parse("9:50:25"),
                    EndTime = TimeOnly.Parse("11:20:25"),
                    RankChange = "NA"
                }
            );
            context.SaveChanges();
        }
    }
}