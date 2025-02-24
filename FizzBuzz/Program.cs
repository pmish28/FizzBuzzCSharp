using System.Reflection.Metadata.Ecma335;

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
                switch (num % 15)
                {

                    case 0:
                        Console.WriteLine("FizzBuzz");
                        break;
                    case 3:
                        Console.WriteLine("Fizz");
                        break;
                    case 5:
                        Console.WriteLine("Buzz");
                        break;
                    default:
                        Console.WriteLine(num);
                        break;
                }

            }
        }
    }

}

