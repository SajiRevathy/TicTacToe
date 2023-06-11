namespace TicTacToeAssignment
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OnePlayerButton = new System.Windows.Forms.Button();
            this.TwoPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(244, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 110);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tic Tac Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(407, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Your Gaming Mode";
            // 
            // OnePlayerButton
            // 
            this.OnePlayerButton.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlayerButton.Location = new System.Drawing.Point(345, 398);
            this.OnePlayerButton.Name = "OnePlayerButton";
            this.OnePlayerButton.Size = new System.Drawing.Size(140, 60);
            this.OnePlayerButton.TabIndex = 5;
            this.OnePlayerButton.Text = "Play with Computer";
            this.OnePlayerButton.UseVisualStyleBackColor = true;
            this.OnePlayerButton.Click += new System.EventHandler(this.OnePlayerButton_Click);
            // 
            // TwoPlayerButton
            // 
            this.TwoPlayerButton.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayerButton.Location = new System.Drawing.Point(586, 398);
            this.TwoPlayerButton.Name = "TwoPlayerButton";
            this.TwoPlayerButton.Size = new System.Drawing.Size(140, 60);
            this.TwoPlayerButton.TabIndex = 6;
            this.TwoPlayerButton.Text = "Play with Friend";
            this.TwoPlayerButton.UseVisualStyleBackColor = true;
            this.TwoPlayerButton.Click += new System.EventHandler(this.TwoPlayerButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.TwoPlayerButton);
            this.Controls.Add(this.OnePlayerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OnePlayerButton;
        private System.Windows.Forms.Button TwoPlayerButton;
    }
}