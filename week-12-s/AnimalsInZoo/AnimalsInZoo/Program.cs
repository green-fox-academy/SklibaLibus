using System;

namespace AnimalsInZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var franco = new Reptile("Franco", "crocodile");
            var vivian = new Mammal("Vivian", "koala");
            var loira = new Bird("Loira", "parrot");
            var amalia = new Reptile("Amalia", "turtle");
            var garry = new Mammal("Garry", "dolphin");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(franco.GetNameOrderAndAnimalClass() + franco.WantChild());
            Console.WriteLine(vivian.GetNameOrderAndAnimalClass() + vivian.WantChild());
            Console.WriteLine(loira.GetNameOrderAndAnimalClass() + loira.WantChild());
            Console.WriteLine(amalia.GetNameOrderAndAnimalClass() + amalia.WantChild());
            Console.WriteLine(garry.GetNameOrderAndAnimalClass() + garry.WantChild());
        }
    }
}
