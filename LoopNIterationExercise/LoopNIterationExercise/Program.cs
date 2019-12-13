using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopNIterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1:[FINISHED] for the first question! 
            //string[] names = { "Bob", "Joe", "Bill", "Josh" };
            //Console.WriteLine("What is a good last name?");
            //string lname = Console.ReadLine();


            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = names[i] + " " + lname;
            //}

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //// 2:[FINISHED] for the second question create an infinte loop

            //for (int i = 0; i < 50; i--)
            //{
            //    Console.WriteLine("INFINTE");
            //}


            ////3:[FINISHED]  for the Third question loop will exutue
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Finish execute loop");
            //}
            //Console.ReadLine();


            ////4: [FINISHED]create looop where compairson is used a “<” operator and iterates up until 5
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i < 5)
            //    {
            //        Console.WriteLine("This is a greater than loop");
            //    }
            //}
            //Console.ReadLine();

            ////5: [FINISHED]create looop where compairson is used a “<=” operator and iterates 9 times
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i <= 8)
            //    {
            //        Console.WriteLine("This is a equal or greater than loop");
            //    }
            //}
            //Console.ReadLine();


            ////6:[HELP] create list of strings all unquie , creating a loop that iterates through the names and isplays the index 


            String[] states = { "WA", "CO", "OR", "KS", "IN", "IL", "MS" };
           
            Console.WriteLine("Please choose which state is your favorite: WA, OR, CO, KS, MS, IN, IL, MS ");
            string favstate = Console.ReadLine();
            String searchString = favestate;
            int index = Array.IndexOf(states, searchString);
            for (int j = 0; j <= 7; j++)

            {

                if (favstate == states[j])
                {
                    Console.WriteLine(states[j]);
                    break;//// 8:[FINISHED] once found breaks from iteration
                }
                //// 7:[FINISHED] add to above loop that tells user isnt on the list
                else
                {
                    Console.WriteLine("Please choose from those states!");
                } 

            }
            Console.ReadLine();

            /// index of

            //9: [HELP] create list of string that identical and ask user to display them.
            //List<string> waters = new List<string>();
            //waters.Add("Tuna");//should show 0
            //waters.Add("Tuna");// shold show 1
            //waters.Add("Dolphin");
            //waters.Add("Shark");
            //waters.Add("Whale");

            //Console.WriteLine("Which one? Tuna, Dolphin, Shark, Whale");
            //string choice = Console.ReadLine();
            //String searchString = favestate;
            //int index = Array.IndexOf(states, searchString);
            //for (int j = 0; j < 5; j++)
            //{
            //    if (choice == waters[j])

            //    {
            //        Console.WriteLine(waters[j]);
            //    }
            //    else// 10:[FINISHED] adding code to please use choose only on list
            //    {
            //        Console.WriteLine("error please try one on the list!");
            //    }
            //    Console.ReadLine();

            //}


            ////11: [HELP]
            //List<string> places = new List<string>();
            //places.Add("Denver");
            //places.Add("Denver");
            //places.Add("Seattle");
            //places.Add("Portland");
            //places.Add("Layton");
            //foreach (string place in places)
            //{
            //    if (places )
            //    {
            //        .Add(place);
            //    }
            //    else if  {
            //        Console.WriteLine("Alaready in the list");
            //    }

            //    Console.WriteLine();
            //    Console.ReadLine();
            //}
            /// use contian method======

        }

    }


    }

    
