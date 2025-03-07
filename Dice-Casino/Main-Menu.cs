using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace DiceCasino;

public class MainMenu
{
    public static void amountOfMoney(int money)
    {
        
    }

    public static int MoneyAmount = 100;

    public static void Main()
    {
        Console.Clear();
         //Money doesn't update
        //amountOfMoney(MoneyAmount);

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
        BettingVictoryCondish(MoneyAmount);
        var Game = Console.ReadLine();

        switch (Game)
        {
            case "1":
                Yootgame.Yootzgame(ref MoneyAmount);
                break;
            case "2":                
                Console.WriteLine("Please enter you name: ");
                var Playname = Console.ReadLine();
                SaveSystem.SaveGame(Playname, MoneyAmount); //Make a new var that == MoneyAmount to update it from save
                goto choice;
            case "3":
                SaveSystem.LoadGame(ref MoneyAmount);
                goto choice;
            case "5": //press five for a secret suprise
                var money = int.Parse(Console.ReadLine());//can set your own money
                MoneyAmount = money;
                goto choice;
            case "4":
                Console.Clear();
                goto Menu;

        }
    }

    public static void BettingVictoryCondish(int MoneyAmount)
    {
        if(MoneyAmount >= 999){
            Console.Clear();
            Console.WriteLine("┏━━━━━━━━┓");
            Console.WriteLine("┃You won!┃");
            Console.WriteLine("┗━━━━━━━━┛");
            Environment.Exit(0);
        }
        else if(MoneyAmount <= 0)
        {   Console.Clear();
            Console.WriteLine("┏━━━━━━━━━┓");
            Console.WriteLine("┃You lose!┃");
            Console.WriteLine("┗━━━━━━━━━┛");
            Environment.Exit(0);

        }
    }
}