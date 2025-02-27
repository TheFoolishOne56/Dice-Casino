namespace DiceCasino;

public class MainMenu
{
    public static void Main()
    {
        int MoneyAmount = 100;
        Console.WriteLine($"Ⓨⓞⓤ ⓗⓐⓥⓔ${MoneyAmount}"); 
        Console.WriteLine("Ⓦⓔⓛⓒⓞⓜⓔ ⓣⓞ ⓣⓗⓔ Ⓓⓘⓒⓔ Ⓒⓐⓢⓘⓝⓞ! Ⓦⓗⓐⓣ ⓘⓢ ⓨⓞⓤⓡ ⓘⓝⓣⓔⓡⓔⓢⓣ ⓣⓞⓓⓐⓨ? \n 1. Yootz");
        var Game = Console.ReadLine();
        if (Game.ToLower() == "yootz")
        {
            Yootgame.Yootzgame(MoneyAmount);
        }
    }
}
