using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Hammer : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Hammer(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 0;
        }

        public double SmashAttack(double baseDamage)
        {
            return baseDamage * 1.75;
        }
    }
}
