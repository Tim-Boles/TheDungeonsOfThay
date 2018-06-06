using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class AttackModule
    {
        Random Dice;

        public float _DamageMod;
        public float _DamageStat;
        public float _HitChance;
        string ActorID { get; set; }

        public AttackModule(float dmgMod, float dmgStat)
        {
             _DamageMod = dmgMod;
             _DamageStat = dmgStat;

            Dice = new Random();

            _HitChance = dmgStat / 10;

        }
     

        public float ATKPowerCalc()
        {   
           

            return _DamageMod + _DamageStat;

        }

        public float ChanceToHitCalc()
        {
          return _HitChance + Dice.Next(1, 21);
            
        }

    }
}
