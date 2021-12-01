using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll.
    public class HumanPlayer : Player
    {
        int numberForRoll { get; set; }


        public override void Play(Player other)
        {

            Console.WriteLine("Enter a number between 1 to 6");

            numberForRoll = int.Parse(Console.ReadLine());

            int myRoll = Roll();
            int otherRoll = other.Roll();


            Console.WriteLine($"{Name} rolls a {numberForRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");

            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}