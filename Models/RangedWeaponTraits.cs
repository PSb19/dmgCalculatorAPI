namespace calculator40k.Models
{
    public class RangedWeaponTraits : WeaponTraits
    {
        public bool HasTorrent {get; set;} = false;
        public bool HasRapidFire {get; set;} = false;

        public RangedWeaponTraits(){}
        public RangedWeaponTraits(bool HasLethalHits, bool HasSustainedHits, string? SustainedHitsValue, bool HasDevWounds, 
        bool _HasTorrent, bool _HasRapidFire) : base(HasLethalHits, HasSustainedHits, SustainedHitsValue, HasDevWounds){
            HasTorrent = _HasTorrent;
            HasRapidFire = _HasRapidFire;
        }
    }
}