using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class Animal
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Animal() // default constructor
        {
            name = "The animal with no name";
        }

        public Animal(string newName)
        {
            name = newName;
        }
        public void Feed()
        {
            Console.WriteLine("{0} hase been fed.", name);
        }
    }
}
