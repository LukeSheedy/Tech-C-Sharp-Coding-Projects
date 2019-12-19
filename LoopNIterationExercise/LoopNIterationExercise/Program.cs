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
            string[] names = { "Bob", "Joe", "Bill", "Josh" };
            Console.WriteLine("What is a good last name?");
            string lname = Console.ReadLine();


            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + lname;
            }

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();

            //// 2:[FINISHED] for the second question create an infinte loop

            for (int i = 0; i < 50; i--)
            {
                Console.WriteLine("INFINTE");
            }


            ////3:[FINISHED]  for the Third question loop will execute
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Finish execute loop");
            }
            Console.ReadLine();


            ////4: [FINISHED]create looop where compairson is used a “<” operator and iterates up until 5
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine("This is a greater than loop");
                }
            }
            Console.ReadLine();

            ////5: [FINISHED]create looop where compairson is used a “<=” operator and iterates 9 times
            for (int i = 0; i < 10; i++)
            {
                if (i <= 8)
                {
                    Console.WriteLine("This is a equal or greater than loop");
                }
            }
            Console.ReadLine();


            //////6:[FINISHED with alan!] create list of strings all unquie , creating a loop that iterates through the names and displays the index number


            String[] states = { "WA", "CO", "OR", "KS", "IN", "IL", "MS" };
            Console.WriteLine("Please choose which state is your favorite: WA, OR, CO, KS, IN, IL, MS ");
            string favstate = Console.ReadLine();

            for (int j = 0; j < 7; j++)
            {
                if (favstate == states[j])
                {
                    Console.WriteLine(j);
                    break;//// 8:[FINISHED] once found breaks from iteration
                }
                //// 7:[FINISHED] add to above loop that tells user isnt on the list
                if (j == 6)
                {
                    Console.WriteLine("Please choose from those states!");
                }

            }
            Console.ReadLine();


            //////9: [FINISHED with ben!] create list of string that identical and ask user to display them.
            String[] waters = { "Tuna", "Tuna", "Dolphin", "Shark", "Whale" };
            Console.WriteLine("Which one? Tuna, Dolphin, Shark, Whale");
            string choice = Console.ReadLine();
            for (int j = 0; j < 5; j++)
            {
                if (choice == waters[j])

                {
                    Console.WriteLine(j);

                }

                else // 10:[FINISHED] adding code to please use choose only on list
                {
                    Console.WriteLine("Try one on the list!");
                    break;
                }
            }
            Console.ReadLine();

            //////11: [FINISHED with ben!]
            List<string> places = new List<string>();
            places.Add("Denver");
            places.Add("Denver");
            places.Add("Seattle");
            places.Add("Portland");
            places.Add("Layton");
            List<string> List = new List<string>();
            foreach (string place in places)
            { 
                if (List.Contains(place))
                {
                    Console.WriteLine(place+" Already in the list.");
                }
                else if (!List.Contains(place))
                {
                    List.Add(place);
                    Console.WriteLine(place + " This hasnt placed in the list.");
                }
            }
            Console.ReadLine();
            ///// use contian method====

        }

    }


 }

    
