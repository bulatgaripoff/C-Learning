using System;

// Сотрудник обладает как минимум следующими полями:
// Фамилия.
// Имя.
// Возраст.
// Департамент, в котором он работает.
// Идентификатор.
// Размер заработной платы.

namespace Notebook
{
    class Worker
    {
        public Worker(string LastName, string FirstName, int Age, string Department, int ID, int Salary)
        {
            this.LastName = LastName;
            this.FirstName=FirstName;
            this.Age=Age;
            this.Department=Department;
            this.ID=ID;
            this.Salary=Salary;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }

    }
}
