using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(Console.WindowWidth / 3 + 10, 0);
            Console.WriteLine("ТРЕУГОЛЬНИК ПАСКАЛЯ");
            Console.WriteLine();
            Console.WriteLine("Введите число строк треугольника Паскаля: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;

            int[,] pascal = new int[a, b];
            pascal[0, 0] = 1;                                       // Присвоение первому значению 1
            for (int i = 0; i < a; i++) pascal[i, 0] = 1;           // Присвоение первому столбцу 1

            // Заполнение треугольника Паскаля
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = 1; j < b; j++)
                {
                    pascal[i + 1, j] = pascal[i, j] + pascal[i, j - 1];
                }
            }

            Console.Clear();

            // Вывод на экран треугольника
            for (int i = 0; i < a; i++)
            {
                Console.CursorLeft=(pascal.GetLength(0)/2*8-4*(i+1));
                for (int j = 0; j < b; j++)
                    if (pascal[i, j] != 0)
                    {
                        Console.Write($"{pascal[i, j],8}");
                    }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
