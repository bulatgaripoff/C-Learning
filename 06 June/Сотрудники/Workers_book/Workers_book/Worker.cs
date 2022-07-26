using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Notebook_structures
{
    class Worker
    {
        #region Поля

        /// <summary>
        /// ID работника
        /// </summary>
        private int id;

        /// <summary>
        /// ФИО работника
        /// </summary>
        private string fullname;

        /// <summary>
        /// Дата записи
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Возраст работника
        /// </summary>
        private int age;

        /// <summary>
        /// Рост работника
        /// </summary>
        private int height;

        /// <summary>
        /// Дата рождения работника
        /// </summary>
        private DateTime birthdate;

        /// <summary>
        /// Место рождения работника
        /// </summary>
        private string birthplace;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="fullname">ФИО</param>
        /// <param name="date">Дата записи</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="birthdate">Дата рождения</param>
        /// <param name="birthplace">Место рождения</param>
        public Worker(int id, string fullname, DateTime date, int age, int height, DateTime birthdate, string birthplace)
        {
            this.id = id;
            this.fullname = fullname;
            this.date = date;
            this.age = age;
            this.height = height;
            this.birthdate = birthdate;
            this.birthplace = birthplace;
        }

        #endregion

        #region Свойства
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string FullName
        {
            get { return this.fullname; }
            set { this.fullname = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }

        public string BirthPlace
        {
            get { return this.birthplace; }
            set { this.birthplace = value; }
        }

        #endregion

        #region Методы
        //public string PrintConsole()
        //{
        //    return $"{ID,5} {FullName,16} {Date,12:d} {Age,8} {Height,6} {BirthDate,15:d} {BirthPlace,16}";
        //}

        //public string PrintFile()
        //{
        //    return $"{ID},{FullName},{Date:d},{Age},{Height},{BirthDate:d},{BirthPlace}";
        //}

        /// <summary>
        /// Вывод данных о работнике в файл
        /// </summary>
        /// <returns></returns>
        public new string ToStringFile()
        {
            return $"{ID},{FullName},{Date:d},{Age},{Height},{BirthDate:d},{BirthPlace}";
        }

        /// <summary>
        /// Вывод данных о работнике в консоль
        /// </summary>
        /// <returns></returns>
        public new string ToStringConsole()
        {
            return $"{ID,-7}{FullName,-15}{Date,-15:d}{Age,-7}{Height,-7}{BirthDate,-15:d}{BirthPlace,-20}";
        }
        #endregion
    }

}