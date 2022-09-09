using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGFT.Helpers
{
    public static class DateHelper
    {
        public static DateTime ConvertStringToDate(string stringDate)
        {
            DateTime date = DateTime.ParseExact(stringDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            return date;
        }
    }
}
