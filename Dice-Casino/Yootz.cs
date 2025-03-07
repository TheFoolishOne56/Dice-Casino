namespace DiceCasino;

using System;
using System.ComponentModel.Design;
using System.Timers;

public class Yootgame
{
    public static Dictionary<int, string> DiceGlyphs = new Dictionary<int, string>
    {
        { 0, "[1]" },
        { 1, "[2]" },
        { 2, "[3]" },
        { 3, "[4]" },
        { 4, "[5]" },
        { 5, "[6]" },
    };

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
        Console.Clear();
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
                PutinTimeOut();
                goto Betting;
            }
            Console.WriteLine("Rolling dice!");
            Random roll = new Random();
            int[] diceRolls = new int[6]; // Array to store dice values
            bool[] keepDice = new bool[6]; // Array to track kept dice
            for (int i = 0; i < 6; i++)
            {
                diceRolls[i] = roll.Next(0, 5);
                Console.WriteLine($"Roll {i + 1}: {DiceGlyphs[diceRolls[i]]}");
            }
            var Done = true;
            while (true == Done)
            {
                Console.WriteLine("Enter the dice numbers (1-6) to keep, separated by spaces, press Enter to reroll, or input Done to end the game");
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    Done = false;
                    CheckForPoints(keepDice, moneybet, MoneyAmount);
                    Console.WriteLine("Would you like to ");
                    MainMenu.Main();
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    string[] choices = input.Split(' ');
                    foreach (string choice in choices)
                    {
                        if (int.TryParse(choice, out int index) && 0 < index && index <= 6)
                        {
                            keepDice[index - 1] = true; // Mark dice as kept
                        }
                    }
                }

                // Re-roll only the dice that are not kept
                for (int i = 0; i < 6; i++)
                {
                    if (!keepDice[i])
                    {
                        diceRolls[i] = roll.Next(0, 5);
                        Console.WriteLine($"Roll {i + 1}: {DiceGlyphs[diceRolls[i]]}");
                    }
                }
                NumberOfDiceKept(keepDice, diceRolls);
                
                for (int i = 0; i <= 6; i++)
                {
                    if(keepDice[0-5] != false)
                    {
                        Done = false;
                        CheckForPoints(keepDice, moneybet, MoneyAmount);
                        Console.WriteLine("Would you like to play again? [yes/no]");
                        string PlyrFeedBack = Console.ReadLine();
                        if(PlyrFeedBack.ToLower() == "yes")
                        {
                            
                        }
                        else
                        {
                            MainMenu.Main();
                        }
                    }
                }
            }
        }
    }

    public static void NumberOfDiceKept(bool[] keepDice, int[] diceRolls)
    {
        for (int a = 0; a < 6; a++)
        {
            if (keepDice[a])
            {
                Console.WriteLine($"Dice kept: {a + 1}; {DiceGlyphs[diceRolls[a]]}");
            }
            //CheckForPoints(keepDice);
        }
    }

    //Punish all and any mistakes! Even small ones!
    public static void PutinTimeOut()
    {
        Console.WriteLine("You've made a mistake, now sit and think about what you've done");
        Task.Delay(20000).Wait();
        Console.WriteLine("Now dont mess up again, understood? Y/N");
        var understanding = Console.ReadLine();
        if (understanding.ToLower() == "yes")
        {
            Console.Clear();
        }
        else
        {
            PutinTimeOut();
        }
    }

    public static void CheckForPoints(bool[] keepDice, int moneybet, int MoneyAmount)
    {
        if (keepDice.)
    }

    //public static void CheckForFail(int[] diceRolls)//not works?
    //{
    //    //var hasTriple = new List<int> { 1, 2, 3, 4, 5, 6 }
    //    //    .Where(num => 2 < diceRolls.Where(x => x == num).Count())
    //    //    .Any();
//
    //    //Lose condition for not having 1
    //    if (!diceRolls.Contains(1) && !diceRolls.Contains(5) && !diceRolls.Contains(3))
    //        Console.WriteLine("Bust!\nWhat a loser!\nThanks for the money!");
    //}
}
