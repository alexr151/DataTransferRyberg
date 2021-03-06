// <auto-generated />
using DataTransferRyberg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataTransferRyberg.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataTransferRyberg.Models.Country", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryId");

                    b.HasIndex("GameId");

                    b.HasIndex("SportId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = "CAN",
                            GameId = "wo",
                            LogoImage = "can.png",
                            Name = "Canada",
                            SportId = "curl"
                        },
                        new
                        {
                            CountryId = "SWE",
                            GameId = "wo",
                            LogoImage = "swe.png",
                            Name = "Sweden",
                            SportId = "curl"
                        },
                        new
                        {
                            CountryId = "GB",
                            GameId = "wo",
                            LogoImage = "gb.png",
                            Name = "Great Britain",
                            SportId = "curl"
                        },
                        new
                        {
                            CountryId = "JAM",
                            GameId = "wo",
                            LogoImage = "jam.png",
                            Name = "Jamaica",
                            SportId = "bob"
                        },
                        new
                        {
                            CountryId = "ITL",
                            GameId = "wo",
                            LogoImage = "itl.png",
                            Name = "Italy",
                            SportId = "bob"
                        },
                        new
                        {
                            CountryId = "JAP",
                            GameId = "wo",
                            LogoImage = "jap.png",
                            Name = "Japan",
                            SportId = "bob"
                        },
                        new
                        {
                            CountryId = "GER",
                            GameId = "so",
                            LogoImage = "ger.png",
                            Name = "Germany",
                            SportId = "div"
                        },
                        new
                        {
                            CountryId = "CHI",
                            GameId = "so",
                            LogoImage = "chi.png",
                            Name = "China",
                            SportId = "div"
                        },
                        new
                        {
                            CountryId = "MEX",
                            GameId = "so",
                            LogoImage = "mex.png",
                            Name = "Mexico",
                            SportId = "div"
                        },
                        new
                        {
                            CountryId = "BRZ",
                            GameId = "so",
                            LogoImage = "brz.png",
                            Name = "Brazil",
                            SportId = "cycl"
                        },
                        new
                        {
                            CountryId = "NET",
                            GameId = "so",
                            LogoImage = "net.png",
                            Name = "Netherlands",
                            SportId = "cycl"
                        },
                        new
                        {
                            CountryId = "USA",
                            GameId = "so",
                            LogoImage = "usa.png",
                            Name = "United States of America",
                            SportId = "cycl"
                        },
                        new
                        {
                            CountryId = "THA",
                            GameId = "po",
                            LogoImage = "tha.png",
                            Name = "Thailand",
                            SportId = "arch"
                        },
                        new
                        {
                            CountryId = "URA",
                            GameId = "po",
                            LogoImage = "ura.png",
                            Name = "Uruguay",
                            SportId = "arch"
                        },
                        new
                        {
                            CountryId = "UKR",
                            GameId = "po",
                            LogoImage = "ukr.png",
                            Name = "Ukraine",
                            SportId = "arch"
                        },
                        new
                        {
                            CountryId = "AUS",
                            GameId = "po",
                            LogoImage = "aus.png",
                            Name = "Austria",
                            SportId = "cs"
                        },
                        new
                        {
                            CountryId = "pak",
                            GameId = "po",
                            LogoImage = "pak.png",
                            Name = "Pakistan",
                            SportId = "cs"
                        },
                        new
                        {
                            CountryId = "zim",
                            GameId = "po",
                            LogoImage = "zim.png",
                            Name = "Zimbabwe",
                            SportId = "cs"
                        },
                        new
                        {
                            CountryId = "fran",
                            GameId = "yo",
                            LogoImage = "fran.png",
                            Name = "France",
                            SportId = "break"
                        },
                        new
                        {
                            CountryId = "cyp",
                            GameId = "yo",
                            LogoImage = "cyp.png",
                            Name = "Cyprus",
                            SportId = "break"
                        },
                        new
                        {
                            CountryId = "rus",
                            GameId = "yo",
                            LogoImage = "rus.png",
                            Name = "Russia",
                            SportId = "break"
                        },
                        new
                        {
                            CountryId = "fin",
                            GameId = "yo",
                            LogoImage = "fin.png",
                            Name = "Finland",
                            SportId = "skate"
                        },
                        new
                        {
                            CountryId = "slov",
                            GameId = "yo",
                            LogoImage = "slov.png",
                            Name = "Slovakia",
                            SportId = "skate"
                        },
                        new
                        {
                            CountryId = "port",
                            GameId = "yo",
                            LogoImage = "port.png",
                            Name = "Portugal",
                            SportId = "skate"
                        });
                });

            modelBuilder.Entity("DataTransferRyberg.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = "wo",
                            Name = "Winter Olympic Games"
                        },
                        new
                        {
                            GameId = "so",
                            Name = "Summer Olympic Games"
                        },
                        new
                        {
                            GameId = "po",
                            Name = "Paralympic Games"
                        },
                        new
                        {
                            GameId = "yo",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("DataTransferRyberg.Models.Sport", b =>
                {
                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = "curl",
                            Name = "Curling",
                            Type = "Indoor"
                        },
                        new
                        {
                            SportId = "bob",
                            Name = "Bobsleigh",
                            Type = "Outdoor"
                        },
                        new
                        {
                            SportId = "div",
                            Name = "Diving",
                            Type = "Indoor"
                        },
                        new
                        {
                            SportId = "cycl",
                            Name = "Road Cycling",
                            Type = "Outdoor"
                        },
                        new
                        {
                            SportId = "arch",
                            Name = "Archery",
                            Type = "Indoor"
                        },
                        new
                        {
                            SportId = "cs",
                            Name = "Canoe Sprint",
                            Type = "Outdoor"
                        },
                        new
                        {
                            SportId = "break",
                            Name = "Breakdancing",
                            Type = "Indoor"
                        },
                        new
                        {
                            SportId = "skate",
                            Name = "Skateboarding",
                            Type = "Outdoor"
                        });
                });

            modelBuilder.Entity("DataTransferRyberg.Models.Country", b =>
                {
                    b.HasOne("DataTransferRyberg.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("DataTransferRyberg.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
