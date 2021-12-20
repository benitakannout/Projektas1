using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class AircraftModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }

        public AircraftModel()
        {

        }

        public AircraftModel(int Id, string Number, string Description)
        {
            Id = Id;
            Number = Number;
            Description = Description;
        }

    }
}
