using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Class1
    {
        static int Sum(int x)
        {
            int min = 1;
            int max = 100;
            int tot = 0;
            for(int i=1; i <= x; i++)
            {
                tot += i;
            }
            return tot;
            
        }
        static void Sum(int step, int x=1, int y=100)
        {
            int tot = 0;
            for (int i = x; i <= y; i += step)
            {
                tot += i;
            }
            Console.WriteLine( tot);

        }
        static void Main()
        {
            Console.WriteLine(Sum(10));

            //Console.WriteLine(Sum(10,20));

            Sum(1, 100);
            Sum(100);
            Sum(90,1);
            Sum(1);
        }
    }
}
