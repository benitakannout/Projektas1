using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class ReportItem
    {
        public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public int? CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public bool? BelongsToEU { get; set; }
        public bool ContinentIsEurope { get; set; }

        private List<ReportItem> items = new List<ReportItem>();

    }
}
