using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114Class
{
    class Math
    {
        public int Multi(int num1)
        {
            num1 = num1 * 9;
            return num1;
        }

        public int Multi(decimal num2)// Paramiters are the inside of ()
        {
            num2 = num2 / 9;
            int num3 = Decimal.ToInt32(num2);
            return num3;
        }

        public int Multi(string num3)//return only return type thing oustide (), but can accept many data inside input parameters()
        {
            
            int num4 = Convert.ToInt32(num3);
            num4 = num4 + 9;
            return num4;
        }

    }
}
