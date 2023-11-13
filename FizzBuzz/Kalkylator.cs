namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if(nummer % 3 == 0)
            {
                return "FIZZ";
            }
            else
            {
                return nummer.ToString();
            }
            
        }
    }
}