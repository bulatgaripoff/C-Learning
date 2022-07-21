using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1_old
{

    internal class Program
    {
        /// <summary>
        /// Метод вывода матрицы
        /// </summary>
        /// <param name="Matrix">Имя матрицы</param>
        static void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="InputMatrix"></param>
        /// <param name="Number"></param>
        static int[,] NumberMulti(int[,] InputMatrix, int Number)
        {
            Console.WriteLine("\nРезультат операции:");
            int[,] OutputMatrix = InputMatrix;
            for (int i = 0; i < InputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < InputMatrix.GetLength(1); j++)
                {
                    OutputMatrix[i, j] = InputMatrix[i, j] * Number;
                }
            }
            return OutputMatrix;
        }

        /// <summary>
        /// Заполнение матрицы случайными числами
        /// </summary>
        /// <param name="Rows"></param>
        /// <param name="Columns"></param>
        /// <param name="Num"></param>
        /// <param name="random"></param>
        /// <returns>Возвращает матрицу, заполненную случайными числами из диапазона</returns>
        static int[,] FillMatrix(int Num, ref Random random)
        {
            Console.Clear();
            Console.WriteLine($"Введите число строк {Num}-й матрицы:");
            int.TryParse(Console.ReadLine(), out int Rows);
            Console.WriteLine("Введите число столбцов матрицы:");
            int.TryParse(Console.ReadLine(), out int Columns);
            int[,] OutputMatrix = new int[Rows, Columns];
                for (int i = 0; i < OutputMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < OutputMatrix.GetLength(1); j++)
                    {
                        OutputMatrix[i, j] = random.Next(0, 50);
                    }
                }
                return OutputMatrix;
        }

        /// <summary>
        /// Сложение матриц
        /// </summary>
        /// <param name="Matrix1"></param>
        /// <param name="Matrix2"></param>
        /// <returns>Возвращает полученную матрицу</returns>
        static int[,] MatrixSum(int[,] Matrix1, int[,] Matrix2)
        {
            int[,] Output = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
            if (Matrix1.GetLength(0) != Matrix2.GetLength(0))
            {
                if (Matrix1.GetLength(1) != Matrix2.GetLength(1))
                {
                    Console.WriteLine("\nНельзя выполнить операцию! Матрицы не одинакового размера.");
                }
                return Output;
            }
            else
            {
                Console.WriteLine("\nРезультат операции:");
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    { Output[i, j] = Matrix1[i, j] + Matrix2[i, j]; }
                }
                return Output;
            }
        }

        static int[,] MatrixMulti(int[,] Matrix1, int[,] Matrix2)
        {
            int[,] Output = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
            if (Matrix1.GetLength(1) != Matrix2.GetLength(0))
            {
                Console.WriteLine("Матрицы не совместимы!");
                return Output;
            }
            else
            {
                Console.WriteLine("\nРезультат операции:");
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    int x;
                    for (int j = 0; j < Matrix2.GetLength(1); j++)
                    {
                        x = 0;
                        for (int k = 0; k < Matrix1.GetLength(1); k++)
                        {
                            x = x + Matrix1[i, k] * Matrix2[k, j];
                            Output[i, j] = x;
                        }
                    }
                }
                return Output;
            }
        }
        static void Main(string[] args)
        {
            #region Задание
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение
            #endregion

            Random random = new Random();
        Menu:
            Console.Clear();
            Console.WriteLine("Операции над матрицами.\n\nВыберите действие:\n" +
                "1-Умножение матрицы на число\n2-Сложение/вычитание матриц\n3-Умножение матриц\n0-Выход\n");
            int.TryParse(Console.ReadLine(), out int Mode);
            switch (Mode)
            {
                // Умножение матрицы на число
                case 1:
                    Console.Clear();                                    // Чистка экрана
                    int[,] Input=FillMatrix(1, ref random);             // Заполнение матрицы случайными числами
                    Console.WriteLine("Введите множитель матрицы:");    // Предложение о вводе множителя матрицы
                    int.TryParse(Console.ReadLine(), out int x);        // Ввод с клавиатуры множителя матрицы

                    Console.Clear();                                    // Чистка экрана
                    Console.WriteLine("Исходная матрица:");             // Вывод надписи "Исходная матрица"
                    PrintMatrix(Input);                                 // Вывод на экран исходной матрицы
                    Console.WriteLine($"\nМножитель матрицы: {x}");     // Вывод надписи "Множитель матрицы"
                    PrintMatrix(NumberMulti(Input, x));                 // Вывод на экран полученной матрицы
                    Console.WriteLine("\n\n\nВыйти в меню?: y/n");      // Предложение выйти в меню
                    if (Console.ReadLine() == "y") goto Menu;           // Условие перехода в главное меню
                    break;

                // Сложение/вычитание матриц
                case 2:
                    Console.Clear();                                                    // Чистка экрана
                    Console.WriteLine("Выберите операцию: +/-");                        // Вывод надписи "Выберите операцю"
                    string oper = Console.ReadLine();                                   // Ввод с клавиатуры типа операции
                    int[,] Input1 = FillMatrix(1, ref random);                          // Заполнение матрицы 1 случайными числами
                    int[,] Input2 = FillMatrix(2, ref random);                          // Заполнение матрицы 2 случайными числами

                    Console.Clear();                                                    // Чистка экрана
                    Console.WriteLine("Первая матрица:");                               // Вывод на экран надписи "Первая матрица"
                    PrintMatrix(Input1);                                                // Вывод на экран матрицы 1
                    Console.WriteLine("\nВторая матрица:");                             // Вывод на экрна надписи "Вторая матрица"
                    PrintMatrix(Input2);                                                // Вывод на экран матрицы 2
                    if (oper == "+") PrintMatrix(MatrixSum(Input1, Input2));            // Сложение матриц
                    else PrintMatrix(MatrixSum(Input1, NumberMulti(Input2, -1)));       // Вычитание матриц
                    Console.WriteLine("\n\n\nВыйти в меню?: y/n");                      // Предложение выйти в меню
                    if (Console.ReadLine() == "y") goto Menu;                           // Условие перехода в главное меню
                    break;

                // Умножение матриц
                case 3:
                    Console.Clear();                                    // Чистка экрана
                    int[,] Input3 = FillMatrix(1, ref random);          // Заполнение матрицы 1 случайными числами
                    int[,] Input4 = FillMatrix(2, ref random);          // Заполнение матрицы 2 случайными числами

                    Console.Clear();                                    // Чистка экрана
                    Console.WriteLine("Первая матрица:");               // Вывод на экран надписи "Первая матрица"
                    PrintMatrix(Input3);                                // Вывод на экран матрицы 1
                    Console.WriteLine("\nВторая матрица:");             // Вывод на экран надписи "Вторая матрица"
                    PrintMatrix(Input4);                                // Вывод на экран матрицы 2
                    PrintMatrix(MatrixMulti(Input3, Input4));           // Умножение матриц
                    Console.WriteLine("\n\n\nВыйти в меню?: y/n");      // Предложение выйти в меню
                    if (Console.ReadLine() == "y") goto Menu;           // Условие перехода в главное меню
                    break;

                case 0:
                    Console.Clear();                                    // Чистка экрана
                    break;                                              // Выход
            }
        }
    }
}

