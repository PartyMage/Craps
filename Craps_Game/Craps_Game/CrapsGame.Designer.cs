namespace Craps_Game
{
    partial class CrapsGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DiceRoll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pointBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.thisPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Win = new System.Windows.Forms.Label();
            this.label_Losses = new System.Windows.Forms.Label();
            this.label_Rolls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Craps_Game.Properties.Resources.dice_2_512;
            this.pictureBox1.Location = new System.Drawing.Point(443, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Craps_Game.Properties.Resources.dice_1_512;
            this.pictureBox2.Location = new System.Drawing.Point(194, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // DiceRoll
            // 
            this.DiceRoll.Image = global::Craps_Game.Properties.Resources.dice_6_512;
            this.DiceRoll.Location = new System.Drawing.Point(351, 263);
            this.DiceRoll.Name = "DiceRoll";
            this.DiceRoll.Size = new System.Drawing.Size(75, 23);
            this.DiceRoll.TabIndex = 2;
            this.DiceRoll.Text = "Roll Dice";
            this.DiceRoll.UseVisualStyleBackColor = true;
            this.DiceRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 59);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Roll to play!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointBox
            // 
            this.pointBox.Location = new System.Drawing.Point(680, 71);
            this.pointBox.Name = "pointBox";
            this.pointBox.Size = new System.Drawing.Size(55, 20);
            this.pointBox.TabIndex = 4;
            this.pointBox.Text = "Point: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return to Player Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // thisPlayer
            // 
            this.thisPlayer.AutoSize = true;
            this.thisPlayer.Location = new System.Drawing.Point(680, 13);
            this.thisPlayer.Name = "thisPlayer";
            this.thisPlayer.Size = new System.Drawing.Size(36, 13);
            this.thisPlayer.TabIndex = 6;
            this.thisPlayer.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Losses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Rolls";
            // 
            // label_Win
            // 
            this.label_Win.AutoSize = true;
            this.label_Win.Location = new System.Drawing.Point(724, 208);
            this.label_Win.Name = "label_Win";
            this.label_Win.Size = new System.Drawing.Size(13, 13);
            this.label_Win.TabIndex = 10;
            this.label_Win.Text = "0";
            // 
            // label_Losses
            // 
            this.label_Losses.AutoSize = true;
            this.label_Losses.Location = new System.Drawing.Point(724, 241);
            this.label_Losses.Name = "label_Losses";
            this.label_Losses.Size = new System.Drawing.Size(13, 13);
            this.label_Losses.TabIndex = 11;
            this.label_Losses.Text = "0";
            // 
            // label_Rolls
            // 
            this.label_Rolls.AutoSize = true;
            this.label_Rolls.Location = new System.Drawing.Point(724, 273);
            this.label_Rolls.Name = "label_Rolls";
            this.label_Rolls.Size = new System.Drawing.Size(13, 13);
            this.label_Rolls.TabIndex = 12;
            this.label_Rolls.Text = "0";
            // 
            // CrapsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Rolls);
            this.Controls.Add(this.label_Losses);
            this.Controls.Add(this.label_Win);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thisPlayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pointBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DiceRoll);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CrapsGame";
            this.Text = "Craps Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DiceRoll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pointBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label thisPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Win;
        private System.Windows.Forms.Label label_Losses;
        private System.Windows.Forms.Label label_Rolls;
    }
}

