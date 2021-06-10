namespace Biblioteka
{
    partial class DodavanjeKnjige
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOstalo = new System.Windows.Forms.RadioButton();
            this.radioButtonKriminalistika = new System.Windows.Forms.RadioButton();
            this.radioButtonLjubavni = new System.Windows.Forms.RadioButton();
            this.radioButtonNaucnaFantastika = new System.Windows.Forms.RadioButton();
            this.textBoxNazivKnjige = new System.Windows.Forms.TextBox();
            this.textBoxImeAutora = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeAutora = new System.Windows.Forms.TextBox();
            this.numericUpDownMesec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDan = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGodina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDan = new System.Windows.Forms.Label();
            this.labelMesec = new System.Windows.Forms.Label();
            this.labelGodina = new System.Windows.Forms.Label();
            this.textBoxZanr = new System.Windows.Forms.TextBox();
            this.labelZanr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMesec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonOstalo);
            this.groupBox1.Controls.Add(this.radioButtonKriminalistika);
            this.groupBox1.Controls.Add(this.radioButtonLjubavni);
            this.groupBox1.Controls.Add(this.radioButtonNaucnaFantastika);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1092, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zanrovi";
            // 
            // radioButtonOstalo
            // 
            this.radioButtonOstalo.AutoSize = true;
            this.radioButtonOstalo.Location = new System.Drawing.Point(880, 26);
            this.radioButtonOstalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonOstalo.Name = "radioButtonOstalo";
            this.radioButtonOstalo.Size = new System.Drawing.Size(70, 22);
            this.radioButtonOstalo.TabIndex = 3;
            this.radioButtonOstalo.TabStop = true;
            this.radioButtonOstalo.Text = "Ostalo";
            this.radioButtonOstalo.UseVisualStyleBackColor = true;
            this.radioButtonOstalo.CheckedChanged += new System.EventHandler(this.radioButtonOstalo_CheckedChanged);
            // 
            // radioButtonKriminalistika
            // 
            this.radioButtonKriminalistika.AutoSize = true;
            this.radioButtonKriminalistika.Location = new System.Drawing.Point(678, 22);
            this.radioButtonKriminalistika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonKriminalistika.Name = "radioButtonKriminalistika";
            this.radioButtonKriminalistika.Size = new System.Drawing.Size(113, 22);
            this.radioButtonKriminalistika.TabIndex = 2;
            this.radioButtonKriminalistika.TabStop = true;
            this.radioButtonKriminalistika.Text = "Kriminalistika";
            this.radioButtonKriminalistika.UseVisualStyleBackColor = true;
            this.radioButtonKriminalistika.CheckedChanged += new System.EventHandler(this.radioButtonKriminalistika_CheckedChanged);
            // 
            // radioButtonLjubavni
            // 
            this.radioButtonLjubavni.AutoSize = true;
            this.radioButtonLjubavni.Location = new System.Drawing.Point(458, 22);
            this.radioButtonLjubavni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLjubavni.Name = "radioButtonLjubavni";
            this.radioButtonLjubavni.Size = new System.Drawing.Size(79, 22);
            this.radioButtonLjubavni.TabIndex = 1;
            this.radioButtonLjubavni.TabStop = true;
            this.radioButtonLjubavni.Text = "Ljubavni";
            this.radioButtonLjubavni.UseVisualStyleBackColor = true;
            this.radioButtonLjubavni.CheckedChanged += new System.EventHandler(this.radioButtonLjubavni_CheckedChanged);
            // 
            // radioButtonNaucnaFantastika
            // 
            this.radioButtonNaucnaFantastika.AutoSize = true;
            this.radioButtonNaucnaFantastika.Location = new System.Drawing.Point(129, 22);
            this.radioButtonNaucnaFantastika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNaucnaFantastika.Name = "radioButtonNaucnaFantastika";
            this.radioButtonNaucnaFantastika.Size = new System.Drawing.Size(144, 22);
            this.radioButtonNaucnaFantastika.TabIndex = 0;
            this.radioButtonNaucnaFantastika.TabStop = true;
            this.radioButtonNaucnaFantastika.Text = "Naucna fantastika";
            this.radioButtonNaucnaFantastika.UseVisualStyleBackColor = true;
            this.radioButtonNaucnaFantastika.CheckedChanged += new System.EventHandler(this.radioButtonNaucnaFantastika_CheckedChanged);
            // 
            // textBoxNazivKnjige
            // 
            this.textBoxNazivKnjige.Location = new System.Drawing.Point(261, 133);
            this.textBoxNazivKnjige.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazivKnjige.Name = "textBoxNazivKnjige";
            this.textBoxNazivKnjige.Size = new System.Drawing.Size(700, 24);
            this.textBoxNazivKnjige.TabIndex = 2;
            // 
            // textBoxImeAutora
            // 
            this.textBoxImeAutora.Location = new System.Drawing.Point(261, 191);
            this.textBoxImeAutora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxImeAutora.Name = "textBoxImeAutora";
            this.textBoxImeAutora.Size = new System.Drawing.Size(700, 24);
            this.textBoxImeAutora.TabIndex = 3;
            // 
            // textBoxPrezimeAutora
            // 
            this.textBoxPrezimeAutora.Location = new System.Drawing.Point(261, 246);
            this.textBoxPrezimeAutora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezimeAutora.Name = "textBoxPrezimeAutora";
            this.textBoxPrezimeAutora.Size = new System.Drawing.Size(700, 24);
            this.textBoxPrezimeAutora.TabIndex = 4;
            // 
            // numericUpDownMesec
            // 
            this.numericUpDownMesec.Location = new System.Drawing.Point(318, 356);
            this.numericUpDownMesec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMesec.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMesec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMesec.Name = "numericUpDownMesec";
            this.numericUpDownMesec.Size = new System.Drawing.Size(180, 24);
            this.numericUpDownMesec.TabIndex = 5;
            this.numericUpDownMesec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDan
            // 
            this.numericUpDownDan.Location = new System.Drawing.Point(57, 356);
            this.numericUpDownDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDan.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDan.Name = "numericUpDownDan";
            this.numericUpDownDan.Size = new System.Drawing.Size(180, 24);
            this.numericUpDownDan.TabIndex = 6;
            this.numericUpDownDan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownGodina
            // 
            this.numericUpDownGodina.Location = new System.Drawing.Point(586, 356);
            this.numericUpDownGodina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownGodina.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownGodina.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.numericUpDownGodina.Name = "numericUpDownGodina";
            this.numericUpDownGodina.Size = new System.Drawing.Size(180, 24);
            this.numericUpDownGodina.TabIndex = 7;
            this.numericUpDownGodina.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ime autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prezime autora";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(853, 356);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(197, 60);
            this.buttonDodaj.TabIndex = 11;
            this.buttonDodaj.Text = "Dodaj knjigu";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.DodajKnjigu);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 424);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1092, 18);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDan
            // 
            this.labelDan.AutoSize = true;
            this.labelDan.Location = new System.Drawing.Point(98, 321);
            this.labelDan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDan.Name = "labelDan";
            this.labelDan.Size = new System.Drawing.Size(35, 18);
            this.labelDan.TabIndex = 13;
            this.labelDan.Text = "Dan";
            // 
            // labelMesec
            // 
            this.labelMesec.AutoSize = true;
            this.labelMesec.Location = new System.Drawing.Point(375, 321);
            this.labelMesec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMesec.Name = "labelMesec";
            this.labelMesec.Size = new System.Drawing.Size(53, 18);
            this.labelMesec.TabIndex = 14;
            this.labelMesec.Text = "Mesec";
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.Location = new System.Drawing.Point(639, 321);
            this.labelGodina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(56, 18);
            this.labelGodina.TabIndex = 15;
            this.labelGodina.Text = "Godina";
            // 
            // textBoxZanr
            // 
            this.textBoxZanr.Location = new System.Drawing.Point(261, 312);
            this.textBoxZanr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxZanr.Name = "textBoxZanr";
            this.textBoxZanr.Size = new System.Drawing.Size(700, 24);
            this.textBoxZanr.TabIndex = 4;
            // 
            // labelZanr
            // 
            this.labelZanr.AutoSize = true;
            this.labelZanr.Location = new System.Drawing.Point(60, 316);
            this.labelZanr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZanr.Name = "labelZanr";
            this.labelZanr.Size = new System.Drawing.Size(83, 18);
            this.labelZanr.TabIndex = 16;
            this.labelZanr.Text = "Vrsta zanra";
            // 
            // DodavanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 442);
            this.Controls.Add(this.labelZanr);
            this.Controls.Add(this.textBoxZanr);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.labelMesec);
            this.Controls.Add(this.labelDan);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGodina);
            this.Controls.Add(this.numericUpDownDan);
            this.Controls.Add(this.numericUpDownMesec);
            this.Controls.Add(this.textBoxPrezimeAutora);
            this.Controls.Add(this.textBoxImeAutora);
            this.Controls.Add(this.textBoxNazivKnjige);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodavanjeKnjige";
            this.Text = "DodavanjeKnjige";
            this.Load += new System.EventHandler(this.DodavanjeKnjige_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMesec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOstalo;
        private System.Windows.Forms.RadioButton radioButtonKriminalistika;
        private System.Windows.Forms.RadioButton radioButtonLjubavni;
        private System.Windows.Forms.RadioButton radioButtonNaucnaFantastika;
        private System.Windows.Forms.TextBox textBoxNazivKnjige;
        private System.Windows.Forms.TextBox textBoxImeAutora;
        private System.Windows.Forms.TextBox textBoxPrezimeAutora;
        private System.Windows.Forms.NumericUpDown numericUpDownMesec;
        private System.Windows.Forms.NumericUpDown numericUpDownDan;
        private System.Windows.Forms.NumericUpDown numericUpDownGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDan;
        private System.Windows.Forms.Label labelMesec;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.TextBox textBoxZanr;
        private System.Windows.Forms.Label labelZanr;
    }
}