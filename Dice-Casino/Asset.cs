namespace DiceCasino;
using System;
using System.IO;




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
