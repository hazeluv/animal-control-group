using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Trash Panda", Age = 2, Description = "Like a panda, but a lot smaller" },
            new Animal { Id = 2, Name = "Rocket", Age = 1, Description = "Slim build, but packs a hell of a punch" },
            new Animal { Id = 3, Name = "Sky Racoon", Age =1, Description = "A night-crawler, and lover of shiny things" },
        };
    }
}
