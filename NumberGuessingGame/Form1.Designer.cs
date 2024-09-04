namespace NumberGuessingGame
{
    partial class Form1
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
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.lbYou = new System.Windows.Forms.ListBox();
            this.lbPC = new System.Windows.Forms.ListBox();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(257, 73);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(85, 20);
            this.txtBoxNumber.TabIndex = 0;
            this.txtBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess a number between (1 - 10)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(348, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Min: 1, Max: 10)";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCheck.Location = new System.Drawing.Point(208, 144);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(91, 39);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lbYou
            // 
            this.lbYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYou.FormattingEnabled = true;
            this.lbYou.Location = new System.Drawing.Point(59, 124);
            this.lbYou.Name = "lbYou";
            this.lbYou.Size = new System.Drawing.Size(143, 121);
            this.lbYou.TabIndex = 4;
            // 
            // lbPC
            // 
            this.lbPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPC.FormattingEnabled = true;
            this.lbPC.Location = new System.Drawing.Point(305, 124);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(146, 121);
            this.lbPC.TabIndex = 5;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblYou.Location = new System.Drawing.Point(114, 106);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(31, 15);
            this.lblYou.TabIndex = 6;
            this.lblYou.Text = "You";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.Color.Red;
            this.lblPC.Location = new System.Drawing.Point(365, 106);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(25, 15);
            this.lblPC.TabIndex = 7;
            this.lblPC.Text = "PC";
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.Location = new System.Drawing.Point(205, 259);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(71, 13);
            this.lblGuessed.TabIndex = 8;
            this.lblGuessed.Text = "Guessed: 0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(205, 282);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score: 0";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcomeUser.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(511, 70);
            this.lblWelcomeUser.TabIndex = 10;
            this.lblWelcomeUser.Text = "lblWelcomeUser";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.Red;
            this.BtnReset.Location = new System.Drawing.Point(208, 189);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(91, 39);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 329);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.lbPC);
            this.Controls.Add(this.lbYou);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.ListBox lbYou;
        private System.Windows.Forms.ListBox lbPC;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Button BtnReset;
    }
}

