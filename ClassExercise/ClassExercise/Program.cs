using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number to do math Operations on.");
            int guess = Convert.ToInt32(Console.ReadLine());
            Oneclass One = new Oneclass();// first give the method an object
            int Answer = One.Rename(guess);//then declare a new var, then use the first object and use one of the methods.(place there guess in the value to give to method)// 
            int Answer2 = One.Rename2(guess);
            int Answer3 = One.Rename3(guess);

            Console.WriteLine(guess + " Plus one equals " + Answer);// write both guess and answer after gone through method
            Console.WriteLine(guess + " Times five equals " + Answer2);
            Console.WriteLine(guess + " Divide by two equals " + Answer3);
            Console.ReadLine();



        }


    }
}
