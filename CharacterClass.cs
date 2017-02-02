using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerEq
{

    public class CharacterClass
    {
        //public int ID { get; set; }

        public string Description { get; set; }

        public double Strength { get; set; }

        public double Defence { get; set; }

        public int Magic { get; set; }

        public double Capacity { get; set; }

        public CharacterClass() { }

        public CharacterClass(string description, double strength, double defence, int magic, double capacity)
        {
            //this.ID = id;
            this.Description = description;
            this.Strength = strength;
            this.Defence = defence;
            this.Magic = magic;
            this.Capacity = capacity;
        }

        //metoda zwiekszajaca sile, obrone i udzwig w zaleznosci od poziomu
        public virtual void GiveBonus(double lvl)
        {
            Strength += (lvl);
            Defence += (lvl);
            Capacity += (lvl);
        }
    }

}
