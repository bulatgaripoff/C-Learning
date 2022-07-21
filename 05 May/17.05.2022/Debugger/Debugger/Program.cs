using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i=2; i<10; i++)
            {
                for (int j=2; j<10; j++)
                {
                    if (j % i == 0) Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
