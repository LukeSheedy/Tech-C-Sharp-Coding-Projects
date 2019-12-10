using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {

        string[] Arrays = { "zero", "one", "two", "three", "four" };
        Console.WriteLine("Please choose from Arrays 0-4 ");
        string chose = Console.ReadLine();
        // User inputs and then console writes from the Arrays
        if (chose == "0" )
            {
            Console.WriteLine("0 has an index value of : "+Arrays[0]);
        }
        else if (chose == "1")
        {
            Console.WriteLine("1 has an index value of : "+Arrays[1]);
        }
        else if (chose == "2")
        {
            Console.WriteLine("2 has an index value of : "+Arrays[2]);
        }
        else if (chose == "3")
        {
            Console.WriteLine("3 has an index value of : " + Arrays[3]);
        }
        else if (chose == "4")
        {
            Console.WriteLine("4 has an index value of : " + Arrays[4]);
        }
        else
        {
            Console.WriteLine("error please try again!" );
        }




        int[] Array2 = { 100, 200, 300, 400, 500 };
        Console.WriteLine("Please choose from a Array number 5-9");
        int Input = Convert.ToInt32(Console.ReadLine());
        //user inputs number and console writes from the array from ARRAY2
        if (Input == 5)
        {
            Console.WriteLine("5 has an index value of : " + Array2[0]);
        }
        else if (Input == 6)
        {
            Console.WriteLine("6 has an index value of : " + Array2[1]);
        }
        else if (Input == 7)
        {
            Console.WriteLine("7 has an index value of : " + Array2[2]);
        }
        else if (Input == 8)
        {
            Console.WriteLine("8 has an index value of : " + Array2[3]);
        }
        else if (Input == 9)
        {
            Console.WriteLine("9 has an index value of  : " + Array2[4]);
        }
        else
        {
            Console.WriteLine("error please try again!");
        }


        List<string> liststring = new List<string>();
        liststring.Add("This is the first string, ");
        liststring.Add("Going onto the second string, ");
        liststring.Add("Adding the third one also, ");
        liststring.Add("Just rolling into the forth, ");

        Console.WriteLine("Please choose a string number 0-4");
        int Input2 = Convert.ToInt32(Console.ReadLine());
        //user inputs number and console writes from the array from liststring
        if (Input2 == 0)
        {
            Console.WriteLine("0 index value : " + liststring[0]);
        }
        else if (Input2 == 1)
        {
            Console.WriteLine("1 index value  :" + liststring[1]);
        }
        else if (Input2 == 2)
        {
            Console.WriteLine("2 index value :" + liststring[2]);
        }
        else if (Input2 == 3)
        {
            Console.WriteLine("3 index value : " + liststring[3]);
        }
        else if (Input2 == 4)
        {
            Console.WriteLine("4 index value :" + liststring[4]);
        }
        else
        {
            Console.WriteLine("error please try again!");
        }
        Console.ReadLine();










    }
}

