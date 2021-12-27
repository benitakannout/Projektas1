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

        
        public List<ReportItem> GenerateReportAircraftInEurope(AircraftsRepository aircraftsRepository, CountriesRepository countriesRepository)
        {
            var aircrafts = aircraftsRepository.Retrieve();
            var items = new List<ReportItem>();

            foreach (var aircraft in aircrafts)
            {
                
                var company = _companiesRepository.Retrieve(aircraft.CompanyId);
                var country = _countriesRepository.Retrieve(company.CountryId);
                var aircraftModel = _aircraftModelsRepository.Retrieve(aircraft.ModelId);             

                if(country.Continent == "Europe")
                {
                    var item = new ReportItem();
                    item.AircraftTailNumber = aircraft.TailNumber;
                    item.ModelNumber = aircraftModel.Number;
                    item.ModelDescription = aircraftModel.Description;
                    item.OwnerCompanyName = company.Name;
                    item.CompanyCountryCode = company.CountryId;
                    item.CompanyCountryName = country.Name;
                    item.BelongsToEU = country.BelongsToEU;
                    item.ContinentIsEurope = true;
                    items.Add(item);
                }
                else if(country.Continent != "Europe")
                {
                    var item = new ReportItem();
                    item.AircraftTailNumber = aircraft.TailNumber;
                    item.ModelNumber = aircraftModel.Number;
                    item.ModelDescription = aircraftModel.Description;
                    item.OwnerCompanyName = company.Name;
                    item.CompanyCountryCode = company.CountryId;
                    item.CompanyCountryName = country.Name;
                    item.BelongsToEU = country.BelongsToEU;
                    item.ContinentIsEurope = false;
                    items.Add(item);
                }

            }

            return items;
        }

    }
}
