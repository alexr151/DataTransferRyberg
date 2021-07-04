using DataTransferRyberg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DataTransferRyberg.Controllers
{
    public class HomeController : Controller
    {

        private CountryContext context;

     

        public HomeController (CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGame = "all", string activeSport = "all")
        {
            var session = new FlagSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveSport(activeSport);

            //if no count in session, get cookie and restore fave countries in session
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new FlagCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountriesIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                {
                    mycountries = context.Countries.Include(c => c.Game).Include(c => c.Sport).Where(c => ids.Contains(c.CountryId)).ToList();
                }
                session.SetMyCountries(mycountries);
            }

           var model = new CountryListViewModel
            {

            ActiveGame = activeGame,
            ActiveSport = activeSport,
            Games = context.Games.ToList(),
            Sports = context.Sports.ToList()
            };


            IQueryable<Country> query = context.Countries;

            if (activeGame != "all")
            {
                query = query.Where(
                    c => c.Game.GameId.ToLower() == activeGame.ToLower());
            }

            if (activeSport != "all")
            {
                query = query.Where(
                    c => c.Sport.SportId.ToLower() == activeSport.ToLower());
            }


            model.Countries = query.ToList();

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {            
            //Utility.LogCountryClick(model.Country.CountryId);
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSport"] = model.ActiveSport;
            return RedirectToAction("Details", new { ID = model.Country.CountryId });

        }

        [HttpGet]
        public ViewResult Details(string id)
        {
            var session = new FlagSession(HttpContext.Session);

            var model = new CountryListViewModel
            {
                Country = context.Countries.Include(c => c.Game).Include(c => c.Sport).FirstOrDefault(c => c.CountryId == id),                
                ActiveSport = session.GetActiveSport(),
                ActiveGame = session.GetActiveGame()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Sport)
                .Where(c => c.CountryId == model.Country.CountryId)
                .FirstOrDefault();

            var session = new FlagSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new FlagCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index", "Home",
               
                new { 
                    ActiveGame = session.GetActiveGame(), 
                    ActiveSport = session.GetActiveSport()
                }
              
                );

        }
    }
}
