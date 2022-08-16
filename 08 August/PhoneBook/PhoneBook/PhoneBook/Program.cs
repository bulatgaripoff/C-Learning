using System;
using System.Collections.Generic;

namespace PhoneBook
{
    // Что нужно сделать
    // Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев.
    // В процессе ввода информация размещается в Dictionary, где ключом является номер телефона,
    // а значением — ФИО владельца.Таким образом, у одного владельца может быть несколько номеров телефонов.
    // Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
    // Далее программа предлагает найти владельца по введенному номеру телефона.Пользователь вводит номер
    // телефона и ему выдаётся ФИО владельца.Если владельца по такому номеру телефона не зарегистрировано,
    // программа выводит на экран соответствующее сообщение.


    // Совет
    // Для того, чтобы находить значение в Dictionary, нужно использовать TryGetValue.



    // Что оценивается
    // Программа разделена на логические методы.
    // Для хранения элементов записной книжки используется Dictionary.

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Ввести запись; 2-Поиск абонента");
                
                string menu_selector = Console.ReadLine();
                switch (menu_selector)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Введите номер абонента:");
                        string key = Console.ReadLine();
                        Console.WriteLine("Введите ФИО абонента:");
                        string value = Console.ReadLine();
                        PhoneBook.Add(key, value);
                        // ввести проверки
                        int menu2 = 1;

                        do // убрать вложенное меню
                        {
                            Console.WriteLine("1 - Добавить новую запись");
                            Console.WriteLine("2 - Выход в главное меню");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.WriteLine("Введите номер абонента:");
                                    string new_key = Console.ReadLine();
                                    Console.WriteLine("Введите ФИО абонента:");
                                    string new_value = Console.ReadLine();
                                    PhoneBook.Add(new_key, new_value);
                                    break;
                                case "2":
                                    menu2=2;
                                    break;
                            }
                        }
                        while (menu2!=2);
                        break;
                    
                    case "2":
                        Console.WriteLine("Введите номер абонента:");
                        string search_key = Console.ReadLine();
                        bool exist_number = PhoneBook.ContainsKey(search_key);
                        if (exist_number==true)
                        {
                            Console.WriteLine(PhoneBook[search_key]);
                        }
                        else Console.WriteLine("Такой номер отсутствует!");
                        // сделать с помощью TryGetValue
                        int menu3 = 1;

                        do
                        {
                            Console.WriteLine("1 - Поиск нового абонента");
                            Console.WriteLine("2 - Выход в главное меню");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.WriteLine("Введите номер абонента:");
                                    string new_search_key = Console.ReadLine();
                                    bool new_exist_number = PhoneBook.ContainsKey(search_key);
                                    if (new_exist_number==true)
                                    {
                                        Console.WriteLine(PhoneBook[new_search_key]);
                                    }
                                    else Console.WriteLine("Такой номер отсутствует!");
                                    break;
                                case "2":
                                    menu3=2;
                                    break;
                            }
                        }
                        while (menu3!=2);

                        break;

                }

            }    

        }
    }
}
