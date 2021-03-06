﻿using System;
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

        public int ID { get; }

        public Character(int id, string name, int level, double strength, double defence, int magic,
            double capacity, string classOption, string description) : base(description, strength, defence, magic, capacity)
        {
            this.ID = id;
            this.Name = name;
            this.Level = level;
            this.ClassOption = classOption;
        }

        public override void GiveBonus(double lvl)
        {
            base.GiveBonus(lvl);
        }
    }

}
