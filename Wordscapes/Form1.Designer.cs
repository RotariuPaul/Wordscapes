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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuPanel = new Panel();
            titleLabel = new Label();
            endlessButton = new Button();
            campaignButton = new Button();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            changeNameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            playerInfoPanel = new Panel();
            menuEndlessScoreLabel = new Label();
            menuLevelLabel = new Label();
            menuScoreLabel = new Label();
            menuPlayerLabel = new Label();
            gamePanel = new Panel();
            scoreLabel = new Label();
            levelCompletePanel = new Panel();
            levelCompleteNextButton = new Button();
            levelCompleteScoreLabel = new Label();
            levelCompleteTitleLabel = new Label();
            shuffleButton = new Button();
            backButton = new Button();
            hintButton = new Button();
            timerLabel = new Label();
            messageLabel = new Label();
            wordTextBox = new TextBox();
            menuPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            playerInfoPanel.SuspendLayout();
            gamePanel.SuspendLayout();
            levelCompletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackgroundImage = Properties.Resources.background;
            menuPanel.BackgroundImageLayout = ImageLayout.Stretch;
            menuPanel.Controls.Add(titleLabel);
            menuPanel.Controls.Add(endlessButton);
            menuPanel.Controls.Add(campaignButton);
            menuPanel.Controls.Add(menuStrip1);
            menuPanel.Controls.Add(playerInfoPanel);
            menuPanel.Cursor = Cursors.Hand;
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(532, 763);
            menuPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(0, 189);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(550, 60);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Wordscapes RO";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endlessButton
            // 
            endlessButton.BackColor = SystemColors.GradientActiveCaption;
            endlessButton.FlatStyle = FlatStyle.Flat;
            endlessButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            endlessButton.ForeColor = SystemColors.Control;
            endlessButton.Location = new Point(175, 350);
            endlessButton.Name = "endlessButton";
            endlessButton.Size = new Size(200, 50);
            endlessButton.TabIndex = 1;
            endlessButton.Text = "Endless";
            endlessButton.UseVisualStyleBackColor = false;
            endlessButton.Click += endlessButton_Click;
            // 
            // campaignButton
            // 
            campaignButton.BackColor = SystemColors.GradientActiveCaption;
            campaignButton.FlatStyle = FlatStyle.Flat;
            campaignButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            campaignButton.ForeColor = SystemColors.Control;
            campaignButton.Location = new Point(175, 280);
            campaignButton.Name = "campaignButton";
            campaignButton.Size = new Size(200, 50);
            campaignButton.TabIndex = 0;
            campaignButton.Text = "Campaign";
            campaignButton.UseVisualStyleBackColor = false;
            campaignButton.Click += campaignButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
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
            // playerInfoPanel
            // 
            playerInfoPanel.BackColor = Color.AliceBlue;
            playerInfoPanel.Controls.Add(menuEndlessScoreLabel);
            playerInfoPanel.Controls.Add(menuLevelLabel);
            playerInfoPanel.Controls.Add(menuScoreLabel);
            playerInfoPanel.Controls.Add(menuPlayerLabel);
            playerInfoPanel.Location = new Point(175, 427);
            playerInfoPanel.Name = "playerInfoPanel";
            playerInfoPanel.Size = new Size(201, 115);
            playerInfoPanel.TabIndex = 8;
            // 
            // menuEndlessScoreLabel
            // 
            menuEndlessScoreLabel.AutoSize = true;
            menuEndlessScoreLabel.BackColor = Color.Transparent;
            menuEndlessScoreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuEndlessScoreLabel.ForeColor = SystemColors.ActiveCaption;
            menuEndlessScoreLabel.Location = new Point(10, 70);
            menuEndlessScoreLabel.Name = "menuEndlessScoreLabel";
            menuEndlessScoreLabel.Size = new Size(78, 20);
            menuEndlessScoreLabel.TabIndex = 6;
            menuEndlessScoreLabel.Text = "Endless: 0";
            // 
            // menuLevelLabel
            // 
            menuLevelLabel.AutoSize = true;
            menuLevelLabel.BackColor = Color.Transparent;
            menuLevelLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuLevelLabel.ForeColor = SystemColors.ActiveCaption;
            menuLevelLabel.Location = new Point(10, 30);
            menuLevelLabel.Name = "menuLevelLabel";
            menuLevelLabel.Size = new Size(62, 20);
            menuLevelLabel.TabIndex = 4;
            menuLevelLabel.Text = "Nivel: 1";
            // 
            // menuScoreLabel
            // 
            menuScoreLabel.AutoSize = true;
            menuScoreLabel.BackColor = Color.Transparent;
            menuScoreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuScoreLabel.ForeColor = SystemColors.ActiveCaption;
            menuScoreLabel.Location = new Point(10, 50);
            menuScoreLabel.Name = "menuScoreLabel";
            menuScoreLabel.Size = new Size(93, 20);
            menuScoreLabel.TabIndex = 3;
            menuScoreLabel.Text = "Scor total: 0";
            // 
            // menuPlayerLabel
            // 
            menuPlayerLabel.AutoSize = true;
            menuPlayerLabel.BackColor = Color.Transparent;
            menuPlayerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuPlayerLabel.ForeColor = SystemColors.ActiveCaption;
            menuPlayerLabel.Location = new Point(10, 10);
            menuPlayerLabel.Name = "menuPlayerLabel";
            menuPlayerLabel.Size = new Size(104, 20);
            menuPlayerLabel.TabIndex = 2;
            menuPlayerLabel.Text = "Player: Player";
            // 
            // gamePanel
            // 
            gamePanel.BackgroundImage = Properties.Resources.background1;
            gamePanel.BackgroundImageLayout = ImageLayout.Stretch;
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(levelCompletePanel);
            gamePanel.Controls.Add(shuffleButton);
            gamePanel.Controls.Add(backButton);
            gamePanel.Controls.Add(hintButton);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(messageLabel);
            gamePanel.Controls.Add(wordTextBox);
            gamePanel.Dock = DockStyle.Fill;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(532, 763);
            gamePanel.TabIndex = 2;
            gamePanel.Visible = false;
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.ForeColor = SystemColors.ButtonHighlight;
            scoreLabel.Location = new Point(332, 55);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(188, 30);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Scor: 0000";
            // 
            // levelCompletePanel
            // 
            levelCompletePanel.BackColor = Color.RoyalBlue;
            levelCompletePanel.Controls.Add(levelCompleteNextButton);
            levelCompletePanel.Controls.Add(levelCompleteScoreLabel);
            levelCompletePanel.Controls.Add(levelCompleteTitleLabel);
            levelCompletePanel.Location = new Point(135, 221);
            levelCompletePanel.Name = "levelCompletePanel";
            levelCompletePanel.Size = new Size(260, 200);
            levelCompletePanel.TabIndex = 9;
            levelCompletePanel.Visible = false;
            // 
            // levelCompleteNextButton
            // 
            levelCompleteNextButton.Location = new Point(84, 150);
            levelCompleteNextButton.Name = "levelCompleteNextButton";
            levelCompleteNextButton.Size = new Size(94, 29);
            levelCompleteNextButton.TabIndex = 2;
            levelCompleteNextButton.Text = "Next";
            levelCompleteNextButton.UseVisualStyleBackColor = true;
            levelCompleteNextButton.Click += levelCompleteNextButton_Click;
            // 
            // levelCompleteScoreLabel
            // 
            levelCompleteScoreLabel.AutoSize = true;
            levelCompleteScoreLabel.ForeColor = Color.White;
            levelCompleteScoreLabel.Location = new Point(50, 59);
            levelCompleteScoreLabel.Name = "levelCompleteScoreLabel";
            levelCompleteScoreLabel.Size = new Size(41, 20);
            levelCompleteScoreLabel.TabIndex = 1;
            levelCompleteScoreLabel.Text = "Scor:";
            // 
            // levelCompleteTitleLabel
            // 
            levelCompleteTitleLabel.AutoSize = true;
            levelCompleteTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levelCompleteTitleLabel.ForeColor = Color.White;
            levelCompleteTitleLabel.Location = new Point(43, 14);
            levelCompleteTitleLabel.Name = "levelCompleteTitleLabel";
            levelCompleteTitleLabel.Size = new Size(172, 31);
            levelCompleteTitleLabel.TabIndex = 0;
            levelCompleteTitleLabel.Text = "Nivel complet!";
            // 
            // shuffleButton
            // 
            shuffleButton.BackColor = Color.Transparent;
            shuffleButton.BackgroundImage = Properties.Resources.shuffle;
            shuffleButton.BackgroundImageLayout = ImageLayout.Stretch;
            shuffleButton.FlatAppearance.BorderSize = 0;
            shuffleButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            shuffleButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            shuffleButton.FlatStyle = FlatStyle.Flat;
            shuffleButton.Location = new Point(460, 625);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(60, 60);
            shuffleButton.TabIndex = 8;
            shuffleButton.TabStop = false;
            shuffleButton.UseVisualStyleBackColor = false;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImage = Properties.Resources.back1;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(12, 691);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 60);
            backButton.TabIndex = 7;
            backButton.TabStop = false;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // hintButton
            // 
            hintButton.BackColor = Color.Transparent;
            hintButton.BackgroundImage = Properties.Resources.hint;
            hintButton.BackgroundImageLayout = ImageLayout.Stretch;
            hintButton.FlatAppearance.BorderSize = 0;
            hintButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hintButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hintButton.FlatStyle = FlatStyle.Flat;
            hintButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            hintButton.ForeColor = SystemColors.ButtonHighlight;
            hintButton.Location = new Point(460, 691);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(60, 60);
            hintButton.TabIndex = 6;
            hintButton.TabStop = false;
            hintButton.UseVisualStyleBackColor = false;
            hintButton.Click += hintButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = SystemColors.ButtonHighlight;
            timerLabel.Location = new Point(12, 55);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(150, 30);
            timerLabel.TabIndex = 5;
            timerLabel.Text = "Timp: 0";
            timerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // messageLabel
            // 
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.ForeColor = SystemColors.ButtonHighlight;
            messageLabel.Location = new Point(155, 100);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(240, 30);
            messageLabel.TabIndex = 4;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(200, 500);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(150, 27);
            wordTextBox.TabIndex = 1;
            wordTextBox.KeyDown += WordTextBox_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 763);
            Controls.Add(gamePanel);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Wordscapes";
            Load += Form1_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            playerInfoPanel.ResumeLayout(false);
            playerInfoPanel.PerformLayout();
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            levelCompletePanel.ResumeLayout(false);
            levelCompletePanel.PerformLayout();
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
        private Label titleLabel;
        private Panel playerInfoPanel;
        private Panel levelCompletePanel;
        private Button levelCompleteNextButton;
        private Label levelCompleteScoreLabel;
        private Label levelCompleteTitleLabel;
    }
}
