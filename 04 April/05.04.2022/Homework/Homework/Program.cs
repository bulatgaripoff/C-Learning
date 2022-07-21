using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string FullName = "Гарипов Б.И."; // Инициализация переменной ФИО
            int Age = 27; // Инициализация переменной Возраст
            string Email = "garipov@yandex.ru"; // Инициализация переменной Email
            float PointsPr = 10; // Инициализация переменной Баллы по программированию
            float PointsM = 8; // Инициализация переменной Баллы по математике
            float PointsPh = 7; // Инициализация переменной Баллы по физике

            
            #region Task 1
            // Форматированный вывод в столбец данных
            Console.WriteLine($"Ф.И.О.: {FullName}" +
                $"\nВозраст: {Age}" +
                $"\nE'mail: {Email}" +
                $"\nБаллы по программированию: {PointsPr}" +
                $"\nБаллы по математике: {PointsM}" +
                $"\nБаллы по физике: {PointsPh}");


            #endregion

            #region Task 2
            float Summ = PointsPr + PointsM + PointsPh; // Расчет суммы баллов
            double Avrg = Summ / 3; // Расчет среднего балла
      
            Console.WriteLine($"Сумма баллов: {Summ} \nСредний балл: {Avrg:0.0}",
                Summ,
                Avrg);
            Console.ReadKey();

            #endregion



        }
    }
}
