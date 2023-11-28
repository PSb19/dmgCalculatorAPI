using System;
using calculator40k.DbModels;

namespace calculator40k.Models
{
    public class MeleeWeapon
    {
        public int Attacks { get; set; }
        public int WeaponSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPiercing { get; set; }
        public ComplexValue? Damage { get; set; }
        public MeleeWeaponTraits Traits {get; set;} = new MeleeWeaponTraits();

        public MeleeWeapon(){}
        public MeleeWeapon(DbMeleeWeapon dbMeleeWeapon){
            Attacks = dbMeleeWeapon.Attacks;
            WeaponSkill = dbMeleeWeapon.WeaponSkill;
            Strength = dbMeleeWeapon.Strength;
            ArmorPiercing = dbMeleeWeapon.ArmorPiercing;
            Damage = new ComplexValue(dbMeleeWeapon.Damage);
            Traits = new MeleeWeaponTraits(dbMeleeWeapon.HasLethalHits, dbMeleeWeapon.HasSustainedHits, 
                                        dbMeleeWeapon.SustainedHitsValue, dbMeleeWeapon.HasDevWounds, 
                                        dbMeleeWeapon.HasLance);
        }
    }
}