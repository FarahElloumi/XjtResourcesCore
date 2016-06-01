using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace XJTResourcesCore.Models
{
    public class Hotel : BaseClass
    {
        public Hotel() {

            Comments = new List<Comment>();
            Corrections = new List<Correction>();
        }

        public int HotelId { get; set; }

        [Display(Name="Address")]
        public string Address
        {
            get;
            set;
        }

        [Display(Name="1-2-3 Rule")]
        public bool Amenities123
        {
            get;
            set;
        }

        [Display(Name = "2-3-4 Rule")]
        public bool Amenities234
        {
            get;
            set;
        }

        [Display(Name = "ATM")]
        public bool AmenitiesA
        {
            get;
            set;
        }

        [Display(Name = "Breakfest - Complimentary")]
        public bool AmenitiesBC
        {
            get;
            set;
        }

        [Display(Name = "Breakfest - Grab 'N Go")]
        public bool AmenitiesBG
        {
            get;
            set;
        }

        [Display(Name = "Crew Room")]
        public bool AmenitiesCR
        {
            get;
            set;
        }


        [Display(Name = "Discount Rate")]
        public bool AmenitiesDR
        {
            get;
            set;
        }

        [Display(Name = "Expedited Check-In")]
        public bool AmenitiesECI
        {
            get;
            set;
        }

        [Display(Name = "Food Discount")]
        public bool AmenitiesFD
        {
            get;
            set;
        }

        [Display(Name = "On-Site Gym")]
        public bool AmenitiesG
        {
            get;
            set;
        }

        [Display(Name = "Off-Site Gym")]
        public bool AmenitiesGO
        {
            get;
            set;
        }

        [Display(Name = "Gift Shop")]
        public bool AmenitiesGS
        {
            get;
            set;
        }

        [Display(Name = "Indoor Pool")]
        public bool AmenitiesID
        {
            get;
            set;
        }

        [Display(Name = "Laundry Facilities")]
        public bool AmenitiesLF
        {
            get;
            set;
        }


        [Display(Name = "Microwave")]
        public bool AmenitiesMW
        {
            get;
            set;
        }

        [Display(Name = "News Stand")]
        public bool AmenitiesNS
        {
            get;
            set;
        }

        [Display(Name = "Out Door Pool")]
        public bool AmenitiesOP
        {
            get;
            set;
        }

        [Display(Name = "Refrigerator")]
        public bool AmenitiesRF
        {
            get;
            set;
        }

        [Display(Name = "Reward Points")]
        public bool AmenitiesRP
        {
            get;
            set;
        }

        [Display(Name = "100% Smoke Free")]
        public bool AmenitiesSF
        {
            get;
            set;
        }

        [Display(Name = "TV Flat Screen")]
        public bool AmenitiesTVF
        {
            get;
            set;
        }

        [Display(Name = "TV Limited Channels")]
        public bool AmenitiesTVL
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        [Display(Name = "ICAO")]
        public string CityXXX
        {
            get;
            set;
        }

        
        public string Discounts
        {
            get;
            set;
        }


        [Display(Name = "Business Center - Free?")]
        public bool InternetBCF
        {
            get;
            set;
        }

        [Display(Name = "Wired Internet - Free?")]
        public bool InternetHWF
        {
            get;
            set;
        }

        [Display(Name = "Internet Notes:")]
        public string InternetNotes
        {
            get;
            set;
        }

        [Display(Name = "Wireless Internet - Free?")]
        public bool internetWF
        {
            get;
            set;
        }

        [Display(Name="Hotel Name")]
        public string Name
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }

        [Display(Name = "Overnight Length")]
        public string OvernightLongShort
        {
            get;
            set;
        }


        [Display(Name = "Phone #")]
        public string PhoneNumber
        {
            get;
            set;
        }

        


        public string State
        {
            get;
            set;
        }

        public string Transportation
        {
            get;
            set;
        }

        [Display(Name = "Zip Code")]
        public string ZipCode
        {
            get;
            set;
        }

        public virtual ICollection<Comment> Comments { get; set; }

        [Display(AutoGenerateField = false)]
        public virtual ICollection<Correction> Corrections
        {
            get;
            set;
        }
    }
}