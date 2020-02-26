using System.Collections.Generic;

namespace ShippingCompany.Models
{

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }

        public Item(string name, string description, float weight)
        {
          Name = name;
            Description = description;
            Weight = weight;
        }
        public Item(){
        Weight = 0;
        Name = "";
        Description = "";
        }

    }

}
