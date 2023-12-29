using System;
using calculator40k.DbModels;

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
        public RangedWeaponTraits Traits {get; set;} = new();

        public RangedWeapon(){}
        public RangedWeapon(DbRangedWeapon db){
            Range = db.Range;
            Attacks = new(db.Attacks);
            BallisticSkill = db.BallisticSkill;
            Strength = db.Strength;
            ArmorPiercing = db.ArmorPiercing;
            Damage = new(db.Damage);
            Traits = new(db.HasLethalHits, db.HasSustainedHits, db.SustainedHitsValue, 
                        db.HasDevWounds, db.HasTorrent, db.HasRapidFire, db.RapidFireValue);
        }
    }
}