using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_AdminWPF
{
    public class Club
    {
        public string clubCode { get; set; }
        public string clubName { get; set; }
        public string contactName { get; set; }
        public string contactSurname { get; set; }
        public string Gender { get; set; }
        public string AddressLine1 { get; set; }
        public Nullable<int> Postcode { get; set; }
        public string State { get; set; }
        public string Suburb { get; set; }
        public string homePhone { get; set; }
        public Nullable<int> firstRegistered { get; set; }
    }

    public class Season
    {
        public int seasonCode { get; set; }
        public Nullable<int> seasonYear { get; set; }
        public Nullable<int> startDate { get; set; }
        public Nullable<int> numRounds { get; set; }
        public string nonPlayWeeks { get; set; }
        public Nullable<int> endDate { get; set; }
    }
}
