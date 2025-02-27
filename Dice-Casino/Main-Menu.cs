namespace DiceCasino;

public class MainMenu
{
    public static void Main()
    {
        var MoneyAmount = 100;
        Console.WriteLine($"Ⓨⓞⓤ ⓗⓐⓥⓔ${MoneyAmount}"); //
        Console.WriteLine("Ⓦⓔⓛⓒⓞⓜⓔ ⓣⓞ ⓣⓗⓔ Ⓓⓘⓒⓔ Ⓒⓐⓢⓘⓝⓞ! Ⓦⓗⓐⓣ ⓘⓢ ⓨⓞⓤⓡ ⓘⓝⓣⓔⓡⓔⓢⓣ ⓣⓞⓓⓐⓨ? \n 1. Yootz");
        var Game = Console.ReadLine();
        
        switch(Game)
        {
            // ## if you want to bring back the function just get rid of the //.
            Yootgame.Yootzgame();
        }
    }
}
