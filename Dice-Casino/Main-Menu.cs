using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace DiceCasino;

public class MainMenu
{
    public static void Main()
    {
        var MoneyAmount = 100;
        Menu:
        
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃ Welcome to Yootz! ┃");
        Console.WriteLine("┃ 1.Play Game       ┃");
        Console.WriteLine("┃ 2.Save Game       ┃");
        Console.WriteLine("┃ 3.Load Game       ┃");
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
                SaveSystem.SaveGame(Playname, MoneyAmount);
                goto choice;
            case "3":
                SaveSystem.LoadGame();
                goto choice;
            case "4":
                var money = int.Parse(Console.ReadLine());
                MoneyAmount = money;
                goto choice;
            case "5":
                Console.Clear();
                goto Menu;

        }
    }
}
