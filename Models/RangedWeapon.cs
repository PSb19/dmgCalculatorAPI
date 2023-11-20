using System;

namespace calculator40k.Models
{
    public class RangedWeapon
    {
        public int Range { get; set; }
        public string? Attacks { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public string? Damage { get; set; }
        public WeaponTraits Traits {get; set;} = new WeaponTraits();
    }
}