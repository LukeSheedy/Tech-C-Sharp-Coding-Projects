using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {

        string[] Arrays = { "zero", "one", "two", "three", "four" };
        Console.WriteLine("Please choose from Arrays 0-4 ");
        int chose = Convert.ToInt32(Console.ReadLine());
        // User inputs and then console writes from the Arrays
        if (chose >= 0 && chose < Arrays.Length)
            {
            Console.WriteLine(chose+" index has a value of : "+Arrays[chose]);
            }
       
        else
        {
            Console.WriteLine("error please try again!" );
        }



        int[] Array2 = { 100, 200, 300, 400, 500 };
        Console.WriteLine("Pick a number 0-4");
        int Input = Convert.ToInt32(Console.ReadLine());
        //user inputs number and console writes from the array from ARRAY2
        if (Input >= 0 && Input <= Array2.Length)
        {
            Console.WriteLine(Input+" index value is : " +Array2[Input]);
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
        liststring.Add("The fifth and Final!");

        Console.WriteLine("Please choose a string number 0-4");
        int Input2 = Convert.ToInt32(Console.ReadLine());
        //user inputs number and console writes from the array from liststring
        if (Input2 >= 0 && Input2 <= 4)
        {
            Console.WriteLine(Input2+" index value = " +liststring[Input2]);
        }
        else
        {
            Console.WriteLine("error please try again!");
        }
        Console.ReadLine();

    }
}

