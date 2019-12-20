using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise113
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoInt Sum = new TwoInt();
            Sum.Two(2, 5);// before listing the parameters by name
            Sum.Two(var2: 5, var: 2);// after listing by name

            Console.ReadLine();

        }



    }
}
