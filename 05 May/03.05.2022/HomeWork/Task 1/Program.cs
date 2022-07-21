using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Метод разделения строки на отдельные слова
        /// </summary>
        /// <param name="S"></param>
        static void SplitString(string S)
        {
            Console.WriteLine();
            char[] Separators = new char[] { ' ', '.', ',', '?', '!' };
            string[] Subs = S.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var Sub in Subs)
            {
                Console.WriteLine(Sub);
            }
        }


        /// <summary>
        /// Метод вывода текста
        /// </summary>
        /// <param name="Text">Текст сообщения</param>
        static void Print(string Text)
        {
            Console.WriteLine(Text);
        }


        /// <summary>
        /// Метод ввода данных с клавиатуры
        /// </summary>
        static string Read()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            Print("Введите предложение:");
            SplitString(Read());
            Delay();

        }
    }
}
