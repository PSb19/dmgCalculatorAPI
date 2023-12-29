namespace calculator40k.Models
{
    public class Values
    {
        public double Normal {get; set;}
        public double Critical {get; set;}

        public Values(){
            Normal = 0;
            Critical = 0;
        }
        public Values(double normal, double critical){
            Normal = normal;
            Critical = critical;
        }
    }
}