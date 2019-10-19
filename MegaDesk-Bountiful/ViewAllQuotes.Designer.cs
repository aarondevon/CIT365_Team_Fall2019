namespace MegaDesk_Hargan
{
    partial class ViewAllQuotes
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
            this.labelQuotes = new System.Windows.Forms.Label();
            this.labelRushValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuotes
            // 
            this.labelQuotes.AutoSize = true;
            this.labelQuotes.Location = new System.Drawing.Point(100, 95);
            this.labelQuotes.Name = "labelQuotes";
            this.labelQuotes.Size = new System.Drawing.Size(46, 17);
            this.labelQuotes.TabIndex = 0;
            this.labelQuotes.Text = "label1";
            // 
            // labelRushValue
            // 
            this.labelRushValue.AutoSize = true;
            this.labelRushValue.Location = new System.Drawing.Point(218, 95);
            this.labelRushValue.Name = "labelRushValue";
            this.labelRushValue.Size = new System.Drawing.Size(46, 17);
            this.labelRushValue.TabIndex = 1;
            this.labelRushValue.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRushValue);
            this.Controls.Add(this.labelQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuotes;
        private System.Windows.Forms.Label labelRushValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}