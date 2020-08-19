using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //This variab;e is used to store health
            float health = 100.0f;
            //This variable is used to heal the player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int maxLevel = 120;
            int damage = 15;
            int level = 10;
            int mana = 100;
            bool ready = true;
            string role = "none";

            //Prints opening message
            Console.WriteLine("What gender are you?");
            Console.WriteLine("Press 1 for boy");
            Console.WriteLine("Press 2 for girl");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("\nIt's a boy! What should we name him?");
            }
            else if (input == '2')
            {
                Console.WriteLine("\nIt's a girl! What should we name her?");
            }
            string name = Console.ReadLine();

            //Asks the player to select their path in life
            Console.WriteLine("You were born in local town on the edge of the kingdom.");
            Console.WriteLine("Your father is a royal guard who wanted a quiet life. Your mother is the king and queen's daughter and the town's preistess.");
            Console.WriteLine("Some time has passed and it is time to decide your path to follow in life");
            Console.WriteLine("Press 1 for Knight");
            Console.WriteLine("Press 2 for Mage");
            Console.WriteLine("Press 3 for Devotee");
            //Gets input from the console
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = 210;
                role = "Knight";
                Console.WriteLine("\nYou chose to follow in your father's footsteps and protect your grandparents and your kingdom.");
            }
            else if (input == '2')
            {
                damage = 30;
                mana = 200;
                role = "Mage";
                Console.WriteLine("\nYou chose to dwell deep within knowledge to understand the world of magic and mana.");
            }
            else if (input == '3')
            {
                health = 150;
                damage = 7;
                mana = 150;
                role = "Preist";
                Console.WriteLine("\nYou chose to follow in your mother's fotsteps and devoted yourself to the church in service of others.");
            }
            else if (input == '4')
            {
                health = 150;
                damage = 7;
                mana = 150;
                role = "Preistess";
                Console.WriteLine("\nYou chose to follow in your mother's fotsteps and devoted yourself to the church in service of others.");
            }
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Mana: " + mana);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Your grandfather has called for an audience with you. He demands that it's urgent.");
            Console.WriteLine("He says that your mother and father have gone missing and he wants you to look for them.");
            Console.WriteLine("He also mentions that they were last seen in the forest near your home.");

            Console.WriteLine("So you head home to begin your search");
            Console.WriteLine("Press 1 to search your house");
            Console.WriteLine("Press 2 to the search the forest");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("\nYou head inside only to find that the house is completely normal, but you do notice that your father's weapon and armor is missing.");
                Console.WriteLine("You immedentially rush into the forest thinking something terrible has happened.");
            }
            else if(input == '2')
            {
                Console.WriteLine("\nYou begin walking into the forest looking for any signs of your parents.");
            }
            Console.WriteLine("You continue on into the forest until you notice slash marks on a few trees.");
        }
    }
}
