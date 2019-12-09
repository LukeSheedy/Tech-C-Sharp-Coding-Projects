using System;


namespace BooleanWhileNDostatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();

            bool isGuessed = color == "red";
            //DO STATEMENT WILL KEEP LOOPING UNTIL SELECT CORRECT ONE
            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue.Try again please.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green.Try again one more time.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "brown":
                        Console.WriteLine("You guessed brown.Try again maybe.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. That is correct!!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Thats not a good color.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                }

            }


            while (!isGuessed);
            Console.WriteLine("Guess A through D?");////STARTING THE WHILE STATEMENT AFTER THE DO STATEMENT
            string guess = Console.ReadLine();

            bool letter = guess == "D";

            while (!letter)
                {
                switch (guess)
                {
                    case "A":
                        Console.WriteLine("You guessed A.Try again please.");
                        Console.WriteLine("Guess a letter?");
                        guess = Console.ReadLine();
                        break;
                    case "B":
                        Console.WriteLine("You guessed B.Try again one more time.");
                        Console.WriteLine("Guess a letter?");
                        color = Console.ReadLine();
                        break;
                    case "C":
                        Console.WriteLine("You guessed C.Try again maybe!");
                        Console.WriteLine("Guess a letter?");
                        guess = Console.ReadLine();
                        break;
                    case "D":
                        Console.WriteLine("You guessed D. That is correct!!");
                        letter = true;
                        break;
                    default:
                        Console.WriteLine("Please TRY again!");
                        Console.WriteLine("Guess a letter?");
                        guess = Console.ReadLine();
                        break;
                }
                
            }
            Console.Read();


        }
    }
}
