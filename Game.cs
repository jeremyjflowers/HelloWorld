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
            Console.WriteLine("Press 3 for Preist");
            Console.WriteLine("Press 4 for Preistess");
            //Gets input from the console
            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                if(input == '1')
                {
                    health = 200;
                    damage = 20;
                    role = "Knight";
                    Console.WriteLine("\nYou chose to follow in your father's footsteps in order to protect your kingdom.");
                }
                else if(input == '2')
                {
                    health = 150;
                    mana = 200;
                    role = "Mage";
                    Console.WriteLine("\nYou chose to dwell within the knowledge of the arcane arts.");
                }
                else if(input == '3')
                {
                    health = 150;
                    damage = 10;
                    mana = 150;
                    role = "Preist";
                    Console.WriteLine("\nYou chose to follow in your mother's footsteps and devote your time in service of others.");
                }
                else if(input == '4')
                {
                    health = 150;
                    damage = 10;
                    mana = 150;
                    role = "Preistess";
                    Console.WriteLine("\nYou chose to follow in your mother's footsteps and devote your time in service of others.");
                }
                else
                {
                    health = 50;
                    damage = 4;
                    mana = 0;
                    level = 5;
                    role = "Peasant";
                    Console.WriteLine("\nYou decided that simple life suits you better, despite your parents' pleads.");
                    break;
                }
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
            Console.WriteLine("You investigate the marks and realize they are sword slashes");
            Console.WriteLine("You follow the slash marks until you find an opening.");
            Console.WriteLine("As you approach the center, you notice two bodies laying on the ground and another pinned to a tree with what looks like a sword");

            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("Press 1 to check the body on the tree");
            Console.WriteLine("Press 2 to check on the bodies on the ground");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("\nYou cautiously approach what appears to be a orc upon a closer look.");
                Console.WriteLine("You determine that it has been dead for a while based on how lifeless its eyes are.");
                Console.WriteLine("Then you decide to turn your attention to the bodies on the ground.");
                Console.WriteLine("You approach the bodies on the ground and immediately recognize them.");
                Console.WriteLine("It's your parents and they're both injured, but alive.");
                Console.WriteLine("You then proceed to wake them up. Both of them begin to stir, but your father comes to first.");
                Console.WriteLine("He asks you how long have they been unconscious. You tell him ");
                string answer = Console.ReadLine();
                Console.WriteLine("That long, huh? Well, I'm glad you found us. Your mother went into the forest for ingredents for dinner and I accompanied her.");
                Console.WriteLine("Then we were attacked by that orc over there.");
                Console.WriteLine("Your mother and I fought until I pinned it against the tree and collapsed out of exhaustion soon after.");
                Console.WriteLine("Didn't think we'd be unconscious for that long though");
            }
            else if(input == '2')
            {
                Console.WriteLine("\nYou approach the bodies on the ground and immediately recognize them.");
                Console.WriteLine("It's your parents and they're both injured, but alive.");
                Console.WriteLine("You then proceed to wake them up. Both of them begin to stir, but your father comes to first.");
                Console.WriteLine("He asks you how long have they been unconscious. You tell him ");
                string answer = Console.ReadLine();
                Console.WriteLine("That long, huh? Well, I'm glad you found us. Your mother went into the forest for ingredents for dinner and I accompanied her.");
                Console.WriteLine("Then we were attacked by that orc over there. He points to the orc pinned to the tree");
                Console.WriteLine("Your mother and I fought that thing and collapsed afterwards. Still, didn't think we'd be unconscious for that long");
            }
            Console.WriteLine("Your father gathers his sword and picks up your mother while you gather her belongings.");
            Console.WriteLine("You both arrive at home safely. Your father puts your mother to bed and removes his gear. You place your mother's belongings on the kitchen table.");
            Console.WriteLine("He congratulates you on finding them both before something dangerous happened.");
        }
    }
}
