using System;

namespace RazorCountry.Models
{
    public class Country
    {
        public string ID { get; set; }
        public string ContinentID { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public int? Area { get; set; }
        public DateTime? UnitedNationsDate { get; set; }
    }
}