﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создайте прототип информационной системы для организации.

// Организация состоит из департаментов. В департаментах работают сотрудники. Помимо этого,
// каждый департамент содержит вложенные департаменты, в которых
// также работают сотрудники, и так далее. Уровень вложенности департаментов не ограничен,
// однако каждый отдельно взятый департамент может содержать
// только до миллиона сотрудников.

// Пользователь информационной системы может добавлять, удалять и редактировать департаменты.
// пунктов меню.

// Все данные организации можно сохранить на диск в форматах JSON или XML.



// Что оценивается
// Создана структура для департамента.
// Создана структура для сотрудника.
// Департамент обладает как минимум следующими полями:
// Наименование.
// Дата создания.
// Количество сотрудников.
// Сотрудник обладает как минимум следующими полями:
// Фамилия.
// Имя.
// Возраст.
// Департамент, в котором он работает.
// Идентификатор.
// Размер заработной платы.
// Сотрудников и департаменты можно добавлять, удалять и редактировать.
// Производится сортировка по произвольному полю.
// Реализовано меню.

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Department dep = new Department("jsdfkjdsfj");
            Console.ReadKey();

        }
    }
}