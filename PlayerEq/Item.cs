using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerEq
{

    public class Item
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public double Bonus { get; set; }

        public string Properties { get; set; }

        public double Weight { get; set; }

        public Item() { }

        public Item(int id, string name, string type, string requirements, double bonus,
            string properties, double weight, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Requirements = requirements;
            this.Bonus = bonus;
            this.Properties = properties;
            this.Weight = weight;
        }
    }

}
