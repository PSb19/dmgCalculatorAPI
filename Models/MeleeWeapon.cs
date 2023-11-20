using System;

namespace calculator40k.Models
{
    public class MeleeWeapon
    {
        public int Attacks { get; set; }
        public int WeaponSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public string? Damage { get; set; }
        public WeaponTraits Traits {get; set;} = new WeaponTraits();
    }
}