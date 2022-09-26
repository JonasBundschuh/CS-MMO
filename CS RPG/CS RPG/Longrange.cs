using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RPG
{
    public class Longrange : Characters
    {
        public Longrange(string name, float healthpoints, string charClass)
        {
            Namen = name;
            HP = healthpoints;
            Class = charClass;
        }
    }
}
