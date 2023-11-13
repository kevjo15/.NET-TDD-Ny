namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0 && nummer % 5 == 0)
            {
                return "FizzBuzz";

            }
            else if (nummer % 3 == 0)
            {
                return "FIZZ";
            }
            else if (nummer % 5 == 0)
            {
                return "BUZZ";
            }
            else
            {
                return nummer.ToString();
            }
        }
        public static void FizzBuzzKalkyl2(int nummer)
        {
            //string output;

            //if (nummer % 3 == 0 && nummer % 5 == 0)
            //{
            //    output = "FizzBuzz";
            //}
            //else if (nummer % 3 == 0)
            //{
            //    output = "FIZZ";
            //}
            //else if (nummer % 5 == 0)
            //{
            //    output = "BUZZ";
            //}
            //else
            //{
            //    output = nummer.ToString();
            //}

            Console.WriteLine(FizzBuzzKalkyl(nummer));
        }


    }
}
