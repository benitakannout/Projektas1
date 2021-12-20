using Lektuvu_Projektas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class ReportGenerator
    {
        public AircraftModelsRepository _aircraftModelsRepository;
        public AircraftsRepository _aircraftsRepository;
        public CompaniesRepository _companiesRepository;
        public CountriesRepository _countriesRepository;

        public ReportGenerator(AircraftModelsRepository aircraftmodelsrepository, AircraftsRepository aircraftsRepository, CompaniesRepository companiesRepository, CountriesRepository countriesRepository)
        {
            aircraftsRepository = _aircraftsRepository;
            aircraftmodelsrepository = _aircraftModelsRepository;
            companiesRepository = _companiesRepository;
            countriesRepository = _countriesRepository;
        }



    }
}
