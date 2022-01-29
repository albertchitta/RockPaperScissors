using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class AllMethods
    {
        public static void Question()
        {
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
        }

        public static void PlayHand(int hand)
        {
            if (hand == 1)
            {
                Console.WriteLine($@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
            }
            else if (hand == 2)
            {
                Console.WriteLine($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
            }
            else if (hand == 3)
            {
                Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
            }
            else
            {
                Console.WriteLine("Please Enter 1, 2, or 3.\n");
            }
        }
    }
}
