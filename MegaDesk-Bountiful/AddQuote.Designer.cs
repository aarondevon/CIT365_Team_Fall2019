namespace MegaDesk_Sawyer
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.MainMenu = new System.Windows.Forms.Button();
            this.CreateQuote = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.DeskMaterial = new System.Windows.Forms.ComboBox();
            this.labelRushDays = new System.Windows.Forms.Label();
            this.Rush = new System.Windows.Forms.ComboBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxDrawers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.White;
            this.MainMenu.Location = new System.Drawing.Point(12, 20);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(165, 60);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "&Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // CreateQuote
            // 
            this.CreateQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.CreateQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateQuote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuote.ForeColor = System.Drawing.Color.White;
            this.CreateQuote.Location = new System.Drawing.Point(12, 105);
            this.CreateQuote.Name = "CreateQuote";
            this.CreateQuote.Size = new System.Drawing.Size(165, 60);
            this.CreateQuote.TabIndex = 1;
            this.CreateQuote.Text = "Create &Quote";
            this.CreateQuote.UseVisualStyleBackColor = false;
            this.CreateQuote.Click += new System.EventHandler(this.CreateQuote_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(230, 92);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(60, 21);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width:";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(230, 125);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(64, 21);
            this.labelDepth.TabIndex = 3;
            this.labelDepth.Text = "Depth:";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(230, 193);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(79, 21);
            this.labelMaterial.TabIndex = 7;
            this.labelMaterial.Text = "Material:";
            // 
            // DeskMaterial
            // 
            this.DeskMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterial.FormattingEnabled = true;
            this.DeskMaterial.Location = new System.Drawing.Point(354, 185);
            this.DeskMaterial.Name = "DeskMaterial";
            this.DeskMaterial.Size = new System.Drawing.Size(204, 29);
            this.DeskMaterial.TabIndex = 8;
            // 
            // labelRushDays
            // 
            this.labelRushDays.AutoSize = true;
            this.labelRushDays.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRushDays.Location = new System.Drawing.Point(230, 228);
            this.labelRushDays.Name = "labelRushDays";
            this.labelRushDays.Size = new System.Drawing.Size(50, 21);
            this.labelRushDays.TabIndex = 9;
            this.labelRushDays.Text = "Rush:";
            // 
            // Rush
            // 
            this.Rush.BackColor = System.Drawing.Color.White;
            this.Rush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rush.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rush.FormattingEnabled = true;
            this.Rush.Location = new System.Drawing.Point(354, 220);
            this.Rush.Name = "Rush";
            this.Rush.Size = new System.Drawing.Size(204, 29);
            this.Rush.TabIndex = 10;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(230, 26);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(95, 21);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(230, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(93, 21);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(354, 20);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(204, 27);
            this.textBoxFirstName.TabIndex = 13;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(354, 53);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(204, 27);
            this.textBoxLastName.TabIndex = 14;
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawers.Location = new System.Drawing.Point(230, 158);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(77, 21);
            this.labelDrawers.TabIndex = 15;
            this.labelDrawers.Text = "Drawers:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWidth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(354, 86);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(204, 27);
            this.textBoxWidth.TabIndex = 17;
            this.textBoxWidth.Text = "0";
            this.textBoxWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxWidth_KeyUp);
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepth.Location = new System.Drawing.Point(354, 119);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(204, 27);
            this.textBoxDepth.TabIndex = 18;
            this.textBoxDepth.Text = "0";
            this.textBoxDepth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDepth_KeyUp);
            // 
            // textBoxDrawers
            // 
            this.textBoxDrawers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrawers.Location = new System.Drawing.Point(354, 152);
            this.textBoxDrawers.Name = "textBoxDrawers";
            this.textBoxDrawers.Size = new System.Drawing.Size(204, 27);
            this.textBoxDrawers.TabIndex = 19;
            this.textBoxDrawers.Text = "0";
            this.textBoxDrawers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDrawers_KeyUp);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.textBoxDrawers);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.Rush);
            this.Controls.Add(this.labelRushDays);
            this.Controls.Add(this.DeskMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.CreateQuote);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox DeskMaterial;
        private System.Windows.Forms.Label labelRushDays;
        private System.Windows.Forms.ComboBox Rush;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxDrawers;
    }
}