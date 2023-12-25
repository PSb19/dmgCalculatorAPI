using System;
using calculator40k.Models;

namespace calculator40k.DbModels
{
    public class DbMeleeWeapon
    {
        public int ID { get; set; }
        public int Attacks { get; set; }
        public int WeaponSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public string? Damage { get; set; }
        public bool HasLethalHits {get; set;}
        public bool HasSustainedHits {get; set;}
        public string? SustainedHitsValue {get; set;}
        public bool HasDevWounds {get; set;}
        public bool HasLance {get; set;}
        public DbMeleeWeapon(){}
        public DbMeleeWeapon(MeleeWeapon meleeWeapon){
            Attacks = meleeWeapon.Attacks;
            WeaponSkill = meleeWeapon.WeaponSkill;
            Strength = meleeWeapon.Strength;
            ArmorPiercing = meleeWeapon.ArmorPiercing;
            Damage = meleeWeapon.Damage != null ? meleeWeapon.Damage.ToString() : "0";
            HasLethalHits = meleeWeapon.Traits.HasLethalHits;
            HasSustainedHits = meleeWeapon.Traits.HasSustainedHits;
            SustainedHitsValue = meleeWeapon.Traits.SustainedHitsValue != null ? meleeWeapon.Traits.SustainedHitsValue.ToString() : "0";
            HasDevWounds = meleeWeapon.Traits.HasDevWounds;
            HasLance = meleeWeapon.Traits.HasLance;
        }
    }
}