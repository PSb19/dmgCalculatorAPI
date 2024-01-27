namespace calculator40k.Models
{
    public class ComplexValue
    {
        public string Value {get; set;}
        public ComplexValue(string? value = null){
            if(!string.IsNullOrEmpty(value))
                Value = value;
            else
                Value = "err";
        }
        public override string ToString(){
            return Value;
        }
        public double ToNumerical(){
            return 1.0; //TODO: update when the time comes
        }
        public double SolveValue(){
            return 0;
        }
        public bool IsNotZero(){
            return true;
        }
    }
}