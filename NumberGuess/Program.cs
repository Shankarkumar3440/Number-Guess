using System;

namespace NumberGuess
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            getAppInfo();
            getUserName();
          
            while (true)
            {
                // create a random number
                Random random = new Random();
                int correctNumber = random.Next(1,10);


                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 10");


                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {

                        PintcolorChange(ConsoleColor.Red, "Please use an actual Number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PintcolorChange(ConsoleColor.Red, "Wrong Number, Please try again");
                    }

                }
                PintcolorChange(ConsoleColor.Yellow, "You are gussed it!!!");

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (true)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void getAppInfo()
        {
            string App_Name = "Number Guesser";
            string App_Version = "1.0.0";
            string App_Author = "Shankar Kumar";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: version {1} by {2}", App_Name, App_Version, App_Author);

            Console.ResetColor();
        }
        static void getUserName()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} , let's play a game..... ", inputName);

        }
        static void PintcolorChange(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();   
        }
    }
}
