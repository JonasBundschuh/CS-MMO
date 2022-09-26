using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to start the game? (y/n) ");
            string startGame = Console.ReadLine();

            if (startGame == "y")
            {
                Console.Clear();
            }
            else
            {
                Console.ReadKey();
            }

            Console.WriteLine("Which Character would you like to choose? ");
            Console.WriteLine("[1] = Tank");
            Console.WriteLine("[2] = Healer");
            Console.WriteLine("[3] = Longrange fighter");
            int chosen_character = Convert.ToInt32(Console.ReadLine());

            


            List<Characters> character = new List<Characters>();
            
            
            if (chosen_character == 1)
            {
                character.Add(new Tank("Ferdinand", 500, "Tank"));
                Console.Clear();
                foreach (Characters characters in character)
                {

                    characters.PrintTank();
                    
                }
            }
            else if (chosen_character == 2)
            {
                character.Add(new Healer("Maestro", 300, "Healer"));
                Console.Clear();
                foreach (Characters characters in character)
                {

                    characters.PrintHealer();
                }
            }
            else if(chosen_character == 3)
            {
                character.Add(new Longrange("Lesley", 250, "Long Range Attacker"));
                    Console.Clear();
                foreach (Characters characters in character)
                {
                    characters.PrintLongRange();
                }
            }
            //character.Add(new Tank("Ferdinand", 500, "Tank"));
            //character.Add(new Healer("Maestro", 300, "Healer"));

            

            

            Console.ReadLine();

        }
    }
}
