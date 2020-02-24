using System;

namespace ConsoleApp19
{
    class Student
    {
        private string Name;
        private string Surname;
        private int StartYear;
        private DateTime BirthDate;
        public Student(string n, string s)
        {
            Name = n;
            Surname = s;
        }
        public Student(string n, string s, int sy):this(n,s)
        {
            StartYear = sy;
        }
        public Student(string n,string s,int sy, DateTime b):this(n,s,sy)
        {
            BirthDate = b;
        }
        public void Info()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nStartYear: {StartYear}\nBirthDate: {BirthDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student anvar = new Student("Anvar","Nazarov",2018,Convert.ToDateTime("01-01-2000"));
            anvar.Info();
            Console.ReadLine();
        }
    }
}
