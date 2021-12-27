using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool? BelongsToEU { get; set; }

        public Country()
        {

        }

        public Country(int CountryId, string Code, string Name, string Continent, bool? BelongsToEU)
        {
            CountryId = CountryId;
            Code = Code;
            Name = Name;
            Continent = Continent;
            BelongsToEU = BelongsToEU;
        }
    }
}
