namespace Snake_Game
{
    partial class frm_snakeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picture_Box = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.score_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcuts_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_userScore = new System.Windows.Forms.Label();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.pleaseEnterYourNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTxtBox_userName = new System.Windows.Forms.ToolStripTextBox();
            this.lbl_iMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_Box
            // 
            this.picture_Box.BackColor = System.Drawing.SystemColors.Window;
            this.picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_Box.Location = new System.Drawing.Point(51, 76);
            this.picture_Box.Margin = new System.Windows.Forms.Padding(2);
            this.picture_Box.Name = "picture_Box";
            this.picture_Box.Size = new System.Drawing.Size(200, 200);
            this.picture_Box.TabIndex = 0;
            this.picture_Box.TabStop = false;
            this.picture_Box.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Box_Paint);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pleaseEnterYourNameToolStripMenuItem1,
            this.toolStripTxtBox_userName});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(312, 26);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.score_ToolStripMenuItem,
            this.shortcuts_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // score_ToolStripMenuItem
            // 
            this.score_ToolStripMenuItem.Name = "score_ToolStripMenuItem";
            this.score_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.score_ToolStripMenuItem.Text = "Score";
            this.score_ToolStripMenuItem.Click += new System.EventHandler(this.score_ToolStripMenuItem_Click);
            // 
            // shortcuts_ToolStripMenuItem
            // 
            this.shortcuts_ToolStripMenuItem.Name = "shortcuts_ToolStripMenuItem";
            this.shortcuts_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shortcuts_ToolStripMenuItem.Text = "Shortcuts";
            this.shortcuts_ToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exit_ToolStripMenuItem.Text = "Exit";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click_1);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Score.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(48, 49);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(53, 18);
            this.lbl_Score.TabIndex = 6;
            this.lbl_Score.Text = "SCORE:";
            // 
            // lbl_userScore
            // 
            this.lbl_userScore.AutoSize = true;
            this.lbl_userScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_userScore.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userScore.Location = new System.Drawing.Point(98, 46);
            this.lbl_userScore.Name = "lbl_userScore";
            this.lbl_userScore.Size = new System.Drawing.Size(19, 22);
            this.lbl_userScore.TabIndex = 7;
            this.lbl_userScore.Text = "0";
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.MintCream;
            this.btn_newGame.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.Location = new System.Drawing.Point(115, 292);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(85, 26);
            this.btn_newGame.TabIndex = 8;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // pleaseEnterYourNameToolStripMenuItem1
            // 
            this.pleaseEnterYourNameToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pleaseEnterYourNameToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseEnterYourNameToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pleaseEnterYourNameToolStripMenuItem1.Name = "pleaseEnterYourNameToolStripMenuItem1";
            this.pleaseEnterYourNameToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.pleaseEnterYourNameToolStripMenuItem1.Text = "Please enter your name:";
            // 
            // toolStripTxtBox_userName
            // 
            this.toolStripTxtBox_userName.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTxtBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxtBox_userName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTxtBox_userName.Name = "toolStripTxtBox_userName";
            this.toolStripTxtBox_userName.Size = new System.Drawing.Size(100, 22);
            // 
            // lbl_iMsg
            // 
            this.lbl_iMsg.AutoSize = true;
            this.lbl_iMsg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_iMsg.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iMsg.Location = new System.Drawing.Point(153, 49);
            this.lbl_iMsg.Name = "lbl_iMsg";
            this.lbl_iMsg.Size = new System.Drawing.Size(0, 18);
            this.lbl_iMsg.TabIndex = 9;
            // 
            // frm_snakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(312, 345);
            this.Controls.Add(this.lbl_iMsg);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.lbl_userScore);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.picture_Box);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_snakeGame";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_snakeGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_snakeGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Box;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem score_ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_userScore;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.ToolStripMenuItem shortcuts_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleaseEnterYourNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtBox_userName;
        private System.Windows.Forms.Label lbl_iMsg;
    }
}

