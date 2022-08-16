using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Что нужно сделать
// Пользователь вводит число. Число сохраняется в HashSet коллекцию.
// Если такое число уже присутствует в коллекции, то пользователю на экран
// выводится сообщение, что число уже вводилось ранее. Если числа нет, то
// появляется сообщение о том, что число успешно сохранено. 

// Советы и рекомендации
// Для добавление числа в HashSet используйте метод Add. 

// Что оценивается
// В программе в качестве коллекции используется HashSet.

namespace Repeats_checking
{
    internal class Program
    {
        /// <summary>
        /// Загрузка коллекции из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Коллекция чисел</returns>
        static HashSet<int> Load(string path)
        {
            HashSet<int> HashCollection = new HashSet<int>();
            using (StreamReader sr = new StreamReader(path))
            {
                //while (!sr.EndOfStream)
                //{
                    string[] string_num = sr.ReadLine().Split(',');
                    //int[] int_num = new int[string_num.Length];
                    for (int i = 0; i < string_num.Length; i++)
                    {
                        //int_num[i]=int.Parse(string_num[i]);
                        HashCollection.Add(int.Parse(string_num[i]));
                    }
                //}
            }

            return HashCollection;
        }

        /// <summary>
        /// Выводит на экран коллекцию чисел
        /// </summary>
        /// <param name="HashCollection">Коллекция чисел</param>
        static void PrintHash(HashSet<int> HashCollection)
        {
            foreach (int num in HashCollection)
            {
                Console.Write($"{num} ");
            }
        }

        /// <summary>
        /// Добавляет в коллекцию новое число
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="HashCollection">Коллекция чисел</param>
        static void AddHash(string path, HashSet<int> HashCollection) // поправить название
        {
            Console.WriteLine("Введите число:");
            int.TryParse(Console.ReadLine(), out int Number);
            int number = Number;
            bool flag = HashCollection.Add(number);

            if (flag) Console.WriteLine("Число успешно добавлено в коллекцию!");

            else Console.WriteLine("Коллекция уже содержит данное число!");


            using (StreamWriter WritingStream = new StreamWriter(path, true, Encoding.UTF8)) // сделать в отдельный метод
            {
                foreach (int num in HashCollection)
                {
                    WritingStream.Write($",{num}");
                }
            }
        }

        static void Main(string[] args)
        {
            
            int menu = 1;
            string path = @"numbers.txt";

            do
            {
                Console.WriteLine("1 - просмотр чисел");
                Console.WriteLine("2 - добавить число");
                Console.WriteLine("3 - выход");
                
                HashSet<int> Numbers_collection = Load(path);

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintHash(Numbers_collection);
                        Console.WriteLine();
                        break;

                    case "2":
                        AddHash(path, Numbers_collection);
                        break;

                    case "3":
                        menu=0;
                        break;
                }
            } while (menu!=0);
        }
    }
}
