using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class LevelGenerator
    {
        private Dictionary dictionary;
        public LevelGenerator(Dictionary dictionary)
        {
            this.dictionary = dictionary;
        }
        public Level GenerateLevel(int levelNumber)
        {
            List<char> letters = new List<char> { 'A', 'R', 'E' };
            List<string> possibleWords = dictionary.GetWordsThatCanBeFormedFromLetters(letters).Take(2).ToList();
            List<GridWord> gridWords = new List<GridWord>
            {
                new GridWord(possibleWords[0],0,0,true),
                new GridWord(possibleWords[1],0,2,false)
            };
            return new Level(levelNumber, letters, possibleWords, gridWords, 90);
        }
    }
}
