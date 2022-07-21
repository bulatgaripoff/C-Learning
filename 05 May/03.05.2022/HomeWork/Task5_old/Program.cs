using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_old
{
    internal class Program
    {
        /// <summary>
        /// Вычисление функции Аккермана
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Akkerman(int m, int n)
        {
            int A = 0;
            if (m == 0)
            {
                A = n + 1;
            }
            else if (m > 0 && n == 0)
            {
                A = Akkerman(m - 1, 1);
            }
            else if (m>0 && n>0)
            {
                A=Akkerman(m - 1, Akkerman(m, n-1));
            }
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Akkerman(3, 10));
            Console.ReadKey();
        }
    }
}
