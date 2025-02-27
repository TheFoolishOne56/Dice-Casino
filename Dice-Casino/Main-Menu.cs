namespace DiceCasino;

public class MainMenu
{
    public static void Menu()
    {
        var MoneyAmount = 100;
        Console.WriteLine($"Ⓨⓞⓤ ⓗⓐⓥⓔ${MoneyAmount}"); //
        Console.WriteLine("Ⓦⓔⓛⓒⓞⓜⓔ ⓣⓞ ⓣⓗⓔ Ⓓⓘⓒⓔ Ⓒⓐⓢⓘⓝⓞ! Ⓦⓗⓐⓣ ⓘⓢ ⓨⓞⓤⓡ ⓘⓝⓣⓔⓡⓔⓢⓣ ⓣⓞⓓⓐⓨ? \n 1. Yootz");
        var Game = Console.ReadLine();
        if (Game.ToLower() == "yootz")
        {
            // ## if you want to bring back the function just get rid of the //.
            Yootgame.Yootzgame();
        }
    }
}
