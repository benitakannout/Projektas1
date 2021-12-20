using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class Aircraft
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string TailNumber { get; set; }

        public Aircraft()
        {

        }

        public Aircraft(int Id, int ModelId, int CompanyId, string TailNumber)
        {
            Id = Id;
            ModelId = ModelId;
            CompanyId = CompanyId;
            TailNumber = TailNumber;
        }
    }
}
