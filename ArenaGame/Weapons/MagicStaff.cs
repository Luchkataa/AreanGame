using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicStaff : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public int hitCount { get; private set; }

        public MagicStaff(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 0;
            hitCount = 0;
        }

        public double Poison()
        {
            if(hitCount < 3)
            {
                hitCount++;
                return AttackDamage += 5;
            }
            return AttackDamage;
        }
    }
}
