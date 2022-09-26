using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RPG
{
    internal class Tank : Characters
    {

        public Tank(string name, float HealthPoints, string charClass)
        {
            Namen = name;
            HP = HealthPoints;
            Class = charClass;

        }

        public override void Attacke()
        {
            Console.WriteLine($"");
        }


    }

  
}
