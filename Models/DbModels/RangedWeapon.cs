using System;

namespace calculator40k.DbModels
{
    public class DbRangedWeapon
    {
        public int ID { get; set; }
        public int Range { get; set; }
        public string? Attacks { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public string? Damage { get; set; }
        public bool HasLethalHits {get; set;}
        public bool HasSustainedHits {get; set;}
        public string? SustainedHitsValue {get; set;}
        public bool HasTorrent {get; set;}
        public bool HasRapidFire {get; set;}
        public bool HasDevWounds {get; set;}
    }
}