using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1

            int summ = 0;
            Random rand = new Random(); // объявление случайной переменной

            Console.WriteLine("Введите число строк:"); // вывод на экран надписи
            int a = Convert.ToInt32(Console.ReadLine()); // задание числа строк
            Console.WriteLine("Введите число столбцов:"); // вывод на экран надписи
            int b = Convert.ToInt32(Console.ReadLine()); // задание числа столбцов

            int[,] array = new int[a, b]; // объявление массива

            for (int i = 0; i < a; i++) // создание цикла для перебора строк
            {
                for (int j = 0; j < b; j++) // создание цикла для перебора столбцов
                {
                    array[i, j] = rand.Next(100); // присвоение элементу матрицы случайного значения
                    Console.Write($"{array[i, j]} "); // вывод на экран элемента матрицы
                    summ = summ + array[i, j]; // сумма элементов
                }
                Console.WriteLine();
            }

         

            Console.WriteLine(); // пустая строка
            Console.WriteLine($"Сумма равна:{summ}"); // вывод суммы на экран


            Console.ReadKey(); // задержка экрана

            #endregion

            #region Задание 2


            //Console.WriteLine("Введите длину диапазона"); // приглашение ко вводу
            //uint a = Convert.ToUInt32(Console.ReadLine()); // задание длины массива

            //int[] array = new int[a]; // объявление массива

            //for (uint i = 0; i < a; i++) // запуск цикла опроса пользователя
            //{
            //    Console.WriteLine($"Введите {i + 1}-е число массива: "); // приглашение ко вводу
            //    array[i] = Convert.ToInt32(Console.ReadLine()); // присвоение значения элементу массива

            //}

            //int min = array[0]; // считаем первый элемент массива минимальным

            //for (uint j = 1; j < a; j++) // запускаем цикл поиска минимального 
            //{

            //    if (array[j] < min) // условие присвоения значения элемента массива минимальному значению
            //    {
            //        min = array[j]; // присвоение значения элемента массива минимальному значению
            //    }

            //}

            //Console.WriteLine($"Минимальный элемент массива: {min}"); // вывод на экран минимального значения

            //for (uint k = 0; k < a; k++) // запуск цикла вывода на экран элементов массива
            //{
            //    Console.Write($"{array[k]} "); // вывод на экран элемента массива
            //}

            //Console.ReadKey(); // задержка экрана

            #endregion

            #region Задание 3

            //Console.WriteLine("Введите длину диапазона"); // приглашение ко вводу
            //int a = Convert.ToInt32(Console.ReadLine()); // задание длины массива

            //int[] array = new int[a]; // объявление массива
            //Random rand=new Random(); // объявление случайной переменной
            //int goal = rand.Next(0, a); // загаданное числа
            //while (true) // задание цикла
            //{

            //    Console.WriteLine("Какое число загадано?"); // приглашение ко вводу версии
            //    string inputstr=Console.ReadLine(); // считывания введенной строки

            //    if (inputstr == "") // условие проверки на пустую строку
            //    {

            //        Console.WriteLine($"Игра закончилась! Загаданное число: {goal}"); // окончание игры
            //                                                                           // в случае пустой строки 
            //        break; // завершение цикла

            //    }

            //    else // блок операторов, в случае непустой строки
            //    {
            //int input = Convert.ToInt32(inputstr); // парс строки в число
            //if (input == goal) // если введенное значение сопадает с загаданным
            //{
            //    Console.WriteLine("Вы угадали число!"); // вывод на экран информации о победе
            //    break; // завершение цикла

            //}
            //else if (input > goal) // если введенное значение больше загаданного
            //{

            //    Console.WriteLine("Загаданное число меньше, попробуйте еще раз"); // вывод на экран информации
            //                                                                      // о том, что загаданное число
            //                                                                      // меньше

            //}

            //else if (input < goal) // если введенное значение меньше загаданного
            //{

            //    Console.WriteLine("Загаданное число больше, попробуйте еще раз"); // вывод на экран информации
            //                                                                     // о том, что загаданное число
            //                                                                             // больше

            //        }


            //    }
            //}

            //Console.ReadKey(); // задержка экрана

            #endregion
        }
    }
}
