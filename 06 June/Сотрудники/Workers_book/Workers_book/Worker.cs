using System;

namespace Notebook_structures
{
    class Worker
    {
        //#region Поля

        ///// <summary>
        ///// ID работника
        ///// </summary>
        //private int id;

        ///// <summary>
        ///// ФИО работника
        ///// </summary>
        //private string fullname;

        ///// <summary>
        ///// Дата записи
        ///// </summary>
        //private DateTime date;

        ///// <summary>
        ///// Возраст работника
        ///// </summary>
        //private int age;

        ///// <summary>
        ///// Рост работника
        ///// </summary>
        //private int height;

        ///// <summary>
        ///// Дата рождения работника
        ///// </summary>
        //private DateTime birthdate;

        ///// <summary>
        ///// Место рождения работника
        ///// </summary>
        //private string birthplace;

        //#endregion

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
        public Worker(int ID, string FullName, DateTime Date, int Age, int Height, DateTime BirthDate, string BirthPlace)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.Date = Date;
            this.Age = Age;
            this.Height = Height;
            this.BirthDate = BirthDate;
            this.BirthPlace = BirthPlace;
        }

        #endregion

        #region Свойства
        public int ID
        {
            get;
            set;
        }

        public string FullName
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public DateTime BirthDate
        {
            get;
            set;
        }

        public string BirthPlace
        {
            get;
            set;
        }

        #endregion

        #region Методы
        /// <summary>
        /// Вывод данных о работнике в файл с запятыми
        /// </summary>
        /// <returns>Возвращает строку с данными о работнике, разделенными запятыми</returns>
        public string ToString()
        {
            return $"{ID},{FullName},{Date:d},{Age},{Height},{BirthDate:d},{BirthPlace}";
        }

        /// <summary>
        /// Вывод данных о работнике в консоль без запятых
        /// </summary>
        /// <returns>Возвращает строку с данными о работнике, разделенными пробелами</returns>
        public string ToStringConsole()
        {
            return $"{ID,-7}{FullName,-15}{Date,-15:d}{Age,-7}{Height,-7}{BirthDate,-15:d}{BirthPlace,-20}";
        }
        #endregion
    }

}