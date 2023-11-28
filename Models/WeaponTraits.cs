namespace calculator40k.Models
{
    public class WeaponTraits
    {
        public bool HasLethalHits {get; set;} = false;
        public bool HasSustainedHits {get; set;} = false;
        public ComplexValue? SustainedHitsValue {get; set;} = null;
        public bool HasDevWounds {get; set;} = false;

        public WeaponTraits(){}
        public WeaponTraits(bool _HasLethalHits, bool _HasSustainedHits, string? _SustainedHitsValue, bool _HasDevWounds){
            HasDevWounds = _HasDevWounds;
            HasLethalHits = _HasLethalHits;
            HasSustainedHits = _HasSustainedHits;
            SustainedHitsValue = new ComplexValue(_SustainedHitsValue);
        }
    }
}