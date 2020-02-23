using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Mammal : Animal
    {
        public Mammal(string name, string order, string animalClass = "mammal")
        {
            Name = name;
            Order = order;
            AnimalClass = animalClass;
        }

        private string Baby = "uterus";

        protected override string Reproduction()
        {
            return $"{Baby}";
        }
    }
}
