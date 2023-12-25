namespace calculator40k.Models
{
    public class RangedWeaponTraits : WeaponTraits
    {
        public bool HasTorrent {get; set;} = false;
        public bool HasRapidFire {get; set;} = false;
        public int RapidFireValue {get; set;} = 0;

        public RangedWeaponTraits(){}
        public RangedWeaponTraits(bool HasLethalHits, bool HasSustainedHits, string? SustainedHitsValue, bool HasDevWounds, 
        bool _HasTorrent, bool _HasRapidFire, int _RapidFireValue) : base(HasLethalHits, HasSustainedHits, SustainedHitsValue, HasDevWounds){
            HasTorrent = _HasTorrent;
            HasRapidFire = _HasRapidFire;
            RapidFireValue = _RapidFireValue;
        }
    }
}