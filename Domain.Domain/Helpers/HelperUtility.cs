using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Helpers
{
    public static class HelperUtility
    {
        /// <summary>
        /// Ricardo Martinez.
        /// Helper for know de monthn diferences between
        /// two dates
        /// </summary>
        /// <param name="FechaFin"></param>
        /// <param name="FechaInicio"></param>
        /// <returns></returns>
        public static decimal MonthDifference(DateTime FechaFin, DateTime FechaInicio)
        {
            return Math.Abs((FechaFin.Month - FechaInicio.Month) + 12 * (FechaFin.Year - FechaInicio.Year));
        }
    }
}
