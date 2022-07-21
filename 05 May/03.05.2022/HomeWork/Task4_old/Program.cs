using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_old
{
    internal class Program
    {
        /// <summary>
        /// Метод разделения строки на отдельные слова
        /// </summary>
        /// <param name="S"></param>
        static string[] SplitString(string S)
        {
            char[] Separators = new char[] { ' ', '.', ',', '?', '!' };
            string[] Subs = S.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            return Subs;
        }

        /// <summary>
        /// Метод определяет, является ли последовательность чисел прогрессией
        /// </summary>
        /// <param name="S">Последовательность чисел, разделенных ' ', '.', ',', '?', '!' </param>
        static void Progression(string S)
        {
            double[] Sequence = new double[SplitString(S).GetLength(0)];            // создаем массив из подстрок
            for (int i = 0; i < Sequence.GetLength(0); i++)
                    double.TryParse(SplitString(S)[i], out Sequence[i]);            // преобразуем подстроки в числа

            bool checkA = false;                                                      // переменная состояния арифм. прогрессии
            bool checkG = false;                                                      // переменная состояния геом. прогресси

           
            if (Sequence.GetLength(0) != 1)
            {
                double step = Sequence[1] - Sequence[0];                                // вычисление шага между 0 и 1 элементами прогрессии
                for (int i = 1; i < Sequence.GetLength(0); i++)                         // Запуск цикла, в котором проверяется равенство шага
                {                                                                       // если шаг сохраняется на всем наборе, то true
                    if (Sequence[i] - Sequence[i - 1] == step)
                        checkA = true;
                    else
                    {
                        checkA = false;                                                 // В противном случае false
                        break;
                    }
                }

                if (Sequence[0] != 0)                                                   // Если первое число набора не равно 0
                {
                    double ratio = Sequence[1] / Sequence[0];                           // Считаем частное от деления 1 и 0 элементов
                    for (int i = 1; i < Sequence.GetLength(0); i++)                     // Запуск цикла, в котором проверяется равенство
                    {                                                                   // частного на всем наборе. Если выполняется, то
                        if (Sequence[i] / Sequence[i - 1] == ratio)                     // true
                            checkG = true;
                        else
                        {
                            checkG = false;                                             // В противном случае false
                            break;
                        }
                    }
                }
                else checkG = false;                                                    // Состояние геом. прогрессии false в случае,
                                                                                        // если первый член равен 0
            }


            if (checkA ==true) Console.WriteLine("Является арифметической прогрессией");                // Вывод на экран результата
            if (checkG == true) Console.WriteLine("Является геометрической прогрессией");
            else if (checkA == false && checkG == false) Console.WriteLine("Не является прогрессией");
        }
        static void Main(string[] args)
        {
            Progression("2");
            Console.ReadKey();
        }
    }
}
