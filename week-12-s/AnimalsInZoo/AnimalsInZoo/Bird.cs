using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Bird : Oviparous
    {
        public Bird(string name, string order, string animalClass = "bird")
        {
            Name = name;
            Order = order;
            AnimalClass = animalClass;
        }
    }
}
