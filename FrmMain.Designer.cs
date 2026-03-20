namespace WFA26031901
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAllatok = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cbxGondozok = new ComboBox();
            btnSzures = new Button();
            txtMinKor = new TextBox();
            label2 = new Label();
            txtMaxKor = new TextBox();
            label3 = new Label();
            btnStatisztika = new Button();
            btnOsszes = new Button();
            lblSatisztika = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAllatok).BeginInit();
            SuspendLayout();
            // 
            // dgvAllatok
            // 
            dgvAllatok.AllowUserToAddRows = false;
            dgvAllatok.AllowUserToDeleteRows = false;
            dgvAllatok.AllowUserToResizeColumns = false;
            dgvAllatok.AllowUserToResizeRows = false;
            dgvAllatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllatok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAllatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllatok.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvAllatok.Location = new Point(12, 65);
            dgvAllatok.Name = "dgvAllatok";
            dgvAllatok.RowHeadersVisible = false;
            dgvAllatok.RowHeadersWidth = 51;
            dgvAllatok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllatok.Size = new Size(858, 394);
            dgvAllatok.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 3F;
            Column1.HeaderText = "Faj";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 2F;
            Column2.HeaderText = "Név";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 1F;
            Column3.HeaderText = "Életkor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 3F;
            Column4.HeaderText = "Részleg";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 3F;
            Column5.HeaderText = "Gondozó";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "gondozó:";
            // 
            // cbxGondozok
            // 
            cbxGondozok.FormattingEnabled = true;
            cbxGondozok.Location = new Point(90, 13);
            cbxGondozok.Name = "cbxGondozok";
            cbxGondozok.Size = new Size(151, 28);
            cbxGondozok.TabIndex = 2;
            cbxGondozok.Text = "összes...";
            // 
            // btnSzures
            // 
            btnSzures.Location = new Point(422, 12);
            btnSzures.Name = "btnSzures";
            btnSzures.Size = new Size(101, 29);
            btnSzures.TabIndex = 3;
            btnSzures.Text = "szűrés";
            btnSzures.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            txtMinKor.Location = new Point(311, 13);
            txtMinKor.Name = "textBox2";
            txtMinKor.Size = new Size(39, 27);
            txtMinKor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 16);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 1;
            label2.Text = "-";
            // 
            // textBox1
            // 
            txtMaxKor.Location = new Point(377, 13);
            txtMaxKor.Name = "textBox1";
            txtMaxKor.Size = new Size(39, 27);
            txtMaxKor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "életkor:";
            // 
            // button1
            // 
            btnStatisztika.Location = new Point(529, 12);
            btnStatisztika.Name = "button1";
            btnStatisztika.Size = new Size(141, 29);
            btnStatisztika.TabIndex = 3;
            btnStatisztika.Text = "statisztika";
            btnStatisztika.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            btnOsszes.Location = new Point(676, 12);
            btnOsszes.Name = "button2";
            btnOsszes.Size = new Size(194, 29);
            btnOsszes.TabIndex = 3;
            btnOsszes.Text = "összes megjelenítése";
            btnOsszes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            lblSatisztika.BackColor = Color.White;
            lblSatisztika.BorderStyle = BorderStyle.Fixed3D;
            lblSatisztika.Location = new Point(12, 472);
            lblSatisztika.Name = "label4";
            lblSatisztika.Size = new Size(858, 64);
            lblSatisztika.TabIndex = 5;
            lblSatisztika.Text = "label4";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(lblSatisztika);
            Controls.Add(txtMaxKor);
            Controls.Add(txtMinKor);
            Controls.Add(btnOsszes);
            Controls.Add(btnStatisztika);
            Controls.Add(btnSzures);
            Controls.Add(cbxGondozok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAllatok);
            Name = "FrmMain";
            Text = "Állatkert";
            ((System.ComponentModel.ISupportInitialize)dgvAllatok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllatok;
        private Label label1;
        private ComboBox cbxGondozok;
        private Button btnSzures;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtMinKor;
        private Label label2;
        private TextBox txtMaxKor;
        private Label label3;
        private Button btnStatisztika;
        private Button btnOsszes;
        private Label lblSatisztika;
    }
}
