namespace calculator40k.Models
{
    public class WeaponTraits
    {
        public bool HasLethalHits {get; set;} = false;
        public bool HasSustainedHits {get; set;} = false;
        public string? SustainedHitsValue {get; set;} = null;
        public bool HasTorrent {get; set;} = false;
        public bool HasRapidFire {get; set;} = false;
        public bool HasDevWounds {get; set;} = false;
        public bool HasLance {get; set;} = false;

    }
}