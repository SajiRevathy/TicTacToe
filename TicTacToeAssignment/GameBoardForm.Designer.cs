namespace TicTacToeAssignment
{
    partial class GameBoardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Secondlabel = new System.Windows.Forms.Label();
            this.Firstlabel = new System.Windows.Forms.Label();
            this.GameButton7 = new System.Windows.Forms.Button();
            this.GameButton8 = new System.Windows.Forms.Button();
            this.GameButton9 = new System.Windows.Forms.Button();
            this.GameButton4 = new System.Windows.Forms.Button();
            this.GameButton5 = new System.Windows.Forms.Button();
            this.GameButton6 = new System.Windows.Forms.Button();
            this.GameButton3 = new System.Windows.Forms.Button();
            this.GameButton2 = new System.Windows.Forms.Button();
            this.GameButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.AItimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Secondlabel);
            this.panel1.Controls.Add(this.Firstlabel);
            this.panel1.Location = new System.Drawing.Point(82, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 175);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // Secondlabel
            // 
            this.Secondlabel.AutoSize = true;
            this.Secondlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondlabel.Location = new System.Drawing.Point(64, 104);
            this.Secondlabel.Name = "Secondlabel";
            this.Secondlabel.Size = new System.Drawing.Size(65, 22);
            this.Secondlabel.TabIndex = 1;
            this.Secondlabel.Text = "0 Wins";
            // 
            // Firstlabel
            // 
            this.Firstlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Firstlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstlabel.Location = new System.Drawing.Point(0, 0);
            this.Firstlabel.Name = "Firstlabel";
            this.Firstlabel.Size = new System.Drawing.Size(198, 171);
            this.Firstlabel.TabIndex = 0;
            this.Firstlabel.Text = "Player 1";
            this.Firstlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameButton7
            // 
            this.GameButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton7.Location = new System.Drawing.Point(356, 336);
            this.GameButton7.Name = "GameButton7";
            this.GameButton7.Size = new System.Drawing.Size(118, 102);
            this.GameButton7.TabIndex = 20;
            this.GameButton7.UseVisualStyleBackColor = true;
            this.GameButton7.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton8
            // 
            this.GameButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton8.Location = new System.Drawing.Point(480, 336);
            this.GameButton8.Name = "GameButton8";
            this.GameButton8.Size = new System.Drawing.Size(118, 102);
            this.GameButton8.TabIndex = 19;
            this.GameButton8.UseVisualStyleBackColor = true;
            this.GameButton8.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton9
            // 
            this.GameButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton9.Location = new System.Drawing.Point(604, 336);
            this.GameButton9.Name = "GameButton9";
            this.GameButton9.Size = new System.Drawing.Size(118, 102);
            this.GameButton9.TabIndex = 18;
            this.GameButton9.UseVisualStyleBackColor = true;
            this.GameButton9.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton4
            // 
            this.GameButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton4.Location = new System.Drawing.Point(356, 231);
            this.GameButton4.Name = "GameButton4";
            this.GameButton4.Size = new System.Drawing.Size(118, 102);
            this.GameButton4.TabIndex = 17;
            this.GameButton4.UseVisualStyleBackColor = true;
            this.GameButton4.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton5
            // 
            this.GameButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton5.Location = new System.Drawing.Point(480, 231);
            this.GameButton5.Name = "GameButton5";
            this.GameButton5.Size = new System.Drawing.Size(118, 102);
            this.GameButton5.TabIndex = 16;
            this.GameButton5.UseVisualStyleBackColor = true;
            this.GameButton5.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton6
            // 
            this.GameButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton6.Location = new System.Drawing.Point(604, 231);
            this.GameButton6.Name = "GameButton6";
            this.GameButton6.Size = new System.Drawing.Size(118, 102);
            this.GameButton6.TabIndex = 15;
            this.GameButton6.UseVisualStyleBackColor = true;
            this.GameButton6.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton3
            // 
            this.GameButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton3.Location = new System.Drawing.Point(604, 126);
            this.GameButton3.Name = "GameButton3";
            this.GameButton3.Size = new System.Drawing.Size(118, 102);
            this.GameButton3.TabIndex = 14;
            this.GameButton3.UseVisualStyleBackColor = true;
            this.GameButton3.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton2
            // 
            this.GameButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton2.Location = new System.Drawing.Point(480, 126);
            this.GameButton2.Name = "GameButton2";
            this.GameButton2.Size = new System.Drawing.Size(118, 102);
            this.GameButton2.TabIndex = 13;
            this.GameButton2.UseVisualStyleBackColor = true;
            this.GameButton2.Click += new System.EventHandler(this.ClickButton);
            // 
            // GameButton1
            // 
            this.GameButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton1.Location = new System.Drawing.Point(356, 126);
            this.GameButton1.Name = "GameButton1";
            this.GameButton1.Size = new System.Drawing.Size(118, 102);
            this.GameButton1.TabIndex = 12;
            this.GameButton1.UseVisualStyleBackColor = true;
            this.GameButton1.Click += new System.EventHandler(this.ClickButton);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(788, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 175);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 Wins";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 171);
            this.label3.TabIndex = 0;
            this.label3.Text = "Computer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(462, 480);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(159, 41);
            this.button10.TabIndex = 22;
            this.button10.Text = "RESTART";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RestartButtonClick);
            // 
            // AItimer
            // 
            this.AItimer.Tick += new System.EventHandler(this.AIclickEvent);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeAssignment.Properties.Resources.web_gad087c4bf_1920;
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GameButton7);
            this.Controls.Add(this.GameButton8);
            this.Controls.Add(this.GameButton9);
            this.Controls.Add(this.GameButton4);
            this.Controls.Add(this.GameButton5);
            this.Controls.Add(this.GameButton6);
            this.Controls.Add(this.GameButton3);
            this.Controls.Add(this.GameButton2);
            this.Controls.Add(this.GameButton1);
            this.Controls.Add(this.panel1);
            this.Name = "GameBoardForm";
            this.Text = "GameBoardForm";
            this.Load += new System.EventHandler(this.GameBoardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Secondlabel;
        private System.Windows.Forms.Label Firstlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button GameButton7;
        public System.Windows.Forms.Button GameButton8;
        public System.Windows.Forms.Button GameButton9;
        public System.Windows.Forms.Button GameButton4;
        public System.Windows.Forms.Button GameButton5;
        public System.Windows.Forms.Button GameButton6;
        public System.Windows.Forms.Button GameButton3;
        public System.Windows.Forms.Button GameButton2;
        public System.Windows.Forms.Button GameButton1;
        public System.Windows.Forms.Timer AItimer;
    }
}