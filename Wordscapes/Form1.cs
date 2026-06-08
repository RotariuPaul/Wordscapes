using Wordscapes.Controls;
using Wordscapes.Logic;
using Wordscapes.Models;
using Wordscapes.GameModes;
using System.Linq;
using System.Drawing.Drawing2D;

namespace Wordscapes
{
    public partial class Form1 : Form
    {
        private PuzzleGridControl puzzleGridControl = null!;
        private Game game = null!;
        private LevelManager levelManager = null!;
        private int currentLevelNumber;
        private System.Windows.Forms.Timer levelTimer = new System.Windows.Forms.Timer();
        private int remainingSeconds;
        private HintManager hintManager = new HintManager();
        private SaveManager saveManager = new SaveManager();
        private SaveData? loadedSave;
        private LetterWheelControl letterWheelControl = null!;
        private bool isEndlessMode = false;
        private EndlessMode? endlessMode;
        private int endlessScore = 0;


        public Form1()
        {
            InitializeComponent();
            CenterMenuControls();
            ClientSize = new Size(550, 810);
            loadedSave = saveManager.Load();
            if (loadedSave != null)
            {
                endlessScore = loadedSave.EndlessScore;
            }
            UpdateMenuInfo();
            messageLabel.AutoSize = false;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Location = new Point(0, 100);
            messageLabel.Size = new Size(ClientSize.Width, 30);

            AddButtonHoverEffect(backButton);
            AddButtonHoverEffect(shuffleButton);
            AddButtonHoverEffect(hintButton);
        }
        private void UpdateMenuInfo()
        {
            if (loadedSave == null)
            {
                menuPlayerLabel.Text = "Player: Player";
                menuScoreLabel.Text = "Scor total: 0";
                menuLevelLabel.Text = "Nivel: 1";
                menuEndlessScoreLabel.Text = "Scor Endless: 0";
            }
            else
            {
                menuPlayerLabel.Text = "Player: " + loadedSave.PlayerName;
                menuScoreLabel.Text = "Scor total: " + loadedSave.Score;
                menuLevelLabel.Text = "Nivel: " + loadedSave.CurrentLevelNumber;
                menuEndlessScoreLabel.Text = "Scor Endless: " + loadedSave.EndlessScore;
            }
        }
        private void campaignButton_Click(object sender, EventArgs e)
        {
            StartCampaign();
        }
        private void endlessButton_Click(object sender, EventArgs e)
        {
            StartEndless();
        }
        private void StartCampaign()
        {

            menuPanel.Visible = false;
            gamePanel.Visible = true;
            ClearGameControls();
            isEndlessMode = false;

            levelManager = new LevelManager();

            Player player;

            if (loadedSave == null)
            {
                currentLevelNumber = 1;
                player = new Player("Player");
            }
            else
            {
                currentLevelNumber = loadedSave.CurrentLevelNumber;

                if (currentLevelNumber > levelManager.LevelCount)
                {
                    currentLevelNumber = levelManager.LevelCount;
                }

                player = new Player(loadedSave.PlayerName);
                player.AddScore(loadedSave.Score);
            }

            Level level = levelManager.GetLevel(currentLevelNumber);
            game = new Game(player, level);

            StartTimer();

            scoreLabel.Text = "Scor nivel: 0";
            messageLabel.Text = "";

            puzzleGridControl = new PuzzleGridControl();
            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Size = new Size(450, 400);
            puzzleGridControl.Location = new Point((ClientSize.Width - puzzleGridControl.Width) / 2, 55);

            gamePanel.Controls.Add(puzzleGridControl);
            letterWheelControl = new LetterWheelControl();
            letterWheelControl.Size = new Size(360, 250);
            letterWheelControl.Location = new Point((ClientSize.Width - letterWheelControl.Width) / 2, 530);
            letterWheelControl.SetLetters(GetShuffledLetters());
            letterWheelControl.WordCompleted += LetterWheelControl_WordCompleted;
            gamePanel.Controls.Add(letterWheelControl);

        }

        private void StartEndless()
        {
            menuPanel.Visible = false;
            gamePanel.Visible = true;
            ClearGameControls();

            isEndlessMode = true;
            endlessScore = 0;

            Dictionary dictionary = new Dictionary("cuvinte_ro.txt");
            LevelGenerator generator = new LevelGenerator(dictionary);
            endlessMode = new EndlessMode(generator);

            Level level = endlessMode.GetNextLevel();

            Player player = new Player("Player");
            game = new Game(player, level);

            StartTimer();

            scoreLabel.Text = "Scor: 0";
            messageLabel.Text = "";

            puzzleGridControl = new PuzzleGridControl();
            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Size = new Size(450, 400);
            puzzleGridControl.Location = new Point((ClientSize.Width - puzzleGridControl.Width) / 2, 55);

            gamePanel.Controls.Add(puzzleGridControl);

            letterWheelControl = new LetterWheelControl();
            letterWheelControl.Size = new Size(360, 250);
            letterWheelControl.Location = new Point((ClientSize.Width - letterWheelControl.Width) / 2, 530);
            letterWheelControl.SetLetters(GetShuffledLetters());
            letterWheelControl.WordCompleted += LetterWheelControl_WordCompleted;

            gamePanel.Controls.Add(letterWheelControl);
        }

        private void WordTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckCurrentWord();
                e.SuppressKeyPress = true;
            }
        }

        private void CheckCurrentWord()
        {
            string word = wordTextBox.Text.Trim().ToUpper();

            bool wordAlreadyFound = game.FoundWords.Contains(word);

            bool isCorrect = game.TrySubmitWord(word);

            if (isCorrect)
            {
                messageLabel.Text = "Cuvant corect!";
                UpdateScoreLabel();
                puzzleGridControl.Invalidate();

                if (game.LevelCompleted())
                {
                    CompleteLevel();
                }
            }
            else if (wordAlreadyFound)
            {
                messageLabel.Text = "Cuvant deja gasit";
            }
            else
            {
                messageLabel.Text = "Cuvant gresit";
            }

            wordTextBox.Clear();
            wordTextBox.Focus();
        }

        private void LoadLevel(int levelNumber)
        {
            Level level = levelManager.GetLevel(levelNumber);
            game = new Game(game.Player, level);
            UpdateScoreLabel();

            StartTimer();
            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Invalidate();

            letterWheelControl.SetLetters(GetShuffledLetters());


            wordTextBox.Clear();
            messageLabel.Text = "";
        }
        private void StartTimer()
        {
            remainingSeconds = game.CurrentLevel.TimeLimitSeconds;
            timerLabel.Text = "Time: " + remainingSeconds;
            levelTimer.Interval = 1000;
            levelTimer.Tick -= LevelTimer_Tick;
            levelTimer.Tick += LevelTimer_Tick;
            levelTimer.Start();
        }
        private void LevelTimer_Tick(object? sender, EventArgs e)
        {
            remainingSeconds--;
            timerLabel.Text = "Time: " + remainingSeconds;

            if (remainingSeconds <= 0)
            {
                levelTimer.Stop();
                messageLabel.Text = "Timp expirat!";


                letterWheelControl.Enabled = false;
            }
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            bool usedHint = hintManager.RevealRandomLetter(game.CurrentLevel, game.FoundWords);
            if (usedHint)
            {
                game.RemoveFromLevelScore(20);
                UpdateScoreLabel();

                messageLabel.Text = "Hint folosit!";
                puzzleGridControl.Invalidate();
                CheckWordsCompletedByHints();
            }
            else
                messageLabel.Text = "Nu mai exista hint-uri";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string playerName = "Player";

            if (loadedSave != null)
            {
                playerName = loadedSave.PlayerName;
            }

            saveManager.Reset();

            Player player = new Player(playerName);
            saveManager.Save(player, 1, 0);

            loadedSave = saveManager.Load();
            UpdateMenuInfo();

            MessageBox.Show("Progres resetat!");
        }


        private void LetterWheelControl_WordCompleted(string word)
        {
            wordTextBox.Text = word;
            CheckCurrentWord();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            levelTimer.Stop();
            if (!isEndlessMode)
            {
                saveManager.Save(game.Player, currentLevelNumber, endlessScore);
                loadedSave = saveManager.Load();
            }
            else
            {
                endlessScore = game.Player.Score + game.CurrentLevelScore;
                SaveEndlessScore();
            }
            ClearGameControls();

            gamePanel.Visible = false;
            menuPanel.Visible = true;

            UpdateMenuInfo();
        }
        private void ClearGameControls()
        {
            if (puzzleGridControl != null)
            {
                gamePanel.Controls.Remove(puzzleGridControl);
            }

            if (letterWheelControl != null)
            {
                gamePanel.Controls.Remove(letterWheelControl);
            }
        }
        private void LoadNextEndlessLevel()
        {
            if (endlessMode == null)
            {
                return;
            }

            Level level = endlessMode.GetNextLevel();
            game = new Game(game.Player, level);
            UpdateScoreLabel();
            StartTimer();

            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Invalidate();

            letterWheelControl.SetLetters(GetShuffledLetters());
            letterWheelControl.Enabled = true;

            wordTextBox.Clear();
            messageLabel.Text = "";
        }
        private void CheckWordsCompletedByHints()
        {
            foreach (GridWord gridWord in game.CurrentLevel.GridWords)
            {
                if (!game.FoundWords.Contains(gridWord.Word) &&
                    game.CurrentLevel.Grid.IsWordRevealed(gridWord))
                {
                    game.TrySubmitWord(gridWord.Word);
                    UpdateScoreLabel();
                }
            }

            if (game.LevelCompleted())
            {
                CompleteLevel();
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            letterWheelControl.SetLetters(GetShuffledLetters());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentName = "Player";

            if (loadedSave != null)
            {
                currentName = loadedSave.PlayerName;
            }

            string? newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Introdu noul nume:",
                "Change Name",
                currentName
            );

            if (string.IsNullOrWhiteSpace(newName))
            {
                return;
            }

            int score = 0;
            int level = 1;

            if (loadedSave != null)
            {
                score = loadedSave.Score;
                level = loadedSave.CurrentLevelNumber;
            }

            Player player = new Player(newName);
            player.AddScore(score);

            saveManager.Save(player, level, endlessScore);
            loadedSave = saveManager.Load();

            UpdateMenuInfo();
        }
        private List<char> GetShuffledLetters()
        {
            Random random = new Random();

            return game.CurrentLevel.Letters
                .OrderBy(letter => random.Next())
                .ToList();
        }
        private void CompleteLevel()
        {
            messageLabel.Text = "Nivel complet!";

            int wordScore = game.CurrentLevelScore;
            int timeBonus = remainingSeconds * 2;

            game.AddToLevelScore(timeBonus);

            int finalLevelScore = game.CurrentLevelScore;

            game.AddLevelScoreToPlayer();

            if (isEndlessMode)
            {
                endlessScore = game.Player.Score;
                SaveEndlessScore();
                LoadNextEndlessLevel();
                return;
            }

            levelCompleteTitleLabel.Text = "Nivel complet!";
            levelCompleteScoreLabel.Text =
                "Scor cuvinte: " + wordScore +
                "\nBonus timp: " + timeBonus +
                "\nScor nivel: " + finalLevelScore;

            levelCompletePanel.Location = new Point(
                (gamePanel.Width - levelCompletePanel.Width) / 2,
                (gamePanel.Height - levelCompletePanel.Height) / 2
            );

            levelCompletePanel.Visible = true;
            levelCompletePanel.BringToFront();
        }
        private void SaveEndlessScore()
        {
            string playerName = "Player";
            int campaignScore = 0;
            int campaignLevel = 1;

            if (loadedSave != null)
            {
                playerName = loadedSave.PlayerName;
                campaignScore = loadedSave.Score;
                campaignLevel = loadedSave.CurrentLevelNumber;
            }

            Player player = new Player(playerName);
            player.AddScore(campaignScore);

            saveManager.Save(player, campaignLevel, endlessScore);
            loadedSave = saveManager.Load();
        }
        private void UpdateScoreLabel()
        {
            if (isEndlessMode)
            {
                int currentEndlessScore = game.Player.Score + game.CurrentLevelScore;
                scoreLabel.Text = "Scor: " + currentEndlessScore;
            }
            else
            {
                scoreLabel.Text = "Scor nivel: " + game.CurrentLevelScore;
            }
        }
        private void CenterMenuControls()
        {
            titleLabel.Width = menuPanel.Width;
            titleLabel.Location = new Point(0, 150);

            campaignButton.Size = new Size(200, 50);
            campaignButton.Location = new Point((menuPanel.Width - campaignButton.Width) / 2, 280);

            endlessButton.Size = new Size(200, 50);
            endlessButton.Location = new Point((menuPanel.Width - endlessButton.Width) / 2, 350);
            playerInfoPanel.Location = new Point(
    (menuPanel.Width - playerInfoPanel.Width) / 2,
    endlessButton.Bottom + 35
);
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            CenterMenuControls();

        }
        private void AddButtonHoverEffect(Button button)
        {
            Size normalSize = button.Size;
            Point normalLocation = button.Location;

            button.MouseEnter += (sender, e) =>
            {
                button.Size = new Size(normalSize.Width + 8, normalSize.Height + 8);
                button.Location = new Point(normalLocation.X - 4, normalLocation.Y - 4);
            };

            button.MouseLeave += (sender, e) =>
            {
                button.Size = normalSize;
                button.Location = normalLocation;
            };
        }

        private void levelCompleteNextButton_Click(object sender, EventArgs e)
        {
            levelCompletePanel.Visible = false;

            if (isEndlessMode)
            {
                LoadNextEndlessLevel();
                return;
            }

            currentLevelNumber++;

            int levelToSave = currentLevelNumber;

            if (levelToSave > levelManager.LevelCount)
            {
                levelToSave = levelManager.LevelCount;
            }

            saveManager.Save(game.Player, levelToSave, endlessScore);

            if (currentLevelNumber <= levelManager.LevelCount)
            {
                LoadLevel(currentLevelNumber);
            }
            else
            {
                levelTimer.Stop();
                messageLabel.Text = "Ai terminat toate nivelurile";
            }
        }
    }
}
