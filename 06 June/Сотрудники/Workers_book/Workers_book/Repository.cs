using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Notebook_structures
{
    class Repository
    {
        /// <summary>
        /// Лист работников
        /// </summary>
        private List<Worker> workers = new List<Worker>();

        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string path;

        /// <summary>
        /// Массив с дефолтными заголовками
        /// </summary>
        private string[] titles = {"ID", "ФИО", "Дата записи", "Возраст", "Рост", "Дата рождения", "Место рождения"};

        /// <summary>
        /// Конструктор репозитория
        /// </summary>
        public Repository(string Path)
        {
           path = Path;
        }

        /// <summary>
        /// Метод для добавления нового работника из файла
        /// </summary>
        /// <param name="ConcreteWorker"></param>
        public void Add_from_file(Worker ConcreteWorker)
        {
            this.workers.Add(ConcreteWorker);
        }

        /// <summary>
        /// Метод для добавления нового работника вручную
        /// </summary>
        public void Add()
        {
            int id = workers.Count+1;
            DateTime Date=DateTime.Now;
            Console.WriteLine("Формат ввода: ФИО, возраст, рост, дата рождения, место рождения");
            string[] args = Console.ReadLine().Split(',');

            #region Обход исключений
            try
            {
                Convert.ToInt32(args[1]);
            }
            catch (FormatException)
            {
                args[1] = "0";
            }

            try
            {
                Convert.ToInt32(args[2]);
            }
            catch (FormatException)
            {
                args[2] = "0";
            }

            try
            {
                Convert.ToDateTime(args[3]);
            }
            catch (FormatException)
            {
                args[3] = "01.01.1900";
            }

            #endregion

            Worker New = new Worker(id, args[0], Date, Convert.ToInt32(args[1]), Convert.ToInt32(args[2]), Convert.ToDateTime(args[3]), args[4]);
            this.workers.Add(New);
        }

        /// <summary>
        /// Метод для удаления работника по ID
        /// </summary>
        public void Remove()
        {
            Console.WriteLine("Введите ID работника, которого необходимо удалить:");
            int.TryParse(Console.ReadLine(), out int id);
            int to_delete = workers.FindIndex(item => item.ID==id);
            workers.RemoveAt(to_delete);
        }

        /// <summary>
        /// Метод для загрузки записей из файла
        /// </summary>
        public void Load()
        {
            if (File.Exists(path))
            {
                using (StreamReader ContentStream = new StreamReader(this.path))
                {
                    while (!ContentStream.EndOfStream)
                    {
                        string[] args = ContentStream.ReadLine().Split(',');
                        Add_from_file(new Worker(Convert.ToInt32(args[0]), args[1], Convert.ToDateTime(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToDateTime(args[5]), args[6]));
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл отсутствует!");
            }
        }

        /// <summary>
        /// Методы для вывода в консоль заголовков
        /// </summary>
        public void PrintTitles() // поправить - вынести в массив форматирование
        {
            for (int i=0; i<titles.Length; i++)
            {
                if (i==0 || i==3 || i==4)
                {
                    Console.Write($"{titles[i],-5} ");
                }    
                else if (i==6)
                    Console.Write($"{titles[i],-17} ");
                else
                    Console.Write($"{titles[i],-14} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод для вывода записей в консоль
        /// </summary>
        public void PrintToConsole()
        {
            if (workers.Capacity!=0)
            {
                foreach (Worker worker in workers)
                {
                    Console.WriteLine(worker.ToStringConsole());
                }
            }
            else Console.WriteLine("Записи отсутствуют!");   
        }

        /// <summary>
        /// Метод для записи в файл
        /// </summary>
        public void FileSave()
        {
            using (StreamWriter WritingStream = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (Worker worker in workers)
                {
                    WritingStream.WriteLine(worker.ToString());
                }
            }
        }

        /// <summary>
        /// Метод сортировки списка
        /// </summary>
        public void Sort() // переделать метод
        {
            Console.WriteLine("Выберите поле для сортировки: 1 - по ID; 2 - по имени; 3 - по дате добавления; 4 - по возрасту; " +
                "\n5 - по росту; 6 - по дате рождения; 7 - по месту рождения");
            string Mode = Console.ReadLine();
            switch (Mode)
            {
                case "1":
                    var orderedworkers1 = from worker in workers orderby worker.ID select worker;
                    foreach (Worker worker in orderedworkers1)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "2":
                    var orderedworkers2 = from worker in workers orderby worker.FullName select worker;
                    foreach (Worker worker in orderedworkers2)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "3":
                    var orderedworkers3 = from worker in workers orderby worker.Date select worker;
                    foreach (Worker worker in orderedworkers3)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "4":
                    var orderedworkers4 = from worker in workers orderby worker.Age select worker;
                    foreach (Worker worker in orderedworkers4)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "5":
                    var orderedworkers5 = from worker in workers orderby worker.Height select worker;
                    foreach (Worker worker in orderedworkers5)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "6":
                    var orderedworkers6 = from worker in workers orderby worker.BirthDate select worker;
                    foreach (Worker worker in orderedworkers6)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
                case "7":
                    var orderedworkers7 = from worker in workers orderby worker.BirthPlace select worker;
                    foreach (Worker worker in orderedworkers7)
                        Console.WriteLine(worker.ToStringConsole());
                    break;
            }
                
        }

        /// <summary>
        /// Свойство для вызова числа записей в репозитории
        /// </summary>
        public int Count { get { return workers.Count; } }

    }
}

