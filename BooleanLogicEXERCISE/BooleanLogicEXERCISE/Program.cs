using System;


namespace BooleanLogicEXERCISE
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int userAGE = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (please answer true or false)");
            string submit = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int userticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            Console.WriteLine(userAGE > 15 && submit == "false" && 3 > userticket);
            Console.ReadLine();

        }
    }
}
