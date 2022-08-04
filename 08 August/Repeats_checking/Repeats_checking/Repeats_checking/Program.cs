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
        static void Main(string[] args)
        {
            
            int menu = 1;
            string path = @"numbers.txt";

            do
            {
                Console.WriteLine("1 - просмотр чисел");
                Console.WriteLine("2 - добавить число");
                Console.WriteLine("3 - выход");

                HashSet<int> Numbers_collection = new HashSet<int>();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        using (StreamReader ContentStream = new StreamReader(path))
                        {
                            while (!ContentStream.EndOfStream)
                            {
                                string[] Numbers_string = ContentStream.ReadLine().Split(',');
                                int[] Numbers = new int[Numbers_string.Length];
                                for (int i = 0; i < Numbers_string.Length; i++)
                                {
                                    Numbers[i]=int.Parse(Numbers_string[i]);
                                    Numbers_collection.Add(int.Parse(Numbers_string[i]));
                                }
                            }
                            foreach (int num in Numbers_collection)
                            {
                                Console.Write($"{num} ");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введите число:");
                        int.TryParse(Console.ReadLine(), out int Number);
                        int number = Number;
                        if (Numbers_collection.Contains(number)==true)
                            Console.WriteLine("Коллекция уже содержит данное число!");
                        else
                        {
                            Numbers_collection.Add(number);
                            Console.WriteLine("Число успешно добавлено в коллекцию!");
                        }

                        using (StreamWriter WritingStream = new StreamWriter(path, true, Encoding.UTF8))
                        {
                            foreach (int num in Numbers_collection)
                            {
                                WritingStream.Write($",{num}");
                            }
                        }
                        break;

                    case "3":
                        menu=0;
                        break;
                }
            } while (menu!=0);
        }
    }
}
