using System;

namespace calculator40k.Models
{
    public class RangedWeapon
    {
        public int Range { get; set; }
        public ComplexValue? Attacks { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public ComplexValue? Damage { get; set; }
        public WeaponTraits Traits {get; set;} = new WeaponTraits();
    }
}