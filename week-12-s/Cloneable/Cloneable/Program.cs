using System;
using System.Collections.Generic;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", 20, "male", "BME", 8);
            Student jane = new Student("Jane Nondoe", 25, "female", "Microsoft");
            Student student = new Student();

            jane.Introduce();

            Student JohnTheClone = (Student) john.Clone();
            JohnTheClone.Introduce();

            Student Clone = (Student) student.Clone();
            Clone.Introduce();
        }
    }
}
