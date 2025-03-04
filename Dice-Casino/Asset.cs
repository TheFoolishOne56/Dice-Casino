namespace DiceCasino;
using System;
using System.IO;


public class Assets
{
    public static void dieAssets()
    {
        Dictionary<int, string> DiceAss = new Dictionary<int, string>();
        DiceAss.Add(0, "⚀");
        DiceAss.Add(1, "⚁");
        DiceAss.Add(2, "⚂");
        DiceAss.Add(3, "⚃");
        DiceAss.Add(4, "⚄");
        DiceAss.Add(5, "⚅");
    }
}

public class SaveSystem
{
   static string saveFilePath = "savegame.txt";

   public static void SaveGame(string playerName, int money)
    {
        using (StreamWriter writer = new StreamWriter(saveFilePath))
        {
            writer.WriteLine(playerName);
            writer.WriteLine(money);
        }
        Console.WriteLine("Game saved successfully!");
    }
     public static void LoadGame(ref int MoneyAmount)
    {
        if (File.Exists(saveFilePath))
        {
            using (StreamReader reader = new StreamReader(saveFilePath))
            {
                string playerName = reader.ReadLine();
                int money = int.Parse(reader.ReadLine());
                MoneyAmount = money;

                Console.WriteLine($"Loaded Game: {playerName} - Money: {money}");
            }
        }
        else
        {
            Console.WriteLine("No save file found.");
        }
    }


}
