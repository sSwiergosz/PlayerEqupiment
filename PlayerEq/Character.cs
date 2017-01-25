using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerEq
{

    public class Character : CharacterClass
    {
        public int _ID { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public Character() { }

        public Character(int id, string name, int level, int strength, int defence, int magic,
            double capacity, string ClassOption, string description) : base(id, description, strength, defence, magic, capacity)
        {
            this.Name = name;
            this.Level = level;
            this.ClassOption = ClassOption;
        }
        private string ClassOption { get; set; }
    }

}
