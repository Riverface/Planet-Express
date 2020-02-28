using System.Collections.Generic;
using System.Numerics;
namespace ShippingCompany.Models
{
    public class Parcel
    {
        public string Name { get; set; } 
        public float Weight { get; set; }
        public string Description { get; set; }
        public string BoxDescription { get; set; }
        public float BoxWeight;
        public Vector3 Dimensions = new Vector3();

        public static List<Parcel> _instances = new List<Parcel>();
        public int ID;
        public static int selectedID;
        public Parcel(string name, string description, Vector3 dimensions, float weight)
        {
           Name = name;
           BoxDescription = description;
           Dimensions = dimensions;
           Weight = weight;
           _instances.Add(this);
           ID = _instances.Count;
        }

        public static List<Parcel> GetAll()
        {
            return _instances;
        }

        public float Volume()
        {
            return(Dimensions.X * Dimensions.Y * Dimensions.Z);
        }

        public float PriceToShip()
        {
            return Weight * Volume();
        }
    }
}