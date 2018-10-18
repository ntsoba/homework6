using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public bool Number(int a)
        {
            if (a < 2) return false;
            if (a%2 == 0) return false;
            return true;
        }


        public  int Fibon(int x)
        {
            if (x == 1) { return 1; }

            if (x == 0) { return 0; }

            else
            {
                return Fibon(x - 1) + Fibon(x - 2);
            }
        }
    }
}
