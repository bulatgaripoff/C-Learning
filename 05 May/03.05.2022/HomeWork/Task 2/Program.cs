using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Что нужно сделать
    // Пользователь вводит в программе длинное предложение.
    // Каждое слово раздельно одним пробелом.
    // После ввода пользователь нажимает клавишу Enter.
    // Необходимо создать два метода:
    // первый метод разделяет слова в предложении;
    // второй метод меняет эти слова местами(в обратной последовательности).
    // При этом важно учесть, что один метод вызывается внутри другого метода,
    // то есть в методе main вызывается метод cо следующей сигнатурой — ReversWords(string inputPhrase).
    // Внутри этого метода вызывается метод по разделению входной фразы на слова.
    // Советы и рекомендации
    // Для сложения строк можно использовать конкатенацию строк.
    // Выражение вида ResultString += NewString + “ ” добавит к текущей строке,
    // которая представлена переменной ResultString, новую строку из переменной NewString и
    // также добавит пробел к концу строки.
    // Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из
    // задания 1.

    internal class Program
    {
        /// <summary>
        /// Метод разделения строки на отдельные слова
        /// </summary>
        /// <param name="S"></param>
        static string[] SplitString(string S)
        {
            Console.WriteLine();
            char[] Separators = new char[] { ' ', '.', ',', '?', '!' };
            string[] Subs = S.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            return Subs;
        }

        /// <summary>
        /// Метод, который выводит слова в строке в обратном порядке
        /// </summary>
        /// <param name="S"></param>
        static void ReversWords(string InputString)
        {
            string ResultString = null;
            for (int i = SplitString(InputString).Length-1; i >= 0; i--)
            {
                ResultString += SplitString(InputString)[i]+" ";
            }
            Print(ResultString);
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
            ReversWords(Read());
            Delay();
    }
}
}

