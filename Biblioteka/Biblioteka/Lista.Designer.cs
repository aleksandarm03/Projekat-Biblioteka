namespace Biblioteka
{
    partial class Lista
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxOstalo = new System.Windows.Forms.ListBox();
            this.listBoxLjubavni = new System.Windows.Forms.ListBox();
            this.listBoxKriminalistika = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNFantastika = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxOstalo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxLjubavni, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxKriminalistika, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNFantastika, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxOstalo
            // 
            this.listBoxOstalo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxOstalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOstalo.FormattingEnabled = true;
            this.listBoxOstalo.HorizontalScrollbar = true;
            this.listBoxOstalo.ItemHeight = 18;
            this.listBoxOstalo.Location = new System.Drawing.Point(802, 40);
            this.listBoxOstalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOstalo.Name = "listBoxOstalo";
            this.listBoxOstalo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxOstalo.Size = new System.Drawing.Size(259, 423);
            this.listBoxOstalo.Sorted = true;
            this.listBoxOstalo.TabIndex = 7;
            this.listBoxOstalo.SelectedIndexChanged += new System.EventHandler(this.listBoxOstalo_SelectedIndexChanged);
            // 
            // listBoxLjubavni
            // 
            this.listBoxLjubavni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxLjubavni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLjubavni.FormattingEnabled = true;
            this.listBoxLjubavni.HorizontalScrollbar = true;
            this.listBoxLjubavni.ItemHeight = 18;
            this.listBoxLjubavni.Location = new System.Drawing.Point(536, 40);
            this.listBoxLjubavni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxLjubavni.Name = "listBoxLjubavni";
            this.listBoxLjubavni.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLjubavni.Size = new System.Drawing.Size(258, 423);
            this.listBoxLjubavni.Sorted = true;
            this.listBoxLjubavni.TabIndex = 6;
            this.listBoxLjubavni.SelectedIndexChanged += new System.EventHandler(this.listBoxLjubavni_SelectedIndexChanged);
            // 
            // listBoxKriminalistika
            // 
            this.listBoxKriminalistika.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxKriminalistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKriminalistika.FormattingEnabled = true;
            this.listBoxKriminalistika.HorizontalScrollbar = true;
            this.listBoxKriminalistika.ItemHeight = 18;
            this.listBoxKriminalistika.Location = new System.Drawing.Point(270, 40);
            this.listBoxKriminalistika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxKriminalistika.Name = "listBoxKriminalistika";
            this.listBoxKriminalistika.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxKriminalistika.Size = new System.Drawing.Size(258, 423);
            this.listBoxKriminalistika.Sorted = true;
            this.listBoxKriminalistika.TabIndex = 5;
            this.listBoxKriminalistika.SelectedIndexChanged += new System.EventHandler(this.listBoxKriminalistika_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ostalo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ljubavni";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kriminalistika";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naucna fantastika";
            // 
            // listBoxNFantastika
            // 
            this.listBoxNFantastika.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxNFantastika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNFantastika.FormattingEnabled = true;
            this.listBoxNFantastika.HorizontalScrollbar = true;
            this.listBoxNFantastika.ItemHeight = 18;
            this.listBoxNFantastika.Location = new System.Drawing.Point(4, 40);
            this.listBoxNFantastika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxNFantastika.Name = "listBoxNFantastika";
            this.listBoxNFantastika.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxNFantastika.Size = new System.Drawing.Size(258, 423);
            this.listBoxNFantastika.Sorted = true;
            this.listBoxNFantastika.TabIndex = 4;
            this.listBoxNFantastika.SelectedIndexChanged += new System.EventHandler(this.listBoxNFantastika_SelectedIndexChanged);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxOstalo;
        private System.Windows.Forms.ListBox listBoxLjubavni;
        private System.Windows.Forms.ListBox listBoxKriminalistika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxNFantastika;
    }
}