using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace DiceCasino;

public class MainMenu
{
    public static void Main()
    {
        Console.Clear();
        int MoneyAmount = 100;
        BettingVictoryCondish(MoneyAmount);
        Menu:
        
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃ Welcome to Yootz! ┃");
        Console.WriteLine("┃ 1.Play Game       ┃");
        Console.WriteLine("┃ 2.Save Game       ┃");
        Console.WriteLine("┃ 3.Load Game       ┃");
        Console.WriteLine("┃ 4.Clear Console   ┃");
        Console.WriteLine($"┃ ${MoneyAmount}              ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━┛");
        choice:
        Console.WriteLine("Please enter the number of your selection: ");
        var Game = Console.ReadLine();
        
        switch(Game)
        {
            case "1":
                Yootgame.Yootzgame(MoneyAmount);
                break;
            case "2":                
                Console.WriteLine("Please enter you name: ");
                var Playname = Console.ReadLine();
                SaveSystem.SaveGame(Playname, MoneyAmount); //Make a new var that == MoneyAmount to update it from save
                goto choice;
            case "3":
                SaveSystem.LoadGame(ref MoneyAmount);

                goto choice;
            case "5":
                var money = int.Parse(Console.ReadLine());
                MoneyAmount = money;
                goto choice;
            case "4":
                Console.Clear();
                goto Menu;

        }
    }

    public static void BettingVictoryCondish(int MoneyAmount)
    {
        if(MoneyAmount == 999){
            Console.WriteLine("You won!");
            return;
        }
        else if(MoneyAmount == 0)
        {
            Console.WriteLine("You Lose!");
            return;
        }

    }
}