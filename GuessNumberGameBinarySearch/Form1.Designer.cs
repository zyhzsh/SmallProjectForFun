namespace GuessNumberGameBinarySearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGuess = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick up your pen and write a positive integer in a paper.(Range Between 1~4000000" +
    "000)";
            // 
            // btnStartGuess
            // 
            this.btnStartGuess.Location = new System.Drawing.Point(49, 51);
            this.btnStartGuess.Name = "btnStartGuess";
            this.btnStartGuess.Size = new System.Drawing.Size(219, 29);
            this.btnStartGuess.TabIndex = 1;
            this.btnStartGuess.Text = "Start~!";
            this.btnStartGuess.UseVisualStyleBackColor = true;
            this.btnStartGuess.Click += new System.EventHandler(this.btnStartGuess_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(335, 59);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(0, 13);
            this.lbresult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 104);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btnStartGuess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGuess;
        private System.Windows.Forms.Label lbresult;
    }
}

