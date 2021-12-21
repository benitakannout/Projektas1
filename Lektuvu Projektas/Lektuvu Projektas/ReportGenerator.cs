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

        List<int> item = new List<int>();
        public List<ReportItem> GenerateReportAircraftInEurope(AircraftsRepository aircraftsRepository, CountriesRepository countriesRepository)
        {
            var aircrafts = aircraftsRepository.Retrieve();

            foreach(var aircraft in aircrafts)
            {
                int Id = aircraft.Id;
                var CountryId = countriesRepository.Retrieve(Id);

                if(CountryId.BelongsToEU == true)
                {
                    item.Add(Id);
                }
                else if (CountryId.BelongsToEU == null)
                {
                    continue;
                }
            }
        }

    }
}
