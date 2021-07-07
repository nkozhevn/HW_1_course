using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    abstract class Person
    {
        protected static int id { get; set; }
        public string Name { get; set; }
        protected DateTime Date { get; set; }
        public int Age { get; set; }
        public Person(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
            this.Age = DateTime.Today.Subtract(Date).Days / 365;
        }
        public Person()
        {

        }
        public static int Id()
        {
            return id += 1;
        }
        public abstract void Print();
        public abstract void Payment();
        public abstract void Seniority();
        public abstract void ChangePayment();
    }
}