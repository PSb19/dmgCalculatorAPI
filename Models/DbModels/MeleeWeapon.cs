using System;

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
    }
}