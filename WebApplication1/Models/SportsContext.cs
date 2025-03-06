using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class SportsContext : DbContext
    {
        public DbSet<OlympicSport> OlympicSports { get; set; }

        public SportsContext(DbContextOptions<SportsContext> options) :
            base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OlympicSport>().HasData(
                new OlympicSport { Id = 1, Name = "Canada", Game = "Winter Olympics", Sport = "Curling", Category = "Indoor", CountryCode = "ca" },
                new OlympicSport { Id = 2, Name = "Sweden", Game = "Winter Olympics", Sport = "Curling", Category = "Indoor", CountryCode = "se"},
                new OlympicSport { Id = 3, Name = "Great Britain", Game = "Winter Olympics", Sport = "Curling", Category = "Indoor", CountryCode = "gb" },
                new OlympicSport { Id = 4, Name = "Jamaica", Game = "Winter Olympics", Sport = "Bobsleigh", Category = "Outdoor", CountryCode = "jm" },
                new OlympicSport { Id = 5, Name = "Italy", Game = "Winter Olympics", Sport = "Bobsleigh", Category = "Outdoor", CountryCode = "it" },
                new OlympicSport { Id = 6, Name = "Japan", Game = "Winter Olympics", Sport = "Bobsleigh", Category = "Outdoor", CountryCode = "jp" },
                new OlympicSport { Id = 7, Name = "Germany", Game = "Summer Olympics", Sport = "Diving", Category = "Indoor", CountryCode = "de" },
                new OlympicSport { Id = 8, Name = "China", Game = "Summer Olympics", Sport = "Diving", Category = "Indoor", CountryCode = "cn" },
                new OlympicSport { Id = 9, Name = "Mexico", Game = "Summer Olympics", Sport = "Diving", Category = "Indoor", CountryCode = "mx" },
                new OlympicSport { Id = 10, Name = "Brazil", Game = "Summer Olympics", Sport = "Road Cycling", Category = "Outdoor", CountryCode = "br" },
                new OlympicSport { Id = 11, Name = "Netherlands", Game = "Summer Olympics", Sport = "Cycling", Category = "Outdoor", CountryCode = "nl" },
                new OlympicSport { Id = 12, Name = "USA", Game = "Summer Olympics", Sport = "Road Cycling", Category = "Outdoor", CountryCode = "us" },
                new OlympicSport { Id = 13, Name = "Thailand", Game = "Paralympics", Sport = "Archery", Category = "Indoor", CountryCode = "th" },
                new OlympicSport { Id = 14, Name = "Uruguay", Game = "Paralympics", Sport = "Archery", Category = "Indoor", CountryCode = "uy" },
                new OlympicSport { Id = 15, Name = "Ukraine", Game = "Paralympics", Sport = "Archery", Category = "Indoor", CountryCode = "ua" },
                new OlympicSport { Id = 16, Name = "Austria", Game = "Paralympics", Sport = "Canoe Sprint", Category = "Outdoor", CountryCode = "at" },
                new OlympicSport { Id = 17, Name = "Pakistan", Game = "Paralympics", Sport = "Canoe Sprint", Category = "Outdoor", CountryCode = "pk" },
                new OlympicSport { Id = 18, Name = "Zimbabwe", Game = "Paralympics", Sport = "Canoe Sprint", Category = "Outdoor", CountryCode = "zw" },
                new OlympicSport { Id = 19, Name = "France", Game = "Youth Olympic Games", Sport = "Breakdancing", Category = "Indoor", CountryCode = "fr" },
                new OlympicSport { Id = 20, Name = "Cyprus", Game = "Youth Olympic Games", Sport = "Breakdancing", Category = "Indoor", CountryCode = "cy" },
                new OlympicSport { Id = 21, Name = "Russia", Game = "Youth Olympic Games", Sport = "Breakdancing", Category = "Indoor", CountryCode = "ru" },
                new OlympicSport { Id = 22, Name = "Finland", Game = "Youth Olympic Games", Sport = "Skateboarding", Category = "Outdoor", CountryCode = "fi"  },
                new OlympicSport { Id = 23, Name = "Slovakia", Game = "Youth Olympic Games", Sport = "Skateboarding", Category = "Outdoor", CountryCode = "sk" },
                new OlympicSport { Id = 24, Name = "Portugal", Game = "Youth Olympic Games", Sport = "Skateboarding", Category = "Outdoor", CountryCode = "pt" }
            );
        }
    }
}
