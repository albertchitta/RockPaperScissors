// See https://aka.ms/new-console-template for more information
using static RockPaperScissors.Model.AllMethods;

var playerInput = "y";
var num = "";
int playerHand = 0;
bool success = false;

int playerScore = 0;
int computerScore = 0;

while ((playerScore != 3 || computerScore != 3) && (playerInput == "y" ||playerInput == "Y"))
{
    Console.WriteLine($@"------------------------------
    | Player: {playerScore}  |  Computer: {computerScore}  |
    ------------------------------
    ");

    while (!success)
    {
        Question();
        num = Console.ReadLine();
        success = (int.TryParse(num, out playerHand) && (playerHand < 4 && playerHand > 0));
        PlayHand(playerHand);
    }

    Console.WriteLine("\nVS");

    Random rand = new Random();
    int computerHand = rand.Next(1, 4);
    PlayHand(computerHand);

    if ((playerHand == 1 && computerHand == 2) || (playerHand == 2 && computerHand == 3) || (playerHand == 3 && computerHand == 1))
    {
        computerScore++;
        if (computerScore == 3)
        {
            playerScore = 0;
            computerScore = 0;
            Console.WriteLine("COMPUTER WINS! YOU LOSE THE GAME!\n");
            Console.WriteLine("Do you want to play again? (y|n)");
            playerInput = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Computer wins this round.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    } else if ((computerHand == 1 && playerHand == 2) || (computerHand == 2 && playerHand == 3) || (computerHand == 3 && playerHand == 1))
    {
        playerScore++;
        if (playerScore == 3)
        {
            playerScore = 0;
            computerScore = 0;
            Console.WriteLine("YOU WIN! YOU WIN THE GAME!\n");
            Console.WriteLine("Do you want to play again? (y|n)");
            playerInput = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You win this round.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("It's a tie.\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    Console.Clear();
    success = false;
}