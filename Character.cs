using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerEq
{

    public class Character : CharacterClass
    {
        //public int _ID { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public Character() { }

        public string ClassOption { get; set; }

        public Character(string name, int level, double strength, double defence, int magic,
            double capacity, string ClassOption, string description) : base(description, strength, defence, magic, capacity)
        {
            this.Name = name;
            this.Level = level;
            this.ClassOption = ClassOption;
        }

        public override void GiveBonus(double lvl)
        {
            base.GiveBonus(lvl);
        }
    }

}
