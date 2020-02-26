using System.Collections.Generic;
namespace ShippingCompany.Models
{
    public class Company
    {
        public List<Parcel> ParcelList{get; set;} = new List<Parcel>{};
        public string Name{get; set;}
        public Company(string name, List<Parcel> parcelList)
        {
        Name = name;
        ParcelList = parcelList;
        }
    }
        
    }
