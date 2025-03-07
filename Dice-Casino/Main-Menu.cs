using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace DiceCasino;
public class Money
{
    public int MoneyAmount {get; set;}
}
public class MainMenu
{
    public static void Main()
    {
        Console.Clear();
        Money amount1 = new Money();
        amount1.MoneyAmount = 100;
        Menu:
        
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃ Welcome to Yootz! ┃");
        Console.WriteLine("┃ 1.Play Game       ┃");
        Console.WriteLine("┃ 2.Save Game       ┃");
        Console.WriteLine("┃ 3.Load Game       ┃");
        Console.WriteLine("┃ 4.Clear Console   ┃");
        Console.WriteLine($"┃ ${amount1.MoneyAmount}              ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━┛");
        choice:
        Console.WriteLine("Please enter the number of your selection: ");
        BettingVictoryCondish(amount1.MoneyAmount);
        var Game = Console.ReadLine();

        switch (Game)
        {
            case "1":
                Yootgame.Yootzgame(ref amount1);
                break;
            case "2":                
                Console.WriteLine("Please enter you name: ");
                var Playname = Console.ReadLine();
                SaveSystem.SaveGame(Playname, ref amount1); //Make a new var that == MoneyAmount to update it from save
                goto choice;
            case "3":
                SaveSystem.LoadGame(ref amount1);

                goto choice;
            case "5":
                var money = int.Parse(Console.ReadLine());
                amount1.MoneyAmount = money;
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