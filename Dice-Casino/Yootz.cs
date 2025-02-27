namespace DiceCasino;

using System.Timers;

public class Yootgame
{
    public static void Yootzgame(int MoneyAmount)
    {
        Playedbefore:
        Console.WriteLine("Welcome to Yootz! Have you played before? (yes/no)");
        var hasPlayed = Console.ReadLine();
        // ## THE FUCKING IF STATMENT WONT TURN PURPLE  TO SHOW THAT IT IS ACTIVATED BUT THE ELSE IF AND ELSE STATMENT WORK GREAT!!!! FUUUUUUCK
        //## for the
        if (hasPlayed.ToLower() == "yes")
        {
            GamePlay(MoneyAmount);
        }
        else if (hasPlayed.ToLower() == "no")
        {
            gameRules:
            GameRules();
            Console.WriteLine("Are you ready to play? Yes/No)");
            var Cont = Console.ReadLine();
            if (Cont.ToLower() == "yes")
            {
                Console.Clear();
                goto Playedbefore;
            }
            else
            {
                goto gameRules;
            }
        }
        else
        {
            Console.WriteLine("That was not a valid answer. Please type yes/Yes or no/No");
            goto Playedbefore;
        }
    }

    public static void GameRules()
    { //#this is writing out the rules before using the GamePlay function.
        Console.WriteLine(
            "Starting off we have the basics of the gameplay which is how to roll the dice. \n"
                + "Rolling the Dice: Each player takes a turn rolling 6 dice. \n"
                + "Players can roll the dice as many times as they want untill bust or you willingly end your turn. \n"
                + "if you fail to roll a 1, 5, or triple you bust and lose all points gained this turn.\n"
                + "Scoring: After rolling, the player chooses a category to score their dice. \n"
                + "Each category can only be used once per game. Categories are divided into two sections: Upper Section and Lower Section."
        );
        Console.WriteLine(
            "Here the basics in how your points will be scored\n"
                + "1 and 5 can be scored individually.\n"
                + "You can also score 3 of a kind with any number.\n"
                + ""
        ); //Continuing the ruls in the two different sections.
    }

    public static void GamePlay(int MoneyAmount)
    {
        var Playing = true;
        while (Playing == true)
        {
            Betting:
            Console.WriteLine($"{MoneyAmount}");
            Console.WriteLine("How much would you like to bet?");
            var moneybet = int.Parse(Console.ReadLine());
            if (moneybet > MoneyAmount)
            {
                Console.WriteLine("Invalid amount! You fucking idiot! Go to the Time Out Corner!");
                TimeOutCorner();
                Console.Clear();
                goto Betting;
            }
        }
    }

    private static Timer timer;

    //Punish all and any mistakes! Even small ones!
    public static void TimeOutCorner()
    {
        Console.WriteLine("You've been naughty, now sit and think about what you've done");
        timer = new Timer(20000);
        timer.Start();
    }
}
