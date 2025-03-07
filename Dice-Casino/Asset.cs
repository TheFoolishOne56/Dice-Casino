namespace DiceCasino;
using System;
using System.IO;




public class SaveSystem
{
   static string saveFilePath = "savegame.txt";

   public static void SaveGame(string playerName, ref Money money)
    {
        using (StreamWriter writer = new StreamWriter(saveFilePath))
        {
            writer.WriteLine(playerName);
            writer.WriteLine(money.MoneyAmount.ToString());
        }
        Console.WriteLine("Game saved successfully!");
    }
     public static void LoadGame(ref Money money)
    {
        if (File.Exists(saveFilePath))
        {
            using (StreamReader reader = new StreamReader(saveFilePath))
            {
             string playerName = reader.ReadLine(); // Read player name
              string moneyString = reader.ReadLine(); // Read money as string

              // Safely parse money amount
              if (int.TryParse(moneyString, out int loadedMoney))
              {
                  money.MoneyAmount = loadedMoney; // Update Money object
                  Console.WriteLine($"Loaded Game: {playerName} - Money: {money.MoneyAmount}");
              }
              else
              {
                  Console.WriteLine("Error: Save file contains invalid money data.");
              }
            }
        }
        else
        {
            Console.WriteLine("No save file found.");
        }
    }


}
