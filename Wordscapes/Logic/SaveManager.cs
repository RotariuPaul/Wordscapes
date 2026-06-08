using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class SaveManager
    {
        private string filePath = "savegame.json";
        public void Save(Player player, int currentLevelNumber, int endlessScore)
        {
            SaveData data = new SaveData
            {
                PlayerName = player.Name,
                Score = player.Score,
                CurrentLevelNumber = currentLevelNumber,
                EndlessScore = endlessScore
            };

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, json);
        }
        public SaveData? Load()
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<SaveData>(json);

        }
        public void Reset()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
