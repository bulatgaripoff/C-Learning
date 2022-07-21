using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_oldd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // * Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            //#region Двухпользовательская игра


            //Random randomize=new Random();
            //Console.WriteLine("Игрок 1, введите свой никнейм");
            //string Player1=Console.ReadLine();
            //Console.WriteLine("Игрок 2, введите свой никнейм");
            //string Player2=Console.ReadLine();

            //int gameNumber = randomize.Next(12, 121);
            //int order = randomize.Next(1, 3);

            //Console.WriteLine($"Число: {gameNumber}");

            //void GameInput(string CurrentPlayer) 
            //{
            //    Console.Write($"Ход {CurrentPlayer} : ");
            //    int InputNumber;

            //    while (true) 
            //    {
            //        InputNumber = int.Parse(Console.ReadLine());
            //        if (InputNumber<5 && InputNumber > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Нельзя! Попробуй еще раз, тупица!");
            //        }
            //    }

            //    gameNumber -= InputNumber;

            //    Console.WriteLine($"Число: {gameNumber}");

            //    if (gameNumber == 0)
            //    {
            //        Console.WriteLine($"Победил {CurrentPlayer}");
            //        Console.ReadKey();
            //    }

            //    if (gameNumber < 0)
            //    {
            //        Console.WriteLine("Ничья!");
            //        Console.ReadKey();
            //    }
            //} 

            //while (gameNumber >0)
            //{
            //    GameInput(order == 1 ? Player1 : Player2);
            //    order = order == 1 ? 0 : 1;
            //}

            //#endregion

            #region Хард

            Console.WriteLine("Сыграем в игру? yes/no");        // предложение сыграть в игру
            string game = Console.ReadLine().ToLower();         // ввод с клавиатуры согласия сыграть
           
            while (game=="yes")                                 // создание бесконечного цикла
            {
                Console.Clear();                                // очистка экрана
                Random randomize = new Random();                // создание генератора псевдослучайных чисел
                int gameNumber = randomize.Next(12, 121);       // задание диапазона случайно загаданного числа
                Console.WriteLine("Введите число игроков:");    // приглашение ко вводу числа игроков
                int quantity = int.Parse(Console.ReadLine());   // ввод с клавиатуры числа игроков
                
                
                
                bool Siglepayer = false;
                if (quantity == 1) 
                {
                    quantity=2;
                    Siglepayer=true;
                }                             // условие для числа игроков 2 и более
                
                string[] names = new string[quantity];      // создание массива с именами игроко
                    for (int i = 0; i < quantity; i++)          // создание цикла ввода имен игроков
                    {
                        Console.WriteLine($"\nИгрок {i + 1}, введите имя: ");   // приглашение ко вводу имени игрока
                        names[i] = Console.ReadLine();          // ввод с клавиатуры имени игрока
                        if (Siglepayer) 
                            {
                                names[1]="Компик";        
                                break;
                            }
                    }

                    Console.WriteLine("\nВведите максимальный шаг игрока: ");   // приглашение ко вводу макс шага игры
                    int step = int.Parse(Console.ReadLine());   // ввод с клавиатуры шага игры
                    int order = randomize.Next(0, quantity);    // определение игрока, который делает первый ход

                    Console.WriteLine($"\nЗагаданное число: {gameNumber}"); // вывод на экран загаданного числа
                    Console.WriteLine($"\nНачинает {names[order]}");        // вывод на экран имени первого игрока

                    void GameInput(string CurrentPlayer)        // создание метода игры
                    {
                        Console.Write($"\nХод {CurrentPlayer}: "); // вывод на экран имени активного игрока
                        int InputNumber;                        // объявление переменной для вводимого числа

                    if (CurrentPlayer == "Компик")
                    { 
                               
                                InputNumber = randomize.Next(1, step + 1); // определение хода компьютера
                                Console.WriteLine($"{InputNumber}"); // вывод на экран хода компьютера
                                gameNumber -= InputNumber;              // вычисление нового целевого числа
                                Console.WriteLine($"Число: {gameNumber}"); // вывод на экран нового целевого числа
                                return;                      // выход из цикла
                    }
                        while (true)                            // создание бесконечного цикла для ввода числа с учетом
                                                                // границы шага
                        {
                            InputNumber = int.Parse(Console.ReadLine()); // ввод с клавиатуры хода игрока
                            if (InputNumber < step + 1 && InputNumber > 0) // проверка введенного числа на нахождение 
                                                                           // в границах допустимого диапазона
                            {
                                break;                          // выход из цикла проверки введенного числа
                            }
                            else                                // условие, при котором число выходит за допустимые
                                                                // границы
                            {
                                Console.WriteLine("\nНельзя! Попробуй еще раз, тупица!"); // вывод на экран предложения
                                                                                          // ввести число заново
                            }
                        }

                        gameNumber -= InputNumber;              // вычисление нового целевого числа

                        Console.WriteLine($"Число: {gameNumber}"); // вывод на экран нового целевого числа

                        if (gameNumber == 0)                    // условие проверки числа на равенство нулю
                        {
                            Console.WriteLine($"\nПобедил {CurrentPlayer}!"); // вывод на экран победителя
                        }

                        if (gameNumber < 0)                     // условие проверки числа на положительность
                                                                // (если число отрицательно - ничья)
                        {
                            Console.WriteLine("\nНичья!");      // вывод на экран информации о ничьей
                        } 
                    }

                    while (gameNumber > 0)                      // создание бесконечного цикла для вызова методы игры
                    {
                        GameInput(names[order]);                // вызов метода игры
                        order = order + 1;                      // переход хода следующему игроку
                        if (order == quantity) order = 0;       // переход хода к первому игроку по окончании круга
                    }
                
                /*else                                            // блок команд в случае однопользовательской игры
                {
                    string[] names = new string[2];             // создание массива имен игроков
                    Console.WriteLine("Введите своё имя: ");    // приглашение ввести имя игрока
                    names[0]=Console.ReadLine();                // ввод с клавиатуры имени игрока
                    names[1] = "Искусственный интеллект";       // задание имени компьютера

                    Console.WriteLine("\nВведите максимальный шаг игрока: ");   // приглашение ко вводу
                                                                                // максимального шага игры
                    int step = int.Parse(Console.ReadLine());   // ввод с клавиатуры шага игры
                    int order = randomize.Next(0, quantity+1);  // определение первого игрока

                    Console.WriteLine($"\nЗагаданное число: {gameNumber}"); // вывод на экран загаданного числа
                    Console.WriteLine($"\nНачинает {names[order]}");    // вывод на экран имени игрока, который
                                                                        // делает первый ход

                    void GameInput(string CurrentPlayer)        // вызов метода игры
                    {
                        Console.Write($"\nХод {CurrentPlayer}: ");  // вывод на экран игрока, который делает ход
                        int InputNumber=0;                      // задание нулевого значение вводимого числа

                        while (true)                            // создание бесконечного цикла для ввода числа с
                                                                // учетом границы шага
                        {
                            if (order == 0)                     // блок команд в случае, если первым ходит
                                                                // пользователь
                            {
                                    InputNumber = int.Parse(Console.ReadLine());    // ввод с клавиатуры хода
                                                                                    // игрока

                                    if (InputNumber < step + 1 && InputNumber > 0) // проверка введенного числа
                                                                                   // на нахождение в заданных
                                                                                   // границах
                                    {
                                        break;                  // остановка проверки
                                    }
                                else                        // условие, при котором число выходит за допустимые
                                                            // границы
                                {
                                        Console.WriteLine
                                        (
                                            "\nНельзя! Попробуй еще раз, тупица!" // вывод на экран предложения
                                                                                  // ввести число заново
                                        ); 
                                }

                            }
                            else                            // блок команд в случае, если первым ходит
                                                            // компьютер
                            {
                                InputNumber = randomize.Next(1, step + 1); // определение хода компьютера
                                Console.WriteLine($"{InputNumber}"); // вывод на экран хода компьютера
                                break;                      // выход из цикла
                            }

                        }
                        gameNumber -= InputNumber;          // уменьшение загаданного числа на ход игрока
                        Console.WriteLine($"Число: {gameNumber}"); // вывод на экран нового числа

                        if (gameNumber == 0)                  // условие проверки числа на положительность
                                                              // (если число отрицательно - ничья)
                        {
                            Console.WriteLine($"\nПобедил {CurrentPlayer}!"); // вывод на экран информации
                                                                              // о победителе
                        }

                        if (gameNumber < 0)                   // условие проверки числа на положительность
                                                              // (если число отрицательно - ничья)
                        {
                            Console.WriteLine("\nНичья!");    // вывод на экран информации о ничьей
                        }
                    }

                    while (gameNumber > 0)                    // создание бесконечного цикла для вызова методы игры
                    {
                        GameInput(order == 0 ? names[0] : names[1]); // вызов метода игры

                        order = order == 0 ? 1 : 0;           // смена хода
                    }

                }
                */
                Console.WriteLine("\nСыграем еще раз? (yes/no)"); // приглашение сыграть новую игру
                game=Console.ReadLine();                      // ввод с клавиатуры ответа пользователя
                                
            }
            #endregion
        }
    }
}
