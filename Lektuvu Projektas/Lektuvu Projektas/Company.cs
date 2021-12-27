using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public Company()
        {

        }
        public Company(int Id, string Name, int? CountryId)
        {
            Id = Id;
            Name = Name;
            CountryId = CountryId;
        }
    }
}
