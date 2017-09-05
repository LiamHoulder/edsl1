using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_AdminWPF
{
    public struct Date
    {
        int day;
        int month;
        int year;
    }

    public struct Season
    {
        public DateTime StartDate;
        public DateTime[] Holidays;
        public int Length;
    }

    public static class DataBase
    {
        public static List<Season> Seasons = new List<Season>();

        public static void AddSeason(DateTime start, DateTime[] holidays, int length)
        {
            Season toAdd = new Season();
            toAdd.Length = length;
            toAdd.StartDate = start;
            toAdd.Holidays = holidays;
            Seasons.Add(toAdd);
        }
    }
}
