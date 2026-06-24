using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Task_Tracker_2
{
    internal class SaveHandler
    {
        private static string FilePath()
        {
            return "TaskHandlerSaveData.json";
        }
        public static void SaveData(Dictionary<string, Task> keyValuePairs)
        {
            string saveData = JsonSerializer.Serialize(keyValuePairs, new JsonSerializerOptions{
                WriteIndented = true
            });

            if (!File.Exists(FilePath()))
            {
                var fileCreator = File.Create(FilePath());
                fileCreator.Close();
            }
            File.WriteAllText(FilePath(), saveData);
        }
        public static Dictionary<string, Task> LoadData()
        {
            if (!File.Exists(FilePath()))
            {
                return null;
            }
            if (File.ReadAllText(FilePath()) == "")
            {
                return null;
            }
            string rawData = File.ReadAllText(FilePath());
            Dictionary<string, Task> saveData = JsonSerializer.Deserialize<Dictionary<string, Task>>(rawData);

            return saveData;
        }
    }
}
