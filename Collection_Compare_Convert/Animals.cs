using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Animals : CollectionBase
    {
        // implement the method (Add and Remove) of ICollection
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }

        public Animals()
        { }

        // indexer -- same with property in form
        public Animal this[int animalIndex]
        {
            get
            {
                return (Animal)List[animalIndex];
            }
            set
            {
                List[animalIndex] = value;
            }
        }
    }
}
