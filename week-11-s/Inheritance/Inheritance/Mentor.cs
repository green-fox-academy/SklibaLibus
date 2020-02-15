using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
    }
}
