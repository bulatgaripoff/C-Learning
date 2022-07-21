using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Task 1

            //Console.WriteLine("Введите целое число: "); // Предложение ввести целое число
            //int a=int.Parse(Console.ReadLine()); // Преобразование введенного числа в целочисленный тип

            //if (a%2==0) // Создание цикла с условием: остаток от деления числа на 2 равен 0
            //{
            //    Console.WriteLine("Число является четным"); // Вывод результата "Число четное"
            //}
            //else
            //{
            //    Console.WriteLine("Число является нечетным"); // Вывод результата "Число нечетное"
            //}

            //Console.ReadKey(); // Задержка экрана

            //#endregion

            //#region Task 2

            //Console.WriteLine("Приветствую! Сколько у Вас карт на руках?"); // Приветствие, запрос количества карт на руках
            //int b = int.Parse(Console.ReadLine()); // Преобразование введенного числа в целочисленный тип
            //int Points = 0; // Задание нулевого значения суммы карт
            //for (int i = 0; i < b; i++) // Задание цикла для ввода номиналов карт
            //{
            //    Console.WriteLine($"Введите номинал {i + 1}-й карты"); // Запрос ввода номинала i-й карты
            //    switch (Console.ReadLine()) // Задание условия
            //    {
            //        case "2": // Действия при значении карты 2
            //            Points = Points + 2; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "3": // Действия при значении карты 3
            //            Points = Points + 3; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "4": // Действия при значении карты 4
            //            Points = Points + 4; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "5": // Действия при значении карты 5
            //            Points = Points + 5; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "6":  // Действия при значении карты 6
            //            Points = Points + 6; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "7":  // Действия при значении карты 7
            //            Points = Points + 7; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "8":  // Действия при значении карты 8
            //            Points = Points + 8; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "9":  // Действия при значении карты 9
            //            Points = Points + 9; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "10":  // Действия при значении карты 10
            //            Points = Points + 10; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "J":  // Действия при значении карты J
            //            Points = Points + 10; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "Q":  // Действия при значении карты Q
            //            Points = Points + 10; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "K":  // Действия при значении карты K
            //            Points = Points + 10; // Суммирование номиналов карт
            //            break; // Остановка действия
            //        case "T":  // Действия при значении карты T
            //            Points = Points + 10; // Суммирование номиналов карт
            //            break; // Остановка действия

            //    }


            //}
            //Console.WriteLine("Сумма карт: " + Points); // Вывод на экран суммы карт
            //Console.ReadKey(); // Задержка экрана

            //#endregion

            #region Task 3

            while (true) {

                Console.WriteLine("Введите целое число: ");
                double N = double.Parse(Console.ReadLine());
                double j = 2;
                bool res = false;
                while (j < N)
                {

                    if (N % j == 0)
                    {
                        res = false;
                        break;

                    }
                    else
                    {
                        res = true;
                        j++;

                    }
                }
                if (res == true || N == 2)
                {
                    Console.WriteLine("Число является простым");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Число не является простым");
                    Console.ReadKey();
                }
                Console.Clear();
            }
           
            
            #endregion

        }
    }
}
