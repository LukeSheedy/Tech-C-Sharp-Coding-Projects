using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Oneclass
    {


        public int Rename(int var)
        {
            var++;

            return var;
        }

        public int Rename2(int var)
        {
            var = var * 5;

            return var;
        }

        public int Rename3(int var)
        {
            var = var / 2;

            return var;
        }



        public string Div { get; set; }
        public string Plus { get; set; }
        public string Minus { get; set; }
        public string Multi { get; set; }
    }
}
