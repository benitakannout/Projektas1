using Lektuvu_Projektas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var htmlFormatter = new HTMLGenerator();

            var reportItem = new List<ReportItem>
            {
                new ReportItem
                {
                    AircraftTailNumber = "TEST",
                    ModelNumber = "TEST",
                    ModelDescription = "TEST",
                    OwnerCompanyName = "TEST",
                    CompanyCountryCode = 1,
                    CompanyCountryName = "TEST",
                    ContinentIsEurope = true,
                    BelongsToEU = true
                },
                new ReportItem
                {
                    AircraftTailNumber = "TEST2",
                    ModelNumber = "TEST2",
                    ModelDescription = "TEST2",
                    OwnerCompanyName = "TEST2",
                    CompanyCountryCode = 2,
                    CompanyCountryName = "TEST2",
                    ContinentIsEurope = true,
                    BelongsToEU = false
                },
                new ReportItem
                {
                    AircraftTailNumber = "TEST3",
                    ModelNumber = "TEST3",
                    ModelDescription = "TEST3",
                    OwnerCompanyName = "TEST3",
                    CompanyCountryCode = 3,
                    CompanyCountryName = "TEST3",
                    ContinentIsEurope = false,
                    BelongsToEU = false
                }
            };

            var result = htmlFormatter.FormatHTML(reportItem);

            Console.WriteLine(result);

            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("f618d0b1a5f4ae", "4ce72541bb31a8"),
                EnableSsl = true
            };
            client.Send("4ad65dfe63-046555@inbox.mailtrap.io", "4ad65dfe63-046555@inbox.mailtrap.io", "Hello world", result);
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
    }
}