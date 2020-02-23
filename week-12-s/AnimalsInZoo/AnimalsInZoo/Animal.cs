using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        protected string Order { get; set; }
        protected string AnimalClass { get; set; }
        protected string Food { get; set; }
        protected int Age { get; set; }

        public virtual string GetNameOrderAndAnimalClass()
        {
            return $"{Name} is {Order} from {AnimalClass} animal class ";
        }

        protected abstract string Reproduction();

        public string WantChild()
        {
            return $"and want a child from {Reproduction()}!";
        }
    }
}
