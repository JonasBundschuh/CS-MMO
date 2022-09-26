using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RPG
{
    public class Healer : Characters
    {

        public Healer(string name, float HealthPoints, string charClass)
        {
            Namen = name;
            HP = HealthPoints;
            Class = charClass;
        }
    }
}
