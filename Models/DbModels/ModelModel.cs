using System;

namespace calculator40k.DbModels
{
    public class DbModel
    {
        public int ID {get;set;}
        public int UnitID {get;set;}
        public string? Name { get; set; }
        public int Toughness { get; set; }
        public int Wounds { get; set; }
        public int Save { get; set; }
        public int InvSave { get; set; }
        public int RangedWeaponId {get;set;}
        public int MeleeWeaponId {get;set;}

    }
}