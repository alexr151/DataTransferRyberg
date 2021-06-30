using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferRyberg.Models
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string GameId { get; set; }
        public Game Game { get; set; }
        public string SportId { get; set; }
        public Sport Sport { get; set; }
        
        public string LogoImage { get; set; }
    }
}
