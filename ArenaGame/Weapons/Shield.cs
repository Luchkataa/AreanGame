using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArenaGame.Weapons
{
    public class Shield : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Shield(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 30;
        }

        public bool Stun()
        {
            if (Random.Shared.Next(0, 100) < 15)
            {
                return true;
            }
            return false;
        }

    }
}
