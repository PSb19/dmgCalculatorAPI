using System;

namespace calculator40k.DbModels
{
    public class DbUnit
    {
        public int ID {get; set;}
        public string? Name {get; set;}
        public int Cost {get; set;}
        public int ModelCount {get; set;}
        public bool IsInfantry {get; set;}
        public bool IsCharacter {get; set;}
        public bool IsVehicle {get; set;}
        // Models List
        //For now, unit is intended to have just one model, but is binded form model.
    }
}