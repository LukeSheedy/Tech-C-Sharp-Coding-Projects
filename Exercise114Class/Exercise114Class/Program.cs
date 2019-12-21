using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114Class
{
    class Program
    {
        static void Main(string[] args)// will start with this method
        {
            Math math = new Math();
            int Answer = math.Multi(12);//
            int Answer2 = math.Multi(12m);// are the arguments givin to the methods
            int Answer3 = math.Multi("12");
                
            Console.WriteLine(Answer);
            Console.WriteLine(Answer2);
            Console.WriteLine(Answer3);
            Console.ReadLine();

        }
    }
}
