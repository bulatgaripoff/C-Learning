using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_old
{
    internal class Program
    {
        /// <summary>
        /// Метод, который делит введенную строку на отдельные символы.
        /// </summary>
        /// <param name="S">Слово, которое необходимо разделить</param>
        /// <returns>Массив, элементами которого являются отдельные символы введенного слова</returns>
        static char[] SplitWord(string S)
        {
            // Создание массива с символами
            char[] Subs = S.ToCharArray(0, S.Length);

            // Возврат массива с символами
            return Subs;
        }

        /// <summary>
        /// Метод #1, убирающий дублирующиеся символы из строки
        /// </summary>
        /// <param name="S">Введенная строка</param>
        static void ClearString1(string S)
        {
                char[] Letters=SplitWord(S);                                // Создаем массив с символами строки
                bool[] check=new bool[S.Length];                            // Создаем дублирующий массив
                Console.Write(Letters[0]);                                  // Выводим на экран первый символ строки
                for (int i=1; i<S.Length; i++)                              // Запускаем цикл для вывода остальных символов
            {   
                if (Letters[i] == Letters[i-1]) check[i]=true;              // Если текущий символ совпадает с предыдущим, то
                else check[i]=false;                                        // в дублирующий массив пишем true. В противном случае - 
                if (check[i]==false) Console.Write(Letters[i]);             // false.
                                                                            // Выводим на экран символы, индекс которых равен индексам
            }                                                               // элементов false дублирующего массива       

        }

        /// <summary>
        /// Метод #2, убирающий дублирующиеся символы из строки
        /// </summary>
        /// <param name="S">Введенная строка</param>
        static void ClearString2(string S)
        {
            int i = 1;                                              // Задаем счетчик
            char[] Letters = SplitWord(S);                          // Создаем массив символов
            Console.Write(Letters[0]);                              // Выводим на экран первый символ
            while (i<S.Length)                                      // Задаем цикл "пока i меньше числа символов"
            {
                if (Letters[i]!=Letters[i-1])                       // Если текущий символ не равен предыдущему
                {
                    Console.Write(Letters[i]);                      // Выводим его на экран
                    i++;                                            // Увеличиваем i --> переходим к следующему символу
                }
                else i++;                                           // В противном случае --> сразу переходим к следующему символу
            }

        }

        /// <summary>
        /// Метод #3, убирающий дублирующиеся символы из строки
        /// </summary>
        /// <param name="S">Введенная строка</param>
        static void ClearString3(string S)
        {
            List<char> Letters = new List<char>(SplitWord(S));              // Создаем список символов
            Console.Write(Letters[0]);                                      // Выводим на экран первый символ
            int i = 1;                                                      // Создаем счетчик
            while (i<Letters.Count)                                         // Задаем цикл "пока i меньше числа символов"
            {
                if (Letters[i]!=Letters[i-1])                               // Если текущий символ не равен предыдущему
                {
                    Console.Write(Letters[i]);                              // Выводим его на экран
                    i++;                                                    // Увеличиваем i --> переходим к следующему символу
                }
                else
                {
                    Letters.RemoveAt(i);                                    // В противном случае - удаляем символ из списка
                }
            }
        }

        /// <summary>
        /// Метод #4, убирающий дублирующиеся символы из строки
        /// </summary>
        /// <param name="S">Введенная строка</param>
        static void ClearString4(string S)
        {
            int i = 1;                                                                          // Создаем счетчик
            while (i < S.Length)                                                                // Создаем цикл "пока i меньше числа
            {                                                                                   // символов
                if (S.Substring(i, 1) == S.Substring(i - 1, 1) && (i != S.Length - 1))          // Если текущий символ равен предыдущему
                {                                                                               // и мы не стоим на последнем символе,
                    S = S.Substring(0, i) + S.Substring(i + 1);                                 // то соединяем подстроку до символа и 
                }                                                                               // после
                else if (S.Substring(i, 1) == S.Substring(i - 1, 1) && (i  == S.Length - 1))    // То же самое и мы стоим на последнем
                    S=S.Substring(0,i);                                                         // символе, то просто строка равна 
                else i++;                                                                       // подстроке до
            }                                                                                   // в противном случае просто переходим
            Console.WriteLine(S);                                                               // к следующему символу
        }

        static void Main(string[] args)
        {
            ClearString1("Прривввввввввввввет ххоррошш");
            Console.WriteLine();
            ClearString2("П");
            Console.WriteLine();
            ClearString3("Прривввввввввввввет ххоррошш");
            Console.WriteLine();
            ClearString4("Прривввввввввввввет ххорррошшоошшш");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
