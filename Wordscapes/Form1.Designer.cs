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
            checkButton = new Button();
            menuPanel = new Panel();
            endlessButton = new Button();
            campaignButton = new Button();
            gamePanel = new Panel();
            hintButton = new Button();
            timerLabel = new Label();
            messageLabel = new Label();
            scoreLabel = new Label();
            lettersLabel = new Label();
            wordTextBox = new TextBox();
            menuPanel.SuspendLayout();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // checkButton
            // 
            checkButton.Location = new Point(210, 387);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(94, 29);
            checkButton.TabIndex = 0;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(endlessButton);
            menuPanel.Controls.Add(campaignButton);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(544, 663);
            menuPanel.TabIndex = 1;
            // 
            // endlessButton
            // 
            endlessButton.Location = new Point(210, 339);
            endlessButton.Name = "endlessButton";
            endlessButton.Size = new Size(94, 42);
            endlessButton.TabIndex = 1;
            endlessButton.Text = "Endless";
            endlessButton.UseVisualStyleBackColor = true;
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
            // gamePanel
            // 
            gamePanel.Controls.Add(hintButton);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(messageLabel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(lettersLabel);
            gamePanel.Controls.Add(wordTextBox);
            gamePanel.Controls.Add(checkButton);
            gamePanel.Dock = DockStyle.Fill;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(544, 663);
            gamePanel.TabIndex = 2;
            gamePanel.Visible = false;
            // 
            // hintButton
            // 
            hintButton.Location = new Point(433, 303);
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
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(229, 85);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 20);
            messageLabel.TabIndex = 4;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(472, 21);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(53, 20);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Scor: 0";
            // 
            // lettersLabel
            // 
            lettersLabel.AutoSize = true;
            lettersLabel.Location = new Point(199, 252);
            lettersLabel.Name = "lettersLabel";
            lettersLabel.Size = new Size(53, 20);
            lettersLabel.TabIndex = 2;
            lettersLabel.Text = "Letters";
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(199, 211);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(125, 27);
            wordTextBox.TabIndex = 1;
            wordTextBox.KeyDown += WordTextBox_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 663);
            Controls.Add(menuPanel);
            Controls.Add(gamePanel);
            Name = "Form1";
            Text = "Form1";
            menuPanel.ResumeLayout(false);
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button checkButton;
        private Panel menuPanel;
        private Panel gamePanel;
        private Button endlessButton;
        private Button campaignButton;
        private TextBox wordTextBox;
        private Label messageLabel;
        private Label scoreLabel;
        private Label lettersLabel;
        private Label timerLabel;
        private Button hintButton;
    }
}
