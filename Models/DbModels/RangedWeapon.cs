using System;
using calculator40k.Models;

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
        public int RapidFireValue {get; set;}
        public bool HasDevWounds {get; set;}
        public DbRangedWeapon(){}
        public DbRangedWeapon(RangedWeapon rangedWeapon){
            Attacks = rangedWeapon.Attacks != null ? rangedWeapon.Attacks.ToString() : "0";
            BallisticSkill = rangedWeapon.BallisticSkill;
            Strength = rangedWeapon.Strength;
            ArmorPiercing = rangedWeapon.ArmorPiercing;
            Damage = rangedWeapon.Damage != null ? rangedWeapon.Damage.ToString() : "0";
            HasLethalHits = rangedWeapon.Traits.HasLethalHits;
            HasSustainedHits = rangedWeapon.Traits.HasSustainedHits;
            SustainedHitsValue = rangedWeapon.Traits.SustainedHitsValue != null ? rangedWeapon.Traits.SustainedHitsValue.ToString() : "0";
            HasDevWounds = rangedWeapon.Traits.HasDevWounds;
            HasTorrent = rangedWeapon.Traits.HasTorrent;
            HasRapidFire = rangedWeapon.Traits.HasRapidFire;
            RapidFireValue = rangedWeapon.Traits.RapidFireValue;
        }
    }
}