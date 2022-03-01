using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int res;
            //0 + 1 = 1

            for (int i = 1; i <= 1000; i++)
            {
                res = a + b; //0 + 1 = 1
                if (res <= 1000)
                {
                    Console.WriteLine(res); //prints 1
                }
                else
                {
                    Console.WriteLine("Maximum limit reach");
                    break;
                }
                b = a; //b = 1
                a = res; //a = 1
            }
        }
    }
}