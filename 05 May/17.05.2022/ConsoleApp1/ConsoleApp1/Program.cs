using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int.TryParse(Console.ReadLine(), out int N);
            var numbers = new List<int>();
            for (int i = 1; i < N+1; i++)
            {
                numbers.Add(i);
            }


            for (int i = 3; i < N + 1; i++)
            {
                for (int j = 2; j < N; j++)
                {
                    if (i % j == 0)
                    {
                        numbers.Remove(i);
                    }

                }
                
            }

           

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
