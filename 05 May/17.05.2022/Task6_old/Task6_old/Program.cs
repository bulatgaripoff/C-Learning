using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;


namespace Task6_old
{
    internal class Program
    {
      

        /// <summary>
        /// Вывод на экран группы из чисел между степенями двойки. Для групп 2 и более
        /// </summary>
        /// <param name="GroupNum">Номер группы</param>
        /// <param name="Max">Максимальное число из множества чисел</param>
        static void GroupConsole (int GroupNum, double Max)
        {
            Console.Write($"Группа {GroupNum + 1}:");       // Вывод на экран Названия группы
            Console.Write($" {Math.Pow(2, GroupNum)}");     // Вывод на экран первого числа группы
            int number=(int)Math.Pow(2, GroupNum)+1;        // Определение первого числа группы
            while (number<(int)Math.Pow(2, GroupNum+1))     // Цикл для вывода чисел группы
                {
                Console.Write($" {number}");
                number++;
                }
            Console.WriteLine();
        }

        /// <summary>
        /// Запись в файл группы из чисел между степенями двойки. Для групп 2 и более
        /// </summary>
        /// <param name="GroupNum">Номер группы</param>
        /// <param name="Max">Максимальное число из множества чисел</param>
        static void GroupFile(int GroupNum, double Max)
        {
            
            using (StreamWriter sw = new StreamWriter(@".\Groups\Groups.txt", true, Encoding.UTF8))   // Создаем поток
            {
                sw.Write($"Группа {GroupNum + 1}:");                // Запись названия группы
                sw.Write($" {Math.Pow(2, GroupNum)}");              // Запись первого числа группы 
                int number = (int)Math.Pow(2, GroupNum) + 1;        // Определение первого числа группы
                while (number < (int)Math.Pow(2, GroupNum + 1))     // Цикл для записи чисел группы
                {
                    sw.Write($" {number}");
                    number++;
                }
                sw.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Вывод на экран меню
            Console.WriteLine("Выберите команду:");         
            Console.WriteLine("1 - Расчет числа групп");
            Console.WriteLine("2 - Запись групп на экран");
            Console.WriteLine("3 - Запись групп в файл");

            // Считывание с клавиатуры команды
            int.TryParse(Console.ReadLine(), out int mode);

            // Чистка экрана
            Console.Clear();

            // Приглашение ввести максимальное значение множества чисел
            Console.WriteLine("Введите максимальное число:");

            // Считывание с клавиатуры максимального значения множества чисел
            double.TryParse(Console.ReadLine(), out double N);

            // Определение количества групп чисел
            double pow = Math.Log(N, 2);
            int GroupsNumber = (int)Math.Truncate(pow);

            // Блок условий для различных режимов
            switch (mode)
            {
                
                // Блок вывода на экран числа групп
                case 1:                                                 
                    DateTime date1 = DateTime.Now;
                    Console.WriteLine($"Число групп:{GroupsNumber+1}");
                    TimeSpan timeSpan1 = DateTime.Now.Subtract(date1);
                    Console.WriteLine($"\nВремя расчета: {timeSpan1.ToString()}");
                    break;
                
                // Блок вывода на экран групп чисел
                case 2: 
                    DateTime date2 = DateTime.Now;
                    for (int i=0; i<GroupsNumber; i++)
                    {
                        GroupConsole(i, N);
                    }
                    Console.Write($"Группа {GroupsNumber+1}:");
                    for (int i=(int)Math.Pow((double)2, (double)(GroupsNumber)); 
                        i<N+1; i++)
                    {
                        Console.Write($" {i}");
                    }
                    TimeSpan timeSpan2 = DateTime.Now.Subtract(date2);
                    Console.WriteLine($"\nВремя вывода: {timeSpan2.ToString()}");
                    break;
                
                // Блок записи в файл групп чисел
                case 3:
                    Directory.CreateDirectory(@".\Groups");
                    DateTime date3 = DateTime.Now;
                    using (StreamWriter sw = new StreamWriter(@".\Groups\Groups.txt", false, Encoding.UTF8));

                    for (int i = 0; i < GroupsNumber; i++)
                        {
                            GroupFile(i, N);
                        }
                        
                    using (StreamWriter sw = new StreamWriter(@".\Groups\Groups.txt", true, Encoding.UTF8))
                    {
                        sw.Write($"Группа {GroupsNumber + 1}:");
                        for (int i = (int)Math.Pow((double)2, (double)(GroupsNumber));
                            i < N + 1; i++)
                        {
                            sw.Write($" {i}");
                        }
                    }
                Console.WriteLine("Запись успешно завершена!");                 // Вывод на экран информации
                                                                                // о завершении записи
                TimeSpan timeSpan3 = DateTime.Now.Subtract(date3);              // Определение времени записи
                Console.WriteLine($"\nВремя записи: {timeSpan3.ToString()}");   // Вывод на экран времени
                                                                                // записи

                    Console.WriteLine("Записать результат в архив?");
                    Console.WriteLine("1 - Да; 2 - Нет");
                    int.TryParse(Console.ReadLine(), out int T);

                    switch (T)
                    {
                        case 1:

                            
                            // Удаляет имеющийся архив в папке с результатом архив
                            if (System.IO.File.Exists(@".\Groups\Groups.zip"))
                            {
                                try
                                {
                                    System.IO.File.Delete(@".\Groups\Groups.zip");
                                }
                                catch (System.IO.IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                    return;
                                }
                            }

                            using (ZipFile zip = new ZipFile()) // Создаем объект для работы с архивом
                            {
                                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // MAX степень сжатия
                                zip.AddDirectory(@".\Groups"); // Кладем в архив папку вместе с содержимым
                                zip.Save(@".\Groups\Groups.zip");  // Создаем архив  
                            }

                            DirectoryInfo di = new DirectoryInfo(@".\Groups");
                            foreach (FileInfo f in di.GetFiles()) Console.WriteLine("Размер {0} - {1} байт", f.Name, f.Length);
                            Console.WriteLine("Нажмите Enter для выхода");
                            break;
                        case 2:
                            Console.WriteLine("Нажмите Enter для выхода");
                            break;
                    }
                        
                    break;

            }

            Console.ReadKey();
            
        }
    }
}
