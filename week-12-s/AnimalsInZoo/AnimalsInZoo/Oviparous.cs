using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsInZoo
{
    class Oviparous : Animal
    {
        private string Baby = "egg";

        protected override string Reproduction()
        {
            return $"{Baby}";
        }
    }
}
