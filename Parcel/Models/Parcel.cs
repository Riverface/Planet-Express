using System.Collections.Generic;
using System.Numerics;
namespace ShippingCompany.Models
{
    public class Parcel
    {

        public List<Item> ItemList { get; set; }
        public string Name { get; set; } = "";
        public float Weight { get; set; } = 0;
        public string Description { get; set; } = "";
        public string BoxDescription { get; set; } = "";
        public float BoxWeight;
        public Vector3 Dimensions = new Vector3();
        public float Volume = 0;
        public float PriceToShip;
        public static List<Parcel> _instances = new List<Parcel>();

        public Parcel(string name, string description, Vector3 dimensions)
        {
            Name = name;
            BoxDescription = description;
            ItemList = new List<Item> { };
            Dimensions = dimensions;
            Volume = 0;
            Weight = BoxWeight;
            PriceToShip = 0;
            _instances.Add(this);
        }
        public Parcel()
        {

        }

        public static List<Parcel> GetAll()
        {
            return _instances;
        }

        public void Calculate_Volume()
        {
            Volume = (Dimensions.X * Dimensions.Y * Dimensions.Z);
        }
        public void Concat_Description()
        {
            Description = BoxDescription;
            if (ItemList.Count > 0)
            {
                Description += " containing " + ItemList.Count + " Item";
                if (ItemList.Count > 1)
                {
                    Description += "s.";
                }
                else
                {
                    Description += ".";
                }
            }

            foreach (Item item in ItemList)
            {
                if (ItemList.Count >= 0)
                {
                    Description += item.Description;
                    if (ItemList.Count > 1)
                    {
                        Description += ", ";
                    }
                }
                else
                {
                    Description += " It is empty.";
                }
            }
        }
        public void Calculate_Weight()
        {
            Weight = BoxWeight;
            for (int Item_Iterator = 0; Item_Iterator < ItemList.Count; Item_Iterator++)
            {
                Weight += ItemList[Item_Iterator].Weight;
            }
        }
        public void Calculate_Price()
        {
            PriceToShip = Weight * Volume;
        }
    }
}