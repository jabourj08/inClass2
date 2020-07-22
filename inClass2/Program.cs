using System;

namespace inClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            // USING IF STATEMENTS - Ask user to enter a number between 1 and 100
            Console.WriteLine("Please input a number between 1 and 100");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if (1 <= num && num <= 100)
            {
                Console.WriteLine("Good work, that number is in range!");
            }
            else if (100 <  num && num <=1000)
            {
                Console.WriteLine("That's a big number!");
            }
            else
            {
                Console.WriteLine("That number is out of range, please try again.");
            }


            // USING CASE SWITCH - Ask user to enter a color
            Console.WriteLine("Please input a color");
            string input2 = Console.ReadLine();

            switch (input2)
            {
                case "red":
                    Console.WriteLine("Red is a nice color!");
                    break;
                case "blue":
                    Console.WriteLine("Blue is pretty!");
                    break;
                case "yellow":
                    Console.WriteLine("Yellow is lively!");
                    break;
                default:
                    Console.WriteLine("That is not a primary paint color, please try again.");
                    break;
            }


            //SWITCH STATEMENTS WITH NUMBERS
            Console.WriteLine("Please input a number");
            string input3 = Console.ReadLine();
            int num3 = int.Parse(input3);

            switch (num3 > 10)
            {
                case true:
                    Console.WriteLine("Your number is greater than 10!");
                    break;
                case false:
                    Console.WriteLine("Your number is less than or equal to 10!");
                    break;
            }

            


            //FIZZBUZZ BEGIN
            bool cont = true;

            Console.WriteLine("Welcome to FIZZBUZZ!");            
            
            //USING IF STATEMENTS
            while (cont) {
                Console.WriteLine("***(IF STATEMENTS)*** Please input a number.");
                string fizzInput = Console.ReadLine();
                int fizzNum = int.Parse(fizzInput);

                if (fizzNum % 3 == 0 && fizzNum % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.WriteLine();
                    cont = false;
                }
                else if (fizzNum % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.WriteLine();
                    cont = false;
                }
                else if (fizzNum % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.WriteLine();
                    cont = false;
                }
                
                else
                {
                    Console.WriteLine("Your number is not divisible by 3 or 5. Please try again.");
                    Console.WriteLine();
                }

            }

            cont = true;

            //Console.WriteLine("Please input a number.");
            //fizzInput = Console.ReadLine();
            //fizzNum = int.Parse(fizzInput);

            //USING CASE SWITCH
            while (cont)
            {
                Console.WriteLine("***(CASE SWITCH STATEMENTS)***Please input a number.");
                string fizzInput = Console.ReadLine();
                int fizzNum = int.Parse(fizzInput);

                switch (fizzNum)
                {
                    case int n when (n % 3 == 0 && n % 5 == 0):
                        Console.WriteLine("FizzBuzz");
                        Console.WriteLine();
                        cont = false;
                        break;
                    case int n when (n % 3 == 0):
                        Console.WriteLine("Fizz");
                        Console.WriteLine();
                        cont = false;
                        break;
                    case int n when (n % 5 == 0):
                        Console.WriteLine("Buzz");
                        Console.WriteLine();
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Your number is not divisible by 3 or 5. Please try again.");
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("Thank you for using the FizzBuzz program! Goodbye!");

            }
            
            

            
            //FIZZBUZZ IN A LOOP
            Console.WriteLine("Welcome to FIZZBUZZ!");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + ": FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + ": Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + ": Buzz");
                }
                else
                {
                    Console.WriteLine(i + ": Not Fizz, Buzz, or Fizzbuzz");
                }
            }
            


            //INTRO TO FOR LOOPS
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
            
        }
    }
}
