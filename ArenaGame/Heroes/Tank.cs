using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Tank : Hero
    {
        public int shieldAmount;
        public Tank(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            shieldAmount = 0;
        }

        public override double Attack()
        {
            double baseDamage = base.Attack();

            if (shieldAmount > 0)
            {
                baseDamage += shieldAmount * 0.1;
                shieldAmount = 0;
            }

            if (Weapon is Shield shield && shield.Stun())
            {
                
                return baseDamage * 2; 
            }

            return baseDamage;
        }

        public override double Defend(double damage)
        {
            if(Random.Shared.Next(0, 100) < 30)
            {
                return 0;
            }
            else
            {
                if (shieldAmount > 0)
                {
                    base.Defend(damage - shieldAmount);
                }
                else if (Random.Shared.Next(0, 100) < 50)
                {
                    shieldAmount += 15;
                }
            }
            return base.Defend(damage);
        }
    }
}
