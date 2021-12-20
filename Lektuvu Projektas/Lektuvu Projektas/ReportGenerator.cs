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
            _aircraftsRepository = aircraftsRepository;
            _aircraftModelsRepository = aircraftmodelsrepository;
            _companiesRepository = companiesRepository;
            _countriesRepository = countriesRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope(AircraftsRepository aircraftsRepository)
        {
            var aircrafts = aircraftsRepository.Retrieve();

            foreach(var aircraft in aircrafts)
            {

            }
        }

    }
}
