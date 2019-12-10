using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {

        string[] Arrays = { "zero", "one", "two", "three", "four" };
        Console.WriteLine("Please choose from Arrays[0]-Arrays[4]");
        string chose = Console.ReadLine();
        // User inputs and then console writes from the array
        if (chose == "Arrays[0]" )
            {
            Console.WriteLine("Arrays[0] has an index value of "+Arrays[0]);
        }
        else if (chose == "Arrays[1]")
        {
            Console.WriteLine("Arrays[1] has an index value of "+Arrays[1]);
        }
        else if (chose == "Arrays[2]")
        {
            Console.WriteLine("Arrays[2] has an index value of "+Arrays[2]);
        }
        else if (chose == "Arrays[3]")
        {
            Console.WriteLine("Arrays[3] has an index value of " + Arrays[3]);
        }
        else if (chose == "Arrays[4]")
        {
            Console.WriteLine("Arrays[4] has an index value of " + Arrays[4]);
        }
        else
        {
            Console.WriteLine("error please try again!" );
        }

        Console.ReadLine();


        int[] Array2 = { 100, 200, 300, 400, 500 };
        Console.WriteLine("Please choose a number 0-5");
        int Input = Convert.ToInt32(Console.ReadLine());
        //user inputs number and console writes from the array
        if (Input == 0)
        {
            Console.WriteLine("0 has an index value of " + Array2[0]);
        }
        else if (Input == 1)
        {
            Console.WriteLine("1 has an index value of " + Array2[1]);
        }
        else if (Input == 2)
        {
            Console.WriteLine("2 has an index value of " + Array2[2]);
        }
        else if (Input == 3)
        {
            Console.WriteLine("3 has an index value of " + Array2[3]);
        }
        else if (Input == 4)
        {
            Console.WriteLine("4 has an index value of " + Array2[4]);
        }
        else
        {
            Console.WriteLine("error please try again!");
        }
        Console.ReadLine();
    }
}

