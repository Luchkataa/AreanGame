using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        public Wizard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
                 
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if(Weapon is MagicStaff staff)
            {
                damage = staff.Poison();
            }

            if (Random.Shared.Next(0, 100) < 25)
            {
                damage *= 4;
                return damage;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            if (Random.Shared.Next(0, 100) < 5)
            {
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
