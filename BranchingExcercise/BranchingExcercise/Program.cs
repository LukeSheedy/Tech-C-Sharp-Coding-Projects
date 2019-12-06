using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight:");
            int packweight = Convert.ToInt32(Console.ReadLine());
            if (packweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;

            }

            Console.WriteLine("Please enter the package width:");
            int packwidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packlength = Convert.ToInt32(Console.ReadLine());


            int sum = (packwidth + packheight + packlength);
            if (sum >50 )
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            int weightsum = sum * packweight;
            Decimal totalsum = weightsum / 100.00m;
            string amount = totalsum.ToString("C");

            Console.WriteLine("Your estimated total for shipping this package is: " +amount);
            Console.WriteLine("Thank you.");
            Console.ReadLine();


        }
    }
}
