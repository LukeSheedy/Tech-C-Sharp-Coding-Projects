using System;


namespace MathNComparisonOperEXERC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");


            Console.WriteLine("Hourly Rate?");
            int userhourly = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hours worked per week?");
            int weekhourly = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Person 2");


            Console.WriteLine("Hourly Rate?");
            int userhourly2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hours worked per week?");
            int weekhourly2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weekly salary of Person 1:");
            int combined = userhourly * weekhourly;
            Console.WriteLine(combined);



            Console.WriteLine("Weekly salary of Person 2:");
            int combined2 = userhourly2 * weekhourly2;
            Console.WriteLine(combined2);



            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(combined>combined2);


            Console.WriteLine("Thanks For Comparing!");
            Console.ReadLine();


        }
    }
}
