namespace DiceCasino;

public class MainMenu
{
    public static void Menu()
    {
        var MoneyAmount = 100;
        Console.WriteLine($"Ⓨⓞⓤ ⓗⓐⓥⓔ ${MoneyAmount}");
        Console.WriteLine("Ⓦⓔⓛⓒⓞⓜⓔ ⓣⓞ ⓣⓗⓔ Ⓓⓘⓒⓔ Ⓒⓐⓢⓘⓝⓞ! Ⓦⓗⓐⓣ ⓘⓢ ⓨⓞⓤⓡ ⓘⓝⓣⓔⓡⓔⓢⓣ ⓣⓞⓓⓐⓨ? \n 1. Yootz");
        var Game = Console.ReadLine();
        if Game == "Yootz"||"yootz";
        {
            // ## if you want to bring back the function just get rid of the //.
            //Yootzgame
            break
        }
    }
    // ## Works as a function when placed in Main-Menu.cs but not when in Yootz.cs. 
    //public static void Yootzgame();
    //{
    //    Console.WriteLine("Welcome to Yootz");
    //}
}
