using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryNCatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> Integers = new List<int>();
                Integers.Add(98798);
                Integers.Add(9915);
                Integers.Add(453);
                Integers.Add(56);
                Integers.Add(7);
                Console.WriteLine("Please provide number for us to divide by? ");
                int number = Convert.ToInt32(Console.ReadLine());
                foreach (int num in Integers)
                {

                    int sum = num / number;
                    Console.WriteLine(" Your number " + number + " divided by the index value =  " + sum);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)// will display error 
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)// will display error
            {
                Console.WriteLine("Please don't divide by zero...");
            }
            finally// will engage after catches as the final program execution
            {
                Console.WriteLine("Finished with going through Try/Catch block please try again");
                Console.ReadLine();
              
            }
            //System.FormatException 
            //System.DivideByZeroException
        }
    }
}
