using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization, int skippedDays = 0) : base (name, age, gender)
        {
            PreviousOrganization = previousOrganization;
            SkippedDays = skippedDays;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
