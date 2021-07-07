using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class Student : Person
    {
        public string Fac { get; set; }
        public int Group { get; set; }
        public Student(string name, DateTime date, string fac, int group) : base(name, date)
        {
            this.Fac = fac;
            this.Group = group;
        }
        public Student()
        {

        }
        public override string ToString()
        {
            string tx = String.Format("\nСтудент:\nФамилия: {0}\nДата рождения: {1}\nВозраст: {2}\nФакультет: {3}\nГруппа: {4}\nid: {5}", Name, Date, Age, Fac, Group, Id());
            return tx;
        }
        override public void Print()
        {
            Console.WriteLine(this);
        }
        override public void Payment()
        {
            Console.WriteLine("\nУ студента нет зарплаты");
        }
        override public void Seniority()
        {
            Console.WriteLine("\nУ студента нет стажа работы");
        }
        public override void ChangePayment()
        {
            throw new NotSupportedException();
        }
    }
}
