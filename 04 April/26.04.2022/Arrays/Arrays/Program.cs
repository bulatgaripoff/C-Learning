using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            string[] month = new string[12] {"Январь", // Создание массива с названиями месяцев
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"};

            int[] income = new int[12];                 // Массив Доходы
            int[] consumption = new int[12];            // Массив Расходы
            int[] profit = new int[12];                 // Массив Прибыль

            Console.WriteLine("Введите доходы по месяцам"); // Приглашение ко вводу доходов
            for (int i = 0; i < 12; i++)                // Создание цикла для ввода доходов
            {
                Console.WriteLine($"\nДоход за {month[i]}:"); // Вывод на экран приглашения
                                                              // ввести доход за определенный месяц
                income[i] = int.Parse(Console.ReadLine());    // Ввод дохода за месяц с клавиатуры
                //income[i] = random.Next(0, 10000);
            }

            Console.WriteLine("\nВведите расходы по месяцам"); // Приглашение ко вводу расходов
            for (int i = 0; i < 12; i++)                // Создание цикла для ввода расходов
            {
                Console.WriteLine($"\nРасход за {month[i]}:");  // Вывод на экран приглашения
                                                                // ввести расход за определенный месяц
                consumption[i] = int.Parse(Console.ReadLine()); // Ввод расхода за месяц с клавиатуры
                //consumption[i] = random.Next(0, 10000);
            }

            // Расчет столбца прибыли
            for (int i = 0; i < 12; i++)
            {
                profit[i] = income[i] - consumption[i];
            }

            // Вывод на экран шапки таблицы
            Console.WriteLine($"{"Месяц",10}{"Доход, тыс.руб.",20}{"Расход, тыс.руб.",20}{"Прибыль, тыс.руб.",20}");

            // Вывод на экран значений таблицы
            Console.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (profit[i] <= 200)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{month[i],10}{income[i],20}{consumption[i],20}{profit[i],20}");
                }
                else if (profit[i] > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{month[i],10}{income[i],20}{consumption[i],20}{profit[i],20}");
                }
                else
                    Console.WriteLine($"{month[i],10}{income[i],20}{consumption[i],20}{profit[i],20}");

            }



            // Пузырек для сортировки массива прибыли и месяцев
            for (int j = 1; j < 12; j++)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (profit[i] > profit[i + 1])
                    {
                        int x = profit[i];
                        string m = month[i];
                        profit[i] = profit[i + 1];
                        month[i] = month[i + 1];
                        profit[i + 1] = x;
                        month[i + 1] = m;
                    }
                }
            }


            Console.ForegroundColor = ConsoleColor.White;   // Установка белого цвета шрифта консоли

            int z = 0;                                      // Вспомогательная переменная, равна
                                                            // числу наихудших прибылей (не превышает 3)      

            for (int i = 1; i < 12; i++)                        // Создание цикла для расчета числа
                                                                // месяцев с тремя худшими показателями
            {
                if (profit[i] != profit[i - 1]) z++;        // Условие проверки неравенства каждого
                                                            // последующего значения элемента
                                                            // сортированного массива доходов
                                                            // предыдущему значению. Увеличение
                                                            // счетчика числа наихудших прибылей

                if (z == 3)                                   // Когда число наихудших прибылей станет
                                                              // равно 3, сможем определить индекс в
                                                              // сортированном массиве прибылей, который
                                                              // соответствует конечному числу месяцев
                                                              // с тремя наихудшими показателями прибыли
                {
                    z = i;
                    break;
                }
            }



            // Вывод на экран месяцев с плохой прибылью, расчет числа месяцев с положительной прибылью
            Console.Write($"\nХудшая прибыль в месяцах: ");
            for (int i = 0; i < z; i++)
                Console.Write($"{month[i]} ");


            int k = 0; // счетчик месяцев с положительной прибылью

            Console.WriteLine();
            // Вывод на экран числа месяцев с положительной прибылью
            for (int i = 0; i < 12; i++)
                if (profit[i] > 0) k++;
            Console.Write($"\nМесяцев с положительной прибылью: {k}");

            Console.ReadKey();



        }
    }
}
