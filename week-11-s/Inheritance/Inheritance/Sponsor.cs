using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor(string name, int age, string gender, string company, int hiredStudents = 0) : base(name, age, gender)
        {
            Company = company;
            HiredStudents = hiredStudents;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            HiredStudents ++;
        }
    }
}
