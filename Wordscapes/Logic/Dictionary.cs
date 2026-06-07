using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Logic
{
    public class Dictionary
    {
        private List<string> words;
        public Dictionary(string filePath)
        {
            words = File.ReadAllLines(filePath).Select(word => word.Trim().ToUpper()).Where(word => word.Length >= 3 && word.Length <= 7).ToList();
        }
        public bool IsValidWord(string word)
        {
            return words.Contains(word.Trim().ToUpper());
        }
        public List<string> GetWordsByLength(int length)
        {
            return words.Where(word => word.Length == length).ToList();
        }
    }
}
