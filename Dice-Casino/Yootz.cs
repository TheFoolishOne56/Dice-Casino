namespace DiceCasino;

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
            GameRules();
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
                + "Rolling the Dice: Each player takes a turn rolling the five dice. \n"
                + "Players can roll the dice up to three times per turn to get the highest-scoring combination. \n"
                + "First Roll: The player rolls all five dice. \n"
                + "Second and Third Rolls: After the first roll, the player can choose to keep any dice they want and re-roll the rest. \n"
                + "They may re-roll some or all of the dice two more times. \n"
                + "Players can also choose to stop after the first or second roll if they have a combination they like. \n"
                + "Scoring: After rolling, the player chooses a category to score their dice. \n"
                + "Each category can only be used once per game. Categories are divided into two sections: Upper Section and Lower Section."
        );
        Console.WriteLine(); //Continuing the ruls in the two different sections.
    }

    public static void GamePlay(int MoneyAmount) 
    { 
        Console.Clear();
        var GameGoing = true;
        while(GameGoing == true)
            {
                

            }





    }
}
