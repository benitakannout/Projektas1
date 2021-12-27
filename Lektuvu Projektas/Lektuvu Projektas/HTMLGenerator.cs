﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektuvu_Projektas
{
    public class HTMLGenerator
    {
        private string _pageTemplate =
    @"
<html>
    <head>
        <style>
            table, th, td, {
                border: 1px solid black;
                border-collapse: collapse;
                padding: 5px;
                }
        </style>
    </head>
    <body>
     {0}
    </body>
</html>
";

        private string _tableTemplate =
@"
<table>
    <caption>{0}</caption>
    <tr>
        <th>Tail number</th>
        <th>Model number</th>
        <th>Model description</th>
        <th>Owner company name</th>
        <th>Company country code</th>
        <th>Company country name</th>
   </tr>
   {1}
</table>
";
        private string _rowTemplate =
@"
<tr style='background-color:{6}'>
    <td>{0}</td>
    <td>{1}</td>
    <td>{2}</td>
    <td>{3}</td>
    <td>{4}</td>
    <td>{5}</td>
</tr>
";
        public string FormatHTML(List<ReportItem> reportItems)
        {
            string rows = MakeTableRows(reportItems);
            string table = MakeTable(rows);
            string page = MakePage(table);

            return page;
        }

        private string MakePage(string item)
        {
            return _pageTemplate.Replace("{0}", item);
        }

        private string MakeTable(string item)
        {
            return string.Format(_tableTemplate, "Aircrafts", item);
        }

        private string MakeTableRows(List<ReportItem> reportItems)
        {
            string tableRows = string.Empty;

            foreach (var item in reportItems)
            {
                string color = GetLineColor(item);
                string tableRow = string.Format(
                    _rowTemplate,
                    item.AircraftTailNumber,
                    item.ModelNumber,
                    item.ModelDescription,
                    item.OwnerCompanyName,
                    item.CompanyCountryCode,
                    item.CompanyCountryName,
                    color);

                tableRows = tableRows + Environment.NewLine + tableRow;
            }

            return tableRows;
        }

        private string GetLineColor(ReportItem item)
        {
            if (item.BelongsToEU.HasValue && item.ContinentIsEurope == true && item.BelongsToEU == true)
            {
                return "#99ccff";
            }
            else if (item.BelongsToEU.HasValue && item.ContinentIsEurope == true && item.BelongsToEU != true)
            {
                return "#fe7254";
            }
            return "#fcf3cf";
        }
    }
}
