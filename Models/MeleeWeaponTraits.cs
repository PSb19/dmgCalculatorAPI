namespace calculator40k.Models
{
    public class MeleeWeaponTraits : WeaponTraits
    {
        public bool HasLance {get; set;} = false;

        public MeleeWeaponTraits(){}
        public MeleeWeaponTraits(bool HasLethalHits, bool HasSustainedHits, string? SustainedHitsValue, bool HasDevWounds, 
        bool _HasLance) : base(HasLethalHits, HasSustainedHits, SustainedHitsValue, HasDevWounds){
            HasLance = _HasLance;
        }
    }
}