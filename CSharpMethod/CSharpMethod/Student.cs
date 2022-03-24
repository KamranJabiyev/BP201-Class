using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethod
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;

        //constructor - 
        public Student():this("Ibrahim","Isgenderov")
        {
            
            Console.WriteLine("Student created");
        }

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name,string surname,int age):this(name,surname)
        {
            Age = age;
        }
        public void Detail()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
