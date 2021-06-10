namespace Biblioteka
{
    partial class Clanovi
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
            this.listBoxClanovi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDodajClana = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrezimeClana = new System.Windows.Forms.TextBox();
            this.textBoxImeClana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxClanovi
            // 
            this.listBoxClanovi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxClanovi.FormattingEnabled = true;
            this.listBoxClanovi.ItemHeight = 18;
            this.listBoxClanovi.Location = new System.Drawing.Point(672, 17);
            this.listBoxClanovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxClanovi.Name = "listBoxClanovi";
            this.listBoxClanovi.Size = new System.Drawing.Size(416, 400);
            this.listBoxClanovi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.buttonDodajClana);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBoxPrezimeClana);
            this.groupBox1.Controls.Add(this.textBoxImeClana);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(616, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novog clana";
            // 
            // buttonDodajClana
            // 
            this.buttonDodajClana.Location = new System.Drawing.Point(438, 361);
            this.buttonDodajClana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodajClana.Name = "buttonDodajClana";
            this.buttonDodajClana.Size = new System.Drawing.Size(112, 32);
            this.buttonDodajClana.TabIndex = 6;
            this.buttonDodajClana.Text = "Dodaj clana";
            this.buttonDodajClana.UseVisualStyleBackColor = true;
            this.buttonDodajClana.Click += new System.EventHandler(this.DodajClana);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 309);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(453, 24);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxPrezimeClana
            // 
            this.textBoxPrezimeClana.Location = new System.Drawing.Point(36, 191);
            this.textBoxPrezimeClana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezimeClana.Name = "textBoxPrezimeClana";
            this.textBoxPrezimeClana.Size = new System.Drawing.Size(451, 24);
            this.textBoxPrezimeClana.TabIndex = 4;
            // 
            // textBoxImeClana
            // 
            this.textBoxImeClana.Location = new System.Drawing.Point(36, 97);
            this.textBoxImeClana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxImeClana.Name = "textBoxImeClana";
            this.textBoxImeClana.Size = new System.Drawing.Size(451, 24);
            this.textBoxImeClana.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime clana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime clana";
            // 
            // Clanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxClanovi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clanovi";
            this.Text = "Clanovi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClanovi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDodajClana;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxPrezimeClana;
        private System.Windows.Forms.TextBox textBoxImeClana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}