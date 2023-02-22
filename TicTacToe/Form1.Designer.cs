
namespace Program4
{
    partial class TicTacToeForm
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
            this.label00 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tiesCountLabel = new System.Windows.Forms.Label();
            this.player2WinsCountLabel = new System.Windows.Forms.Label();
            this.player1WinsCountLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
            this.player2WinsLabel = new System.Windows.Forms.Label();
            this.player1WinsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label00
            // 
            this.label00.BackColor = System.Drawing.SystemColors.Control;
            this.label00.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label00.Location = new System.Drawing.Point(69, 29);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(110, 141);
            this.label00.TabIndex = 0;
            this.label00.Tag = "1";
            this.label00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label00.Click += new System.EventHandler(this.Space_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(182, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 421);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 135);
            this.label10.TabIndex = 2;
            this.label10.Tag = "4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Space_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(66, 325);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 125);
            this.label20.TabIndex = 3;
            this.label20.Tag = "7";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.Space_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(198, 322);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 128);
            this.label21.TabIndex = 7;
            this.label21.Tag = "8";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.Space_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 143);
            this.label11.TabIndex = 6;
            this.label11.Tag = "5";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.Space_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(336, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 421);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label01
            // 
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.Location = new System.Drawing.Point(198, 29);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(132, 141);
            this.label01.TabIndex = 4;
            this.label01.Tag = "2";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label01.Click += new System.EventHandler(this.Space_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(352, 322);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 128);
            this.label22.TabIndex = 11;
            this.label22.Tag = "9";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.Space_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 136);
            this.label12.TabIndex = 10;
            this.label12.Tag = "6";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.Space_Click);
            // 
            // label02
            // 
            this.label02.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.Location = new System.Drawing.Point(352, 29);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(132, 141);
            this.label02.TabIndex = 8;
            this.label02.Tag = "3";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label02.Click += new System.EventHandler(this.Space_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tiesCountLabel);
            this.groupBox1.Controls.Add(this.player2WinsCountLabel);
            this.groupBox1.Controls.Add(this.player1WinsCountLabel);
            this.groupBox1.Controls.Add(this.tiesLabel);
            this.groupBox1.Controls.Add(this.player2WinsLabel);
            this.groupBox1.Controls.Add(this.player1WinsLabel);
            this.groupBox1.Location = new System.Drawing.Point(559, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // tiesCountLabel
            // 
            this.tiesCountLabel.AutoSize = true;
            this.tiesCountLabel.Location = new System.Drawing.Point(155, 143);
            this.tiesCountLabel.Name = "tiesCountLabel";
            this.tiesCountLabel.Size = new System.Drawing.Size(0, 17);
            this.tiesCountLabel.TabIndex = 5;
            // 
            // player2WinsCountLabel
            // 
            this.player2WinsCountLabel.AutoSize = true;
            this.player2WinsCountLabel.Location = new System.Drawing.Point(155, 94);
            this.player2WinsCountLabel.Name = "player2WinsCountLabel";
            this.player2WinsCountLabel.Size = new System.Drawing.Size(0, 17);
            this.player2WinsCountLabel.TabIndex = 4;
            // 
            // player1WinsCountLabel
            // 
            this.player1WinsCountLabel.AutoSize = true;
            this.player1WinsCountLabel.Location = new System.Drawing.Point(152, 45);
            this.player1WinsCountLabel.Name = "player1WinsCountLabel";
            this.player1WinsCountLabel.Size = new System.Drawing.Size(0, 17);
            this.player1WinsCountLabel.TabIndex = 3;
            // 
            // tiesLabel
            // 
            this.tiesLabel.AutoSize = true;
            this.tiesLabel.Location = new System.Drawing.Point(106, 143);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(39, 17);
            this.tiesLabel.TabIndex = 2;
            this.tiesLabel.Text = "Ties:";
            // 
            // player2WinsLabel
            // 
            this.player2WinsLabel.AutoSize = true;
            this.player2WinsLabel.Location = new System.Drawing.Point(46, 94);
            this.player2WinsLabel.Name = "player2WinsLabel";
            this.player2WinsLabel.Size = new System.Drawing.Size(99, 17);
            this.player2WinsLabel.TabIndex = 1;
            this.player2WinsLabel.Text = "Player 2 Wins:";
            // 
            // player1WinsLabel
            // 
            this.player1WinsLabel.AutoSize = true;
            this.player1WinsLabel.Location = new System.Drawing.Point(42, 45);
            this.player1WinsLabel.Name = "player1WinsLabel";
            this.player1WinsLabel.Size = new System.Drawing.Size(103, 17);
            this.player1WinsLabel.TabIndex = 0;
            this.player1WinsLabel.Text = "Player 1 Wins: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gameStatusLabel);
            this.groupBox2.Location = new System.Drawing.Point(66, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Status";
            // 
            // gameStatusLabel
            // 
            this.gameStatusLabel.AutoSize = true;
            this.gameStatusLabel.Location = new System.Drawing.Point(22, 32);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.gameStatusLabel.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(63, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(421, 10);
            this.label15.TabIndex = 14;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(63, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(421, 10);
            this.label16.TabIndex = 15;
            this.label16.Text = "label16";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(559, 47);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(167, 41);
            this.startGameButton.TabIndex = 16;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 744);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label00);
            this.Name = "TicTacToeForm";
            this.Text = "Tic Tac Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tiesLabel;
        private System.Windows.Forms.Label player2WinsLabel;
        private System.Windows.Forms.Label player1WinsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.Windows.Forms.Label player1WinsCountLabel;
        private System.Windows.Forms.Label player2WinsCountLabel;
        private System.Windows.Forms.Label tiesCountLabel;
    }
}

