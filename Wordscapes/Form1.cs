using Wordscapes.Controls;
using Wordscapes.Logic;
using Wordscapes.Models;

namespace Wordscapes
{
    public partial class Form1 : Form
    {
        private PuzzleGridControl puzzleGridControl = null!;
        private Game game = null!;
        private List<Button> letterButtons = new List<Button>();
        private LevelManager levelManager = null!;
        private int currentLevelNumber;
        private System.Windows.Forms.Timer levelTimer = new System.Windows.Forms.Timer();
        private int remainingSeconds;
        private HintManager hintManager = new HintManager();
        private SaveManager saveManager = new SaveManager();
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 650);
        }

        private void campaignButton_Click(object sender, EventArgs e)
        {
            StartCampaign();
        }

        private void StartCampaign()
        {

            menuPanel.Visible = false;
            gamePanel.Visible = true;

            levelManager = new LevelManager();
            currentLevelNumber = 1;

            Level level = levelManager.GetLevel(currentLevelNumber);
            Player player = new Player("Player");
            game = new Game(player, level);
            StartTimer();
            lettersLabel.Text = "Litere: " + string.Join(" ", game.CurrentLevel.Letters);
            scoreLabel.Text = "Scor: 0";
            messageLabel.Text = "";

            puzzleGridControl = new PuzzleGridControl();
            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Location = new Point(50, 50);
            puzzleGridControl.Size = new Size(400, 400);

            gamePanel.Controls.Add(puzzleGridControl);

            CreateLetterButtons();
        }

        private void CreateLetterButtons()
        {
            letterButtons = new List<Button>();

            int startX = 50;
            int startY = 580;
            int buttonSize = 45;

            for (int i = 0; i < game.CurrentLevel.Letters.Count; i++)
            {
                Button letterButton = new Button();
                letterButton.Text = game.CurrentLevel.Letters[i].ToString();
                letterButton.Size = new Size(buttonSize, buttonSize);
                letterButton.Location = new Point(startX + i * 55, startY);
                letterButton.Click += LetterButton_Click;

                letterButtons.Add(letterButton);
                gamePanel.Controls.Add(letterButton);
            }
        }

        private void LetterButton_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                wordTextBox.Text += button.Text;
                button.Enabled = false;
                wordTextBox.Focus();
                wordTextBox.SelectionStart = wordTextBox.Text.Length;
            }
        }

        private void WordTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void checkButton_Click(object? sender, EventArgs e)
        {
            bool isCorrect = game.TrySubmitWord(wordTextBox.Text);

            if (isCorrect)
            {
                messageLabel.Text = "Cuvant corect!";
                scoreLabel.Text = "Scor: " + game.Player.Score;
                puzzleGridControl.Invalidate();

                if (game.LevelCompleted())
                {
                    messageLabel.Text = "Nivel complet!";
                    
                    currentLevelNumber++;
                    saveManager.Save(game.Player, currentLevelNumber);
                    if (currentLevelNumber <= levelManager.LevelCount)
                        LoadLevel(currentLevelNumber);
                    else
                        messageLabel.Text = "Ai terminat toate nivelurile";
                }
            }
            else
            {
                messageLabel.Text = "Cuvant gresit sau deja gasit.";
            }

            wordTextBox.Clear();
            wordTextBox.Focus();

            foreach (Button button in letterButtons)
            {
                button.Enabled = true;
            }
        }

        private void LoadLevel(int levelNumber)
        {
            Level level = levelManager.GetLevel(levelNumber);
            game = new Game(game.Player, level);
            checkButton.Enabled = true;
            StartTimer();
            puzzleGridControl.Grid = game.CurrentLevel.Grid;
            puzzleGridControl.Invalidate();

            lettersLabel.Text = "Litere: " + string.Join(" ", game.CurrentLevel.Letters);

            foreach (Button button in letterButtons)
            {
                gamePanel.Controls.Remove(button);
            }

            letterButtons.Clear();

            CreateLetterButtons();

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
                checkButton.Enabled = false;

                foreach (Button button in letterButtons)
                {
                    button.Enabled = false;
                }
            }
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            bool usedHint = hintManager.RevealRandomLetter(game.CurrentLevel, game.FoundWords);
            if (usedHint)
            {
                messageLabel.Text = "Hint folosit!";
                puzzleGridControl.Invalidate();
            }
            else
                messageLabel.Text = "Nu mai exista hint-uri";
        }
    }
}