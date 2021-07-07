using System;
using System.Collections.Generic;
using System.Linq;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Admin a1 = new Admin("Иванов", new DateTime(1990, 01, 01), 1, 6, 200, new DateTime(2015, 05, 05));
            Student s1 = new Student("Кожевников", new DateTime(2000, 09, 23), "ИКТ", 3122);
            Teacher t1 = new Teacher("Петров", new DateTime(1970, 02, 02), "ИКТ", "Профессор математики", 25, 8, 300);
            Manager m1 = new Manager("Сидоров", new DateTime(1980, 03, 03), "ИКТ", "Менеджер по студенческой работе", 8, 200, new DateTime(2005, 04, 04));
            Admin a2 = new Admin("Пупкин", new DateTime(1990, 01, 01), 1, 6, 200, new DateTime(2015, 05, 05));
            Student s2 = new Student("Еремин", new DateTime(2000, 01, 04), "ИКТ", 3222);
            Teacher t2 = new Teacher("Осипов", new DateTime(1985, 05, 15), "ИКТ", "Доцент", 10, 8, 1000);
            Manager m2 = new Manager("Жульенов", new DateTime(1488, 06, 06), "ИКТ", "Менеджер по некромантии", 8, 10000, new DateTime(1666, 06, 06));
            list.Add(a1);
            list.Add(m1);
            list.Add(t1);
            list.Add(s1);
            list.Add(a2);
            list.Add(m2);
            list.Add(t2);
            list.Add(s2);
            bool exit = false;
            do
            {
                try
                {
                    Console.WriteLine("\n\tУчебный центр\n1 - Список персонала и студентов\n2 - Узнать з/п человека\n3 - Узнать стаж человека\n4 - Поиск персон по возрасту\n5 - Изменить зарплату сотрудника\n6 - Выход ");
                    int Action = int.Parse(Console.ReadLine());
                    switch (Action)
                    {
                        case 1:
                            Console.WriteLine("\tСписок персонала и студентов");
                            foreach (Person rb in list)
                            {
                                rb.Print();
                            }
                            break;
                        case 2:
                            Console.Write("\n\tЗаработная плата\nВведите id человека: ");
                            int x = int.Parse(Console.ReadLine());
                            list.ElementAt(x - 1).Payment();
                            break;
                        case 3:
                            Console.Write("\n\tСтаж работы\nВведите id человека: ");
                            int y = int.Parse(Console.ReadLine());
                            list.ElementAt(y - 1).Seniority();
                            break;
                        case 4:
                            Console.Write("\n\tПоиск людей\nВведите промежуток возраста:\nОт: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("До: ");
                            int b = int.Parse(Console.ReadLine());
                            foreach (Person p in list)
                            {
                                if (p.Age >= a && p.Age <= b)
                                { 
                                    p.Print(); 
                                }
                            }
                            break;
                        case 5:
                            Console.Write("\n\tИзменение зарплаты\nВведите id сотрудника: ");
                            int c = int.Parse(Console.ReadLine());
                            list.ElementAt(c - 1).ChangePayment();
                            break;
                        case 6:
                            exit = true;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенно некоректное значение");
                }
            } while (exit == false);
        }
    }
}