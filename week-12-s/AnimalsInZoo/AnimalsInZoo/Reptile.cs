using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Reptile : Oviparous
    {
        public Reptile(string name, string order, string animalClass = "reptile")
        {
            Name = name;
            Order = order;
            AnimalClass = animalClass;
        }
    }
}
