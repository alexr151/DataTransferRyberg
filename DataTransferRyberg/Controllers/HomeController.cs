using DataTransferRyberg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            var model = new CountryListViewModel
            {
                Country = context.Countries.Include(c => c.Game).Include(c => c.Sport).FirstOrDefault(c => c.CountryId == id),
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all",
                ActiveSport = TempData?["ActiveSport"]?.ToString() ?? "all"
            };

            return View(model);
        }
    }
}
