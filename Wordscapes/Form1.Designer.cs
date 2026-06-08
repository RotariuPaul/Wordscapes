namespace Wordscapes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new Panel();
            menuLevelLabel = new Label();
            menuScoreLabel = new Label();
            menuPlayerLabel = new Label();
            endlessButton = new Button();
            campaignButton = new Button();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            changeNameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            gamePanel = new Panel();
            shuffleButton = new Button();
            backButton = new Button();
            hintButton = new Button();
            timerLabel = new Label();
            messageLabel = new Label();
            scoreLabel = new Label();
            wordTextBox = new TextBox();
            menuEndlessScoreLabel = new Label();
            menuPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuEndlessScoreLabel);
            menuPanel.Controls.Add(menuLevelLabel);
            menuPanel.Controls.Add(menuScoreLabel);
            menuPanel.Controls.Add(menuPlayerLabel);
            menuPanel.Controls.Add(endlessButton);
            menuPanel.Controls.Add(campaignButton);
            menuPanel.Controls.Add(menuStrip1);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(532, 763);
            menuPanel.TabIndex = 1;
            // 
            // menuLevelLabel
            // 
            menuLevelLabel.AutoSize = true;
            menuLevelLabel.Location = new Point(12, 55);
            menuLevelLabel.Name = "menuLevelLabel";
            menuLevelLabel.Size = new Size(58, 20);
            menuLevelLabel.TabIndex = 4;
            menuLevelLabel.Text = "Nivel: 1";
            // 
            // menuScoreLabel
            // 
            menuScoreLabel.AutoSize = true;
            menuScoreLabel.Location = new Point(12, 75);
            menuScoreLabel.Name = "menuScoreLabel";
            menuScoreLabel.Size = new Size(88, 20);
            menuScoreLabel.TabIndex = 3;
            menuScoreLabel.Text = "Scor total: 0";
            // 
            // menuPlayerLabel
            // 
            menuPlayerLabel.AutoSize = true;
            menuPlayerLabel.Location = new Point(12, 33);
            menuPlayerLabel.Name = "menuPlayerLabel";
            menuPlayerLabel.Size = new Size(96, 20);
            menuPlayerLabel.TabIndex = 2;
            menuPlayerLabel.Text = "Player: Player";
            // 
            // endlessButton
            // 
            endlessButton.Location = new Point(210, 339);
            endlessButton.Name = "endlessButton";
            endlessButton.Size = new Size(94, 42);
            endlessButton.TabIndex = 1;
            endlessButton.Text = "Endless";
            endlessButton.UseVisualStyleBackColor = true;
            endlessButton.Click += endlessButton_Click;
            // 
            // campaignButton
            // 
            campaignButton.Location = new Point(210, 252);
            campaignButton.Name = "campaignButton";
            campaignButton.Size = new Size(94, 41);
            campaignButton.TabIndex = 0;
            campaignButton.Text = "Campaign";
            campaignButton.UseVisualStyleBackColor = true;
            campaignButton.Click += campaignButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(532, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, changeNameToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(186, 26);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // changeNameToolStripMenuItem
            // 
            changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            changeNameToolStripMenuItem.Size = new Size(186, 26);
            changeNameToolStripMenuItem.Text = "Change Name";
            changeNameToolStripMenuItem.Click += changeNameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(shuffleButton);
            gamePanel.Controls.Add(backButton);
            gamePanel.Controls.Add(hintButton);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(messageLabel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(wordTextBox);
            gamePanel.Dock = DockStyle.Fill;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(532, 763);
            gamePanel.TabIndex = 2;
            gamePanel.Visible = false;
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(426, 687);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(94, 29);
            shuffleButton.TabIndex = 8;
            shuffleButton.Text = "Shuffle";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 722);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 7;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // hintButton
            // 
            hintButton.Location = new Point(426, 722);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(94, 29);
            hintButton.TabIndex = 6;
            hintButton.Text = "Hint";
            hintButton.UseVisualStyleBackColor = true;
            hintButton.Click += hintButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(12, 21);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(57, 20);
            timerLabel.TabIndex = 5;
            timerLabel.Text = "Time: 0";
            // 
            // messageLabel
            // 
            messageLabel.Location = new Point(150, 55);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(250, 25);
            messageLabel.TabIndex = 4;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(438, 21);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(53, 20);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Scor: 0";
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(200, 500);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(150, 27);
            wordTextBox.TabIndex = 1;
            wordTextBox.KeyDown += WordTextBox_KeyDown;
            // 
            // menuEndlessScoreLabel
            // 
            menuEndlessScoreLabel.AutoSize = true;
            menuEndlessScoreLabel.Location = new Point(12, 95);
            menuEndlessScoreLabel.Name = "menuEndlessScoreLabel";
            menuEndlessScoreLabel.Size = new Size(73, 20);
            menuEndlessScoreLabel.TabIndex = 6;
            menuEndlessScoreLabel.Text = "Endless: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 763);
            Controls.Add(menuPanel);
            Controls.Add(gamePanel);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel menuPanel;
        private Panel gamePanel;
        private Button endlessButton;
        private Button campaignButton;
        private TextBox wordTextBox;
        private Label messageLabel;
        private Label scoreLabel;
        private Label timerLabel;
        private Button hintButton;
        private Label menuLevelLabel;
        private Label menuScoreLabel;
        private Label menuPlayerLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private Button backButton;
        private Button shuffleButton;
        private ToolStripMenuItem changeNameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label menuEndlessScoreLabel;
    }
}
