using System;
using System.Collections.Generic;

// Департамент обладает как минимум следующими полями:
// Наименование.
// Дата создания.
// Количество сотрудников.


namespace Notebook
{
    class Department
    {
        public Department(string Name)
        {
            this.Name = Name;
            this.CreationDate = DateTime.Now;
            this.StaffNumber= StaffNumber;
            this.Squad=Squad;
            this.Structure=Structure;
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int StaffNumber { get; set; }
        public List<Worker> Squad { get; set; }
        public List<Department> Structure { get; set; }

        public void AddWorker(string LastName, string FirstName, int Age, string Department, int ID, int Salary)
        {
            
            Worker temp1 = new Worker(LastName, FirstName, Age, Department, ID, Salary);
            Squad.Add(temp1);

        }

    }
}
