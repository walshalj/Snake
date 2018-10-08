namespace Snake_Game
{
    partial class Scores
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
            this.txtBox_Scores = new System.Windows.Forms.TextBox();
            this.lbl_scoreList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Scores
            // 
            this.txtBox_Scores.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_Scores.Location = new System.Drawing.Point(12, 32);
            this.txtBox_Scores.Multiline = true;
            this.txtBox_Scores.Name = "txtBox_Scores";
            this.txtBox_Scores.ReadOnly = true;
            this.txtBox_Scores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Scores.Size = new System.Drawing.Size(143, 248);
            this.txtBox_Scores.TabIndex = 0;
            // 
            // lbl_scoreList
            // 
            this.lbl_scoreList.AutoSize = true;
            this.lbl_scoreList.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreList.Location = new System.Drawing.Point(12, 9);
            this.lbl_scoreList.Name = "lbl_scoreList";
            this.lbl_scoreList.Size = new System.Drawing.Size(70, 18);
            this.lbl_scoreList.TabIndex = 1;
            this.lbl_scoreList.Text = "User Scores";
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 308);
            this.Controls.Add(this.lbl_scoreList);
            this.Controls.Add(this.txtBox_Scores);
            this.Name = "Scores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.frm_Scores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Scores;
        private System.Windows.Forms.Label lbl_scoreList;
    }
}