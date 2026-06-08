using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class LevelGenerator
    {
        private Dictionary dictionary;
        private Random random = new Random();

        public LevelGenerator(Dictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public Level GenerateLevel(int levelNumber)
        {
            int letterCount = GetLetterCount(levelNumber);
            int wordCount = GetWordCount(levelNumber);
            int timeLimit = 90 + levelNumber * 10;

            string baseWord = GetRandomBaseWord(letterCount);
            List<char> letters = baseWord.ToList();

            List<string> possibleWords = dictionary
                .GetWordsThatCanBeFormedFromLetters(letters)
                .Where(word => word.Length >= 3)
                .OrderBy(word => random.Next())
                .Take(wordCount)
                .ToList();

            if (!possibleWords.Contains(baseWord))
            {
                possibleWords.Insert(0, baseWord);
            }

            possibleWords = possibleWords
                .Distinct()
                .Take(wordCount)
                .ToList();

            List<GridWord> gridWords = new List<GridWord>();

            int row = 0;

            foreach (string word in possibleWords)
            {
                gridWords.Add(new GridWord(word, row, 0, true));
                row += 2;
            }

            return new Level(
                levelNumber,
                letters,
                possibleWords,
                gridWords,
                timeLimit
            );
        }

        private int GetLetterCount(int levelNumber)
        {
            if (levelNumber <= 2)
            {
                return 4;
            }

            if (levelNumber <= 5)
            {
                return 5;
            }

            if (levelNumber <= 8)
            {
                return 6;
            }

            return 7;
        }

        private int GetWordCount(int levelNumber)
        {
            if (levelNumber <= 2)
            {
                return 3;
            }

            if (levelNumber <= 5)
            {
                return 4;
            }

            return 5;
        }

        private string GetRandomBaseWord(int length)
        {
            List<string> candidates = dictionary.GetWordsByLength(length);

            return candidates[random.Next(candidates.Count)];
        }
    }
}