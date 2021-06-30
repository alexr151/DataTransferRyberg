using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferRyberg.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public object Game { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = "wo",
                    Name = "Winter Olympic Games"
                }
                ,
                new Game
                {
                    GameId = "so",
                    Name = "Summer Olympic Games"
                },
                new Game
                {
                    GameId = "po",
                    Name = "Paralympic Games"
                },
                new Game
                {
                    GameId = "yo",
                    Name = "Youth Olympic Games"
                });

            modelBuilder.Entity<Sport>().HasData(
                new Sport
                {
                    SportId = "curl",
                    Name = "Curling",
                    Type = "Indoor"
                },
                new Sport
                {
                    SportId = "bob",
                    Name = "Bobsleigh",
                    Type = "Outdoor"
                },
                new Sport
                {
                    SportId = "div",
                    Name = "Diving",
                    Type = "Indoor"
                },
                new Sport
                {
                    SportId = "cycl",
                    Name = "Road Cycling",
                    Type = "Outdoor"
                },
                new Sport
                {
                    SportId = "arch",
                    Name = "Archery",
                    Type = "Indoor"
                },
                new Sport
                {
                    SportId = "cs",
                    Name = "Canoe Sprint",
                    Type = "Outdoor"
                },
                new Sport
                {
                    SportId = "break",
                    Name = "Breakdancing",
                    Type = "Indoor"
                },
                new Sport
                {
                    SportId = "skate",
                    Name = "Skateboarding",
                    Type = "Outdoor"
                }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = "CAN",
                    Name = "Canada",
                    GameId = "wo",
                    SportId = "curl",
                    LogoImage = "can.png"
                },
                new Country
                {
                    CountryId = "SWE",
                    Name = "Sweden",
                    GameId = "wo",
                    SportId = "curl",
                    LogoImage = "swe.png"
                },
                new Country
                {
                    CountryId = "GB",
                    Name = "Great Britain",
                    GameId = "wo",
                    SportId = "curl",
                    LogoImage = "gb.png"
                },
                new Country
                {
                    CountryId = "JAM",
                    Name = "Jamaica",
                    GameId = "wo",
                    SportId = "bob",
                    LogoImage = "jam.png"
                },
                new Country
                {
                    CountryId = "ITL",
                    Name = "Italy",
                    GameId = "wo",
                    SportId = "bob",
                    LogoImage = "itl.png"
                },
                new Country
                {
                    CountryId = "JAP",
                    Name = "Japan",
                    GameId = "wo",
                    SportId = "bob",
                    LogoImage = "jap.png"
                },
                new Country
                {
                    CountryId = "GER",
                    Name = "Germany",
                    GameId = "so",
                    SportId = "div",
                    LogoImage = "ger.png"
                },
                new Country
                {
                    CountryId = "CHI",
                    Name = "China",
                    GameId = "so",
                    SportId = "div",
                    LogoImage = "chi.png"
                },
                new Country
                {
                    CountryId = "MEX",
                    Name = "Mexico",
                    GameId = "so",
                    SportId = "div",
                    LogoImage = "mex.png"
                },
                new Country
                {
                    CountryId = "BRZ",
                    Name = "Brazil",
                    GameId = "so",
                    SportId = "cycl",
                    LogoImage = "brz.png"
                },
                new Country
                {
                    CountryId = "NET",
                    Name = "Netherlands",
                    GameId = "so",
                    SportId = "cycl",
                    LogoImage = "net.png"
                },
                new Country
                {
                    CountryId = "USA",
                    Name = "United States of America",
                    GameId = "so",
                    SportId = "cycl",
                    LogoImage = "usa.png"
                },
                new Country
                {
                    CountryId = "THA",
                    Name = "Thailand",
                    GameId = "po",
                    SportId = "arch",
                    LogoImage = "tha.png"
                },
                new Country
                {
                    CountryId = "URA",
                    Name = "Uruguay",
                    GameId = "po",
                    SportId = "arch",
                    LogoImage = "ura.png"
                },
                new Country
                {
                    CountryId = "UKR",
                    Name = "Ukraine",
                    GameId = "po",
                    SportId = "arch",
                    LogoImage = "ukr.png"
                },
                new Country
                {
                    CountryId = "AUS",
                    Name = "Austria",
                    GameId = "po",
                    SportId = "cs",
                    LogoImage = "aus.png"
                },
                new Country { CountryId = "pak", Name = "Pakistan", GameId = "po", SportId = "cs", LogoImage = "pak.png" },
                new Country { CountryId = "zim", Name = "Zimbabwe", GameId = "po", SportId = "cs", LogoImage = "zim.png" },
                new Country { CountryId = "fran", Name = "France", GameId = "yo", SportId = "break", LogoImage = "fran.png" },
                new Country { CountryId = "cyp", Name = "Cyprus", GameId = "yo", SportId = "break", LogoImage = "cyp.png" },
                new Country { CountryId = "rus", Name = "Russia", GameId = "yo", SportId = "break", LogoImage = "rus.png" },
                new Country { CountryId = "fin", Name = "Finland", GameId = "yo", SportId = "skate", LogoImage = "fin.png" },
                new Country { CountryId = "slov", Name = "Slovakia", GameId = "yo", SportId = "skate", LogoImage = "slov.png" },
                new Country { CountryId = "port", Name = "Portugal", GameId = "yo", SportId = "skate", LogoImage = "port.png" }
                ) ;
            

        }


    }
}
