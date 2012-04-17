using System;
using System.Collections.Generic;

namespace Web.Mobile.Models
{
    public class SponsorshipOverview
    {
        public List<SponsoredDeveloper> SponsoredDevelopers { get; set; }

        public SponsoredDeveloper SelectedDeveloper { get; set; }
    }

    public class SponsoredDeveloper
    {
        public string DeveloperName { get; set; }

        public string Bio { get; set; }

        public string ImageUrl { get; set; }

        public Location DeveloperLocation { get; set; }
    }

    public class Location
    {
        public string City { get; set; }

        public string Country { get; set; }
    }
}