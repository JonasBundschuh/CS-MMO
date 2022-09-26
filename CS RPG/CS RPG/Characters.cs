using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RPG
{
    public abstract class Characters
    {
        public string Namen { get; set; }
        public float HP { get; set; }
        public string Class { get; set; }

        //int default_hp = 500;

        public void PrintTank()
        {
            Console.WriteLine($"The Character {this.GetType().Name} is called {Namen} and has {HP} HP. He is from the Class {Class}!");
        }

        public void PrintHealer()
        {
            Console.Write($"The character {this.GetType().Name} is called {Namen} and has {HP} HP. He is from the class {Class}!");
        }

        public void PrintLongRange()
        {
            Console.WriteLine($"The character {this.GetType().Name} is called {Namen} nad has {HP} HP. She is from the class {Class}!");


        }

        public abstract void Attacke();
    }

    
}
