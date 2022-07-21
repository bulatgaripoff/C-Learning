using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_old
{
    internal class Program
    {
        /// <summary>
        /// Метод, который делит введенную строку на отдельные слова
        /// </summary>
        /// <param name="S">Строка, которую необходимо разделить</param>
        /// <returns>Массив, элементами которого являются отдельные слова введенной строки</returns>
        static string[] SplitString(string S)
        {
            // Создание массива с разделителями
            char[] Separators = new char[] { ' ', '.', ',', '?', '!' };

            // Создание массива с подстроками
            string[] Subs = S.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            
            // Возврат массива с подстроками
            return Subs;
        }

        /// <summary>
        /// Поиск самых коротких/длинных слов
        /// </summary>
        /// <param name="S">Строка, в которой выполняется поиск</param>
        /// <param name="val">Параметр 0 - самое короткое слово; 1 - самое длинное слово</param>
        static void Size(string S, int val)
        {
            string[] Words = SplitString(S);                                        // Создаем массив с подстроками
            for (int j = 1; j < Words.Length; j++)                                  // Запускаем метод пузырька для сортировки массива
            {                                                                       // слов по количеству символов
                for (int i = 0; i < Words.Length-j; i++)
                {

                            if (Words[i].Length > Words[i + 1].Length && val!=1)
                            {
                                string x = Words[i];
                                Words[i] = Words[i + 1];
                                Words[i + 1] = x;
                                break;
                            }

                            if (Words[i].Length < Words[i + 1].Length && val==1)
                            {
                                string x = Words[i];
                                Words[i] = Words[i + 1];
                                Words[i + 1] = x;
                                break;
                            }

                    }

            }

            Console.Write($"{Words[0]}");                                           // Вывод на экран первого элемента массива
            for (int i = 1; i < Words.Length; i++)                                  // Цикл для вывода на экран элементов
            {                                                                       // с тем же числом символов
                if (Words[0].Length == Words[i].Length)
                    Console.Write($", {Words[i]}");
                else break;
            }

        }
        static void Main(string[] args)
        {
            Size("Привет, меня зову Булатт!", 1);                                   // Вызов метода поиска
            Console.ReadKey();
        }
    }
}
