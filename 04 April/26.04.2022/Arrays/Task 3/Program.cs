using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = "yes";

            while (start == "yes")
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 3 + 10, 0);
                Console.WriteLine("ОПЕРАЦИИ НАД МАТРИЦАМИ");
                Console.WriteLine();
                Console.WriteLine("Выберите требуемую операцию:");
                Console.WriteLine("1 - Умножение матрицы на число");
                Console.WriteLine("2 - Сложение матриц");
                Console.WriteLine("3 - Вычитание матриц");
                Console.WriteLine("4 - Умножение матриц");
                Console.WriteLine("5 - Выход");

                int.TryParse(Console.ReadLine(), out int mode);

                if (mode == 1)
                {
                    #region Умножение на число
                    Console.Clear();
                    Console.WriteLine("Введите число строк матрицы:");          // Приглашение ко вводу числа строк матрицы
                    int.TryParse(Console.ReadLine(), out int rows);             // Ввод с клавиатуры числа строк матрицы
                    Console.WriteLine();                                        // Вставка пустой строки (отступ)

                    Console.WriteLine("Введите число столбцов матрицы:");       // Приглашение ко вводу числа столбцов матрицы
                    int.TryParse(Console.ReadLine(), out int columns);          // Ввод с клавиатуры числа столбцов матрицы
                    Console.WriteLine();                                        // Вставка пустой строки (отступ)

                    Console.WriteLine("Введите второй множитель:");             // Приглашение ко вводу множителя матрицы
                    int.TryParse(Console.ReadLine(), out int a);                // Ввод с клавиатуры множителя матрицы

                    Console.WriteLine();                                        // Вставка пустой строки (отступ)
                    Console.WriteLine($"Число строк: {rows}");                  // Вывод на экран числа строк матрицы
                    Console.WriteLine();                                        // Вставка пустой строки (отступ)
                    Console.WriteLine($"Число столбцов: {columns}");            // Вывод на экран числа столбцов матрицы

                    Console.WriteLine();                                        // Вставка пустой строки (отступ)

                    Random random = new Random();                                // Создание генератора псевдослучайных чисел

                    int[,] array = new int[rows, columns];                      // Инициализация исходного массива 

                    int[,] new_array = new int[rows, columns];                  // Инициализация полученного массива


                    for (int i = 0; i < rows; i++)                              // Цикл для заполнения исходного массива
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = random.Next(0, 100);
                        }
                    }

                    Console.Clear();                                            // Очистка экрана

                    Console.WriteLine("Исходная матрица:");                     // Вывод на экран надписи "Исходная матрица:"

                    for (int i = 0; i < rows; i++)                              // Цикл для вывода на экран исходной матрицы
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{array[i, j],5}");
                            Console.Write("  ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Множитель матрицы: {a}");


                    for (int i = 0; i < rows; i++)                              // Цикл для расчета элементов полученной
                                                                                // матрицы
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            new_array[i, j] = array[i, j] * a;
                        }
                    }

                    Console.WriteLine();                                        // Вставка пустой строки (отступ)
                    Console.WriteLine("Полученная матрица:");                   // Вывод на экран надписи "Полученная матрица:"

                    for (int i = 0; i < rows; i++)                                  // Цикл для вывода на экран полученной матрицы
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{new_array[i, j],5}");
                            Console.Write("  ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Перейти к выбору операции? yes/no");
                    start = Console.ReadLine();

                    #endregion
                }

                else if (mode == 2)
                {
                    #region Сложение матриц
                    Console.Clear();
                    Console.WriteLine("Введите число строк первой матрицы");      // Приглашение ко вводу числа строк
                                                                                  // первой матрицы
                    int.TryParse(Console.ReadLine(), out int rows1);              // Ввод с клавиатуры числа строк
                                                                                  // первой матрицы

                    Console.WriteLine("Введите число столбцов первой матрицы");   // Приглашение ко вводу числа стобцов
                                                                                  // первой матрицы
                    int.TryParse(Console.ReadLine(), out int columns1);           // Ввод с клавиатуры числа стобцов
                                                                                  // первой матрицы

                    Console.WriteLine("Введите число строк второй матрицы");      // Приглашение ко вводу числа строк
                                                                                  // второй матрицы
                    int.TryParse(Console.ReadLine(), out int rows2);              // Ввод с клавиатуры числа строк
                                                                                  // второй матрицы

                    Console.WriteLine("Введите число столбцов второй матрицы");   // Приглашение ко вводу числа стобцов
                                                                                  // второй матрицы
                    int.TryParse(Console.ReadLine(), out int columns2);           // Ввод с клавиатуры числа стобцов
                                                                                  // второй матрицы

                    if (rows1 != rows2 | columns1 != columns2)                    // Вывод на экран сообщения о том, что
                        Console.WriteLine                                         // матрицы нельзя сложить/отнять
                            (
                            "Операция невозможна! " +
                            "Матрицы должны быть одинаковой размерности"
                            );

                    else
                    {
                        Console.Clear();

                        Random random = new Random();                                  // Создание генератора псевдослучайных чисел

                        int[,] array1 = new int[rows1, columns1];                     // Инициализация первой матрицы 

                        int[,] array2 = new int[rows2, columns2];                     // Инициализация второй матрицы

                        int[,] new_array = new int[rows2, columns2];

                        Console.WriteLine("Первая матрица:");
                        for (int i = 0; i < rows1; i++)                             // Вывод на экран первой матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                array1[i, j] = random.Next(0, 100);
                                Console.Write($"{array1[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Вторая матрица:");
                        for (int i = 0; i < rows1; i++)                            // Вывод на экран второй матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                array2[i, j] = random.Next(0, 100);
                                Console.Write($"{array2[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Полученная матрица:");

                        for (int i = 0; i < rows1; i++)                                 // Вывод на экран полученной матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                new_array[i, j] = array1[i, j] + array2[i, j];
                                Console.Write($"{new_array[i, j],5}");
                            }
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Перейти к выбору операции? yes/no");
                    start = Console.ReadLine();

                    #endregion
                }

                else if (mode == 3)
                {
                    #region Вычитание матриц
                    Console.Clear();
                    Console.WriteLine("Введите число строк первой матрицы");      // Приглашение ко вводу числа строк
                                                                                  // первой матрицы
                    int.TryParse(Console.ReadLine(), out int rows1);              // Ввод с клавиатуры числа строк
                                                                                  // первой матрицы

                    Console.WriteLine("Введите число столбцов первой матрицы");   // Приглашение ко вводу числа стобцов
                                                                                  // первой матрицы
                    int.TryParse(Console.ReadLine(), out int columns1);           // Ввод с клавиатуры числа стобцов
                                                                                  // первой матрицы

                    Console.WriteLine("Введите число строк второй матрицы");      // Приглашение ко вводу числа строк
                                                                                  // второй матрицы
                    int.TryParse(Console.ReadLine(), out int rows2);              // Ввод с клавиатуры числа строк
                                                                                  // второй матрицы

                    Console.WriteLine("Введите число столбцов второй матрицы");   // Приглашение ко вводу числа стобцов
                                                                                  // второй матрицы
                    int.TryParse(Console.ReadLine(), out int columns2);           // Ввод с клавиатуры числа стобцов
                                                                                  // второй матрицы

                    if (rows1 != rows2 | columns1 != columns2)                    // Вывод на экран сообщения о том, что
                    {
                        Console.Clear();
                        Console.WriteLine                                         // матрицы нельзя сложить/отнять
                            (
                            "Операция невозможна! " +
                            "Матрицы должны быть одинаковой размерности"
                            );
                    }
                    else
                    {
                        Console.Clear();

                        Random random = new Random();                                  // Создание генератора псевдослучайных чисел

                        int[,] array1 = new int[rows1, columns1];                     // Инициализация первой матрицы 

                        int[,] array2 = new int[rows2, columns2];                     // Инициализация второй матрицы

                        int[,] new_array = new int[rows2, columns2];

                        Console.WriteLine("Первая матрица:");
                        for (int i = 0; i < rows1; i++)                             // Вывод на экран первой матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                array1[i, j] = random.Next(0, 100);
                                Console.Write($"{array1[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();

                        Console.WriteLine("Вторая матрица:");
                        for (int i = 0; i < rows1; i++)                            // Вывод на экран второй матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                array2[i, j] = random.Next(0, 100);
                                Console.Write($"{array2[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Полученная матрица:");

                        for (int i = 0; i < rows1; i++)                                 // Вывод на экран полученной матрицы
                        {
                            for (int j = 0; j < columns1; j++)
                            {
                                new_array[i, j] = array1[i, j] - array2[i, j];
                                Console.Write($"{new_array[i, j],5}");
                            }
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Перейти к выбору операции? yes/no");
                    start = Console.ReadLine();

                    #endregion
                }

                else if (mode == 4)
                {
                    #region Умножение матриц
                    Console.Clear();
                    Console.WriteLine("Введите число строк первой матрицы:");
                    int.TryParse(Console.ReadLine(), out int rows1);
                    Console.WriteLine();
                    Console.WriteLine("Введите число стобцов первой матрицы:");
                    int.TryParse(Console.ReadLine(), out int columns1);
                    Console.WriteLine();
                    Console.WriteLine("Введите число строк второй матрицы:");
                    int.TryParse(Console.ReadLine(), out int rows2);
                    Console.WriteLine();
                    Console.WriteLine("Введите число стобцов второй матрицы:");
                    int.TryParse(Console.ReadLine(), out int columns2);

                    if (columns1 != rows2)
                    {
                        Console.Clear();
                        Console.WriteLine("Матрицы не совместимы!");
                    }

                    else
                    {
                        int[,] array1 = new int[rows1, columns1];
                        int[,] array2 = new int[rows2, columns2];
                        Random random = new Random();
                        Console.Clear();
                        Console.WriteLine("Первая матрица:");
                        for (int i = 0; i < rows1; i++)
                        {

                            for (int j = 0; j < columns1; j++)
                            {
                                array1[i, j] = random.Next(0, 100);
                                Console.Write($"{array1[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Вторая матрица:");
                        for (int i = 0; i < rows2; i++)
                        {

                            for (int j = 0; j < columns2; j++)
                            {
                                array2[i, j] = random.Next(0, 100);
                                Console.Write($"{array2[i, j],5}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();

                        Console.WriteLine("Полученная матрица:");
                        int[,] new_array = new int[rows1, columns2];
                        for (int i = 0; i < rows1; i++)
                        {
                            int x = 0;
                            for (int j = 0; j < columns2; j++)
                            {
                                x = 0;
                                for (int k = 0; k < columns1; k++)
                                {
                                    x = x + array1[i, k] * array2[k, j];
                                    new_array[i, j] = x;
                                }
                                Console.Write($"{new_array[i, j],7}");
                            }
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Перейти к выбору операции? yes/no");
                    start = Console.ReadLine();

                    #endregion
                }

                else if (mode == 5) break;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Необходимо выбрать нужную операцию!");
                    Console.WriteLine();
                    Console.WriteLine("Продолжить? yes/no");
                    start = Console.ReadLine();
                }
            }

        }
    }
}
