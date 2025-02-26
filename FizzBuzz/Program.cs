namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            PrintNumbers();
        }
        public static void PrintNumbers()
        {
            for (int num = 1; num <= 100; num++)
            {
                string output = "";
                if (num % 3 == 0)
                {
                    output += "Fizz";
                }
                if (num % 5 == 0)
                {
                    output += "Buzz";
                }                
                if(output == "")
                {
                    output = Convert.ToString(num);
                }
                Console.WriteLine(output);
            }
        }
    }
}

