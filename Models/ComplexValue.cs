namespace calculator40k.Models
{
    public class ComplexValue
    {
        public string Value {get; set;}
        public ComplexValue(string value = "err"){
            Value = value;
        }
        public override string ToString(){
            return Value;
        }
        public double ToNumerical(){
            return 1.0; //TODO: update when the time comes
        }
    }
}