using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class Teacher : Person, IEmployee
    {
        public string Fac { get; set; }
        public string Post { get; set; }
        public int Senior { get; set; }
        public int WHours { get; set; }
        public int PPHour { get; set; }
        public Teacher(string name, DateTime date, string fac, string post, int senior, int whours, int pphour) : base(name, date)
        {
            this.Fac = fac;
            this.Post = post;
            this.Senior = senior;
            this.WHours = whours;
            this.PPHour = pphour;
        }
        public Teacher()
        {

        }
        public Teacher(string name, DateTime date, string fac, string post, int seniority) : base(name, date)
        {
            this.Fac = fac;
            this.Post = post;
            this.Senior = seniority;
        }
        public override string ToString()
        {
            string tx = String.Format("\nПреподаватель:\nФамилия: {0}\nДата рождения: {1}\nВозраст: {2}\nФакультет: {3}\nДолжность: {4}\nСтаж: {5}\nid: {6}", Name, Date, Age, Fac, Post, Senior, Id());
            return tx;
        }
        override public void Print()
        {
            Console.WriteLine(this);
        }
        override public void Payment()
        {
            int payment = 22 * WHours * PPHour;
            string tx = String.Format("\nЗаработная плата преподавателя: {0}", payment);
            Console.WriteLine(tx);
        }
        override public void Seniority()
        {
            string tx = String.Format("\nСтаж работы менеджера: {0}", Senior);
            Console.WriteLine(tx);
        }
        override public void ChangePayment()
        {
            Console.WriteLine("\nВведите новую зарплату в час:");
            int p = int.Parse(Console.ReadLine());
            this.PPHour = p;
            Console.WriteLine("\nЗарплата изменена");
        }
    }
}
