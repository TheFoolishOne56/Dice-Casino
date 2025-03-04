namespace DiceCasino;

public class MainMenu
{
    public static void Main()
    {
        var MoneyAmount = 100;
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃ Welcome to Yootz! ┃");
        Console.WriteLine("┃ 1.Play Game       ┃");
        Console.WriteLine("┃ 2.Save Game       ┃");
        Console.WriteLine("┃ 3.Load Game       ┃");
        Console.WriteLine($"┃ ${MoneyAmount}              ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━┛");

        var Game = Console.ReadLine();

        switch (Game)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
        }
    }
}
