using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Int32 Number1 = 0;
            Int32 Number2 = 0;
            Int32 Final = 0;
            String Choice;

            Console.WriteLine("Welcome to My Calculator!");
            Console.Write("Please enter the first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What do you want to do with this number?: (+, *, / or -) ");
            Choice = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            if (Choice == "+")
            {
                Final = Number1 + Number2;
            }
            if (Choice == "*")
            {
                Final = Number1 * Number2;
            }
            if (Choice == "/")
            {
                Final = Number1 / Number2;
            }
            if (Choice == "-")
            {
                Final = Number1 - Number2;
            }

            Console.WriteLine("The " + Choice + " was applied");
            Console.Write("The ending result is: {0} ", Final);
            Console.Write("Press any key to close...");
            Console.ReadKey();
        }
    }
}
