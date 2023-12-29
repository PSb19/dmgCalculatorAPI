using System;
using calculator40k.DbModels;

namespace calculator40k.Models
{
    public class Model
    {
        public string? Name { get; set; }
        public int Toughness { get; set; }
        public int Wounds { get; set; }
        public int Save { get; set; }
        public int InvSave { get; set; }

        // Ranged weapon
        public RangedWeapon? RangedWeapon {get; set;}
        // Melee weapon
        public MeleeWeapon? MeleeWeapon {get; set;}

        public Model(){}
        public Model(DbModel dbModel){
            Name = dbModel.Name;
            Toughness = dbModel.Toughness;
            Wounds = dbModel.Wounds;
            Save = dbModel.Save;
            InvSave = dbModel.InvSave;
            RangedWeapon = null;
            MeleeWeapon = null;
        }
        public Model(DbModel dbModel, RangedWeapon? rangedWeapon = null, MeleeWeapon? meleeWeapon = null){
            Name = dbModel.Name;
            Toughness = dbModel.Toughness;
            Wounds = dbModel.Wounds;
            Save = dbModel.Save;
            InvSave = dbModel.InvSave;
            RangedWeapon = rangedWeapon;
            MeleeWeapon = meleeWeapon;
        }
        public Model(DbModel dbModel, DbRangedWeapon rangedWeapon, DbMeleeWeapon meleeWeapon){
            Name = dbModel.Name;
            Toughness = dbModel.Toughness;
            Wounds = dbModel.Wounds;
            Save = dbModel.Save;
            InvSave = dbModel.InvSave;
            RangedWeapon = new RangedWeapon(rangedWeapon);
            MeleeWeapon = new MeleeWeapon(meleeWeapon);
        }
    }
}