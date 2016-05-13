using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Chicken : Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid a egg.", name);
        }
        public Chicken(string newName) : base(newName)
        {

        }
    }
}