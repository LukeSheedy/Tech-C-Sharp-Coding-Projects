using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "The mouse in the house ";
            string two = "went under the bed ";
            string three = "to find if there was cheese.";
            Console.WriteLine(one+ two + three);// Concatenate three strings

            one = one.ToUpper();
            Console.WriteLine(one);// upper case whole string

            StringBuilder Test = new StringBuilder();
            Test.Append("Building some paragrpahs is the key, ");
            Test.Append("to make sure we can test ");
            Test.Append("our knowledge on Stringbuilder exercise. ");
            Console.WriteLine(Test);// Building a pharagraph one at a time taking the orignal and adding to it


            Console.ReadLine();



        }
    }
}
