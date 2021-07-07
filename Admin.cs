using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class Admin : Person, IEmployee
    { 
        public int Lab { get; set; }
        public int WHours { get; set; }
        public int PPHour { get; set; }
        public DateTime DBeg { get; set; }
        public Admin(string name, DateTime date, int lab, int whours, int pphour, DateTime dbeg) : base(name, date)
        {
            this.Lab = lab;
            this.WHours = whours;
            this.PPHour = pphour;
            this.DBeg = dbeg;
        }
        public Admin()
        {

        }
        public Admin(string name, DateTime date, int lab) : base(name, date)
        {
            this.Lab = lab;
        }
        public override string ToString()
        {
            string tx = String.Format("\nАдминистратор:\nФамилия: {0}\nДата рождения: {1}\nВозраст: {2}\nЛаборатория: {3}\nid: {4}", Name, Date, Age, Lab, Id());
            return tx;
        }
        override public void Print()
        {
            Console.WriteLine(this);
        }
        override public void Payment()
        {
            int payment = 22 * WHours * PPHour;
            string tx = String.Format("\nЗаработная плата администратора: {0}", payment);
            Console.WriteLine(tx);
        }
        override public void Seniority()
        {
            int seniority = DateTime.Today.Subtract(DBeg).Days / 365;
            string tx = String.Format("\nСтаж работы администратора: {0}", seniority);
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