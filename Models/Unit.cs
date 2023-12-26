using System;
using calculator40k.DbModels;

namespace calculator40k.Models
{
    public class Unit
    {
        public int ID {get; set;}
        public string? Name {get; set;}
        public int Cost {get; set;}
        public int ModelCount {get; set;}
        public bool IsInfantry {get; set;}
        public bool IsCharacter {get; set;}
        public bool IsVehicle {get; set;}
        public bool IsPsyker {get; set;}
        // Models List
        public Model? Model {get; set;}

        public Unit(){}

        public Unit(DbUnit dbUnit, DbModel dbModel, RangedWeapon rw, MeleeWeapon mw){
            ID = dbUnit.ID;
            Name = dbUnit.Name;
            Cost = dbUnit.Cost;
            ModelCount = dbUnit.ModelCount;
            IsInfantry = dbUnit.IsInfantry;
            IsCharacter = dbUnit.IsCharacter;
            IsVehicle = dbUnit.IsVehicle;
            IsPsyker = dbUnit.IsPsyker;
            //improve
            Model = new(dbModel, rw, mw);
        }
    }
}