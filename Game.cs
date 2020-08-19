using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("It's a baby boy! What should we name him?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to the world! You do great things in the world, my son! What would you like to be when you come of age?");
            string role = Console.ReadLine();
            //This variab;e is used to store health
            float health = 100.0f;
            //This variable is used to heal the player
            float healthRegen = 20;
            bool maxLevelReached = false;
            int maxLevel = 120;
            int level = 10;
            bool ready = true;
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);

        }
    }
}
