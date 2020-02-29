using System;

namespace DeliverableMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1= 0;
            int Num2 = 0;
            int result;
            char input = 'B';

            Console.WriteLine("Kelly Duong");

            Console.WriteLine("Please enter the first number.");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("Options");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Please enter the number that you want to perform.");

            input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("The sum between" + " " + Num1 + " " + "and" + " " + Num2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;

                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("The difference between" + " " + Num1 + " " + "and" + " " + Num2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;

                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("The product between" + " " + Num1 + " " + "and" + " " + Num2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;

                case '4':
                    result = Num1 / Num2;
                    Console.WriteLine("The quotient between" + " " + Num1 + " " + "and" + " " + Num2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
