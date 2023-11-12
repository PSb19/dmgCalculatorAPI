using System;

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
        public RangedWeapon? ModelRangedWeapon {get; set;}
        // Melee weapon
        public MeleeWeapon? ModelMeleeWeapon {get; set;}
    }
}