using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
     Улучшите программу, которую разработали в модуле 6. Создайте структуру «Сотрудник» со следующими полями:
    ID
    Дата и время добавления записи
    Ф.И.О.
    Возраст
    Рост
    Дата рождения
    Место рождения
    Для записей реализуйте следующие функции:
    • Просмотр записи. Функция должна содержать параметр ID записи, которую необходимо вывести на экран. 
    • Создание записи.
    • Удаление записи.
    • Редактирование записи.
    • Загрузка записей в выбранном диапазоне дат.
    • Сортировка по возрастанию и убыванию даты.
     */

namespace Notebook_structures
{

    internal class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 4, 0);
            Console.WriteLine("Сотрудники организации");
            Console.WriteLine("1 - Чтение файла");
            string path = @"notebook.txt";
            Repository notebook = new Repository(path);
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    notebook.Load();

                    DateTime date1;
                    DateTime date2;

                    try
                    {
                        Console.WriteLine("Введите начальное значение диапазона дат. Для вывода всех записей нажмите Enter:");
                        date1=Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (FormatException) { date1=new DateTime(1900, 1, 1); }

                    try
                    {
                        Console.WriteLine("Введите конечное значение диапазона дат. Для вывода всех записей нажмите Enter:");
                        date2=Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (FormatException) { date2=new DateTime(3000, 1, 1); }


                    notebook.PrintTitles();
                    notebook.PrintToConsole(date1, date2);
                    Console.WriteLine($"\nВсего записей: {notebook.Count}\n");

                    int menu2 = 1;  // для внутреннего меню
                    do
                    {
                        Console.WriteLine("1 - Добавить новую запись");
                        Console.WriteLine("2 - Записать в файл");
                        Console.WriteLine("3 - Удалить работника");
                        Console.WriteLine("4 - Сортировка");
                        Console.WriteLine("5 - Выход");

                        switch (Console.ReadLine()) // добавить дефолт
                        {
                            case "1":
                                notebook.Add();
                                Console.Clear();
                                notebook.PrintTitles();
                                notebook.PrintToConsole(date1, date2);
                                Console.WriteLine($"\nВсего записей: {notebook.Count}\n");
                                break;
                            case "2":
                                notebook.FileSave();
                                Console.WriteLine("Запись успешно внесена в файл!");
                                break;
                            case "3":
                                notebook.Remove();
                                Console.WriteLine("Запись успешно удалена!");
                                notebook.PrintTitles();
                                notebook.PrintToConsole(date1, date2);
                                Console.WriteLine($"\nВсего записей: {notebook.Count}\n");
                                break;
                            case "4":
                                notebook.SortByDate();
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

        static void Main(string[] args)
        {
            while (true) // убрать меню из классов, меню сделать отдельным
            {
                Menu();
                
            }
        }
    }
}

