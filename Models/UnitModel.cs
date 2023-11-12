using System;

namespace calculator40k.Models
{
    public class Unit
    {
        public string? Name {get; set;}
        public int Cost {get; set;}
        public int ModelCount {get; set;}
        public bool IsInfantry {get; set;}
        public bool IsCharacter {get; set;}
        public bool IsVehicle {get; set;}
        // Models List
        public Model? ModelCharacteristics {get; set;}
    }
}