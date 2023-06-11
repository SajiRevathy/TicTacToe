namespace TicTacToeAssignment
{
    partial class StartForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.StartGameButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Xlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Olabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerTextBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(506, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "VS";
            // 
            // StartGameButton1
            // 
            this.StartGameButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton1.Location = new System.Drawing.Point(449, 405);
            this.StartGameButton1.Name = "StartGameButton1";
            this.StartGameButton1.Size = new System.Drawing.Size(175, 48);
            this.StartGameButton1.TabIndex = 5;
            this.StartGameButton1.Text = "START GAME";
            this.StartGameButton1.UseVisualStyleBackColor = true;
            this.StartGameButton1.Click += new System.EventHandler(this.StartGameButtonClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Xlabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.playerTextBox1);
            this.panel1.Location = new System.Drawing.Point(165, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 160);
            this.panel1.TabIndex = 6;
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(52, 60);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(61, 20);
            this.Xlabel.TabIndex = 7;
            this.Xlabel.Text = "Player1";
            this.Xlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerTextBox1
            // 
            this.playerTextBox1.Location = new System.Drawing.Point(47, 92);
            this.playerTextBox1.Name = "playerTextBox1";
            this.playerTextBox1.Size = new System.Drawing.Size(117, 26);
            this.playerTextBox1.TabIndex = 0;
            this.playerTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Olabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.playerTextBox2);
            this.panel2.Location = new System.Drawing.Point(683, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 160);
            this.panel2.TabIndex = 8;
            // 
            // Olabel
            // 
            this.Olabel.AutoSize = true;
            this.Olabel.Location = new System.Drawing.Point(67, 60);
            this.Olabel.Name = "Olabel";
            this.Olabel.Size = new System.Drawing.Size(61, 20);
            this.Olabel.TabIndex = 8;
            this.Olabel.Text = "Player2";
            this.Olabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "O";
            // 
            // playerTextBox2
            // 
            this.playerTextBox2.Location = new System.Drawing.Point(60, 92);
            this.playerTextBox2.Name = "playerTextBox2";
            this.playerTextBox2.Size = new System.Drawing.Size(117, 26);
            this.playerTextBox2.TabIndex = 0;
            this.playerTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BackgroundImage = global::TicTacToeAssignment.Properties.Resources.cool_geometric_triangular_figure_neon_laser_light_great_backgrounds_wallpapers;
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartGameButton1);
            this.Controls.Add(this.label2);
            this.Name = "StartForm";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartGameButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Olabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerTextBox2;
    }
}