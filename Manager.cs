using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class Manager : Person, IEmployee
    {
        public string Fac { get; set; }
        public string Post { get; set; }
        public int WHours { get; set; }
        public int PPHour { get; set; }
        public DateTime DBeg { get; set; }
        public Manager(string name, DateTime date, string fac, string post, int whours, int pphour, DateTime dbeg) : base(name, date)
        {
            this.Fac = fac;
            this.Post = post;
            this.WHours = whours;
            this.PPHour = pphour;
            this.DBeg = dbeg;
        }
        public Manager()
        {

        }
        public Manager(string name, DateTime date, string fac, string post) : base(name, date)
        {
            this.Fac = fac;
            this.Post = post;
        }
        public override string ToString()
        {
            string tx = String.Format("\nМенеджер:\nФамилия: {0}\nДата рождения: {1}\nВозраст: {2}\nФакультет: {3}\nДолжность: {4}\nid: {5}", Name, Date, Age, Fac, Post, Id());
            return tx;
        }
        override public void Print()
        {
            Console.WriteLine(this);
        }
        override public void Payment()
        {
            int payment = 22 * WHours * PPHour;
            string tx = String.Format("\nЗаработная плата менеджера: {0}", payment);
            Console.WriteLine(tx);
        }
        override public void Seniority()
        {
            int seniority = DateTime.Today.Subtract(DBeg).Days / 365;
            string tx = String.Format("\nСтаж работы менеджера: {0}", seniority);
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
