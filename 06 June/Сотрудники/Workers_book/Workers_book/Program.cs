using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Notebook_structures
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 4, 0);
                Console.WriteLine("Сотрудники организации");
                Console.WriteLine("1 - Чтение файла");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        string path = @"notebook.txt";
                        Repository notebook = new Repository(path);
                        notebook.Load();
                        notebook.PrintTitles();
                        notebook.PrintToConsole();
                        Console.WriteLine($"\nВсего записей: {notebook.Count}\n");

                        int menu2 = 1;  // для внутреннего меню
                        do
                            {
                                Console.WriteLine("1 - Добавить новую запись");
                                Console.WriteLine("2 - Записать в файл");
                                Console.WriteLine("3 - Удалить работника");
                                Console.WriteLine("4 - Сортировка");
                                Console.WriteLine("5 - Выход");

                            switch (Console.ReadLine())
                                {
                                    case "1":
                                        notebook.Add();
                                        Console.Clear();
                                        notebook.PrintToConsole();
                                        Console.WriteLine($"\nВсего записей: {notebook.Count}\n");
                                        break;
                                    case "2":
                                        notebook.FileSave();
                                        Console.WriteLine("Запись успешно внесена в файл!");
                                        break;
                                    case "3":
                                        notebook.Remove();
                                        Console.WriteLine("Запись успешно удалена!");
                                        notebook.PrintToConsole();
                                        Console.WriteLine($"\nВсего записей: {notebook.Count}\n");
                                        break;
                                    case "4":
                                        notebook.Sort();
                                        Console.WriteLine($"\nВсего записей: {notebook.Count}\n");
                                        break;
                                case "5":
                                        menu2 = 3;
                                        break;
                                }
                            }
                            while (menu2!=3);
                            break;
                        }

                }
            }
        }
    }

