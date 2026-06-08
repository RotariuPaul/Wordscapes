using System;
using System.Collections.Generic;
using System.Linq;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class LevelManager
    {
        private List<Level> levels;

        public LevelManager()
        {
            levels = new List<Level>
{
    new Level(
        1,
        new List<char> { 'A', 'E', 'R' },
        new List<string> { "AER", "ARE" },
        new List<GridWord>
        {
            new GridWord("AER", 0, 0, true),
            new GridWord("ARE", 0, 0, false)
        },
        90
    ),

    new Level(
        2,
        new List<char> { 'C', 'A', 'S', 'A' },
        new List<string> { "CASA", "CAS", "SAC" },
        new List<GridWord>
        {
            new GridWord("CASA", 0, 0, true),
            new GridWord("CAS", 0, 0, false),
            new GridWord("SAC", 0, 2, false)
        },
        100
    ),

    new Level(
        3,
        new List<char> { 'M', 'A', 'R', 'E' },
        new List<string> { "MARE", "MAR", "RAM" },
        new List<GridWord>
        {
            new GridWord("MARE", 0, 0, true),
            new GridWord("MAR", 0, 0, false),
            new GridWord("RAM", 0, 2, false)
        },
        110
    ),

    new Level(
        4,
        new List<char> { 'C', 'A', 'R', 'T', 'E' },
        new List<string> { "CARTE", "CARE", "RAC", "ERA" },
        new List<GridWord>
        {
            new GridWord("CARTE", 0, 0, true),
            new GridWord("CARE", 0, 0, false),
            new GridWord("RAC", 0, 2, false),
            new GridWord("ERA", 0, 4, false)
        },
        120
    ),

   new Level(
    5,
    new List<char> { 'C', 'A', 'M', 'E', 'R', 'A' },
    new List<string> { "CAMERA", "CAMA", "MACAR", "RAMA" },
    new List<GridWord>
    {
        new GridWord("CAMERA", 0, 0, true),
        new GridWord("CAMA", 0, 0, false),
        new GridWord("MACAR", 0, 2, false),
        new GridWord("RAMA", 0, 4, false)
    },
    130
),

    new Level(
        6,
        new List<char> { 'C', 'A', 'S', 'T', 'E', 'L' },
        new List<string> { "CASTEL", "CAL", "STEA", "EST" },
        new List<GridWord>
        {
            new GridWord("CASTEL", 0, 0, true),
            new GridWord("CAL", 0, 0, false),
            new GridWord("STEA", 0, 2, false),
            new GridWord("EST", 0, 4, false)
        },
        140
    ),

    new Level(
        7,
        new List<char> { 'P', 'A', 'D', 'U', 'R', 'E' },
        new List<string> { "PADURE", "PAR", "DAR", "RAU" },
        new List<GridWord>
        {
            new GridWord("PADURE", 0, 0, true),
            new GridWord("PAR", 0, 0, false),
            new GridWord("DAR", 0, 2, false),
            new GridWord("RAU", 0, 4, false)
        },
        150
    ),

    new Level(
        8,
        new List<char> { 'L', 'U', 'M', 'I', 'N', 'A' },
        new List<string> { "LUMINA", "LUNA", "MINA", "NAI" },
        new List<GridWord>
        {
            new GridWord("LUMINA", 0, 0, true),
            new GridWord("LUNA", 0, 0, false),
            new GridWord("MINA", 0, 2, false),
            new GridWord("NAI", 0, 4, false)
        },
        160
    ),

    new Level(
        9,
        new List<char> { 'P', 'L', 'A', 'N', 'E', 'T', 'A' },
        new List<string> { "PLANETA", "PLAN", "APELANT", "ELAN", "APELA" },
        new List<GridWord>
        {
            new GridWord("PLANETA", 0, 0, true),
            new GridWord("PLAN", 0, 0, false),
            new GridWord("APELANT", 0, 2, false),
            new GridWord("ELAN", 0, 4, false),
            new GridWord("APELA", 0, 6, false)
        },
        180
    )
};
        }

        public Level GetLevel(int levelNumber)
        {
            Level? level = levels.FirstOrDefault(level => level.LevelNumber == levelNumber);

            if (level == null)
            {
                throw new Exception("Nivelul nu există.");
            }

            return level;
        }
        public int LevelCount
        {
            get { return levels.Count; }
        }
    }
}