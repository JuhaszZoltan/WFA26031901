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
            ((System.ComponentModel.ISupportInitialize)dgvAllatok).BeginInit();
            SuspendLayout();
            // 
            // dgvAllatok
            // 
            dgvAllatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllatok.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvAllatok.Location = new Point(12, 98);
            dgvAllatok.Name = "dgvAllatok";
            dgvAllatok.RowHeadersWidth = 51;
            dgvAllatok.Size = new Size(776, 340);
            dgvAllatok.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Faj";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Név";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Életkor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Részleg";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Gondozó";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "gondozó:";
            // 
            // cbxGondozok
            // 
            cbxGondozok.FormattingEnabled = true;
            cbxGondozok.Location = new Point(90, 30);
            cbxGondozok.Name = "cbxGondozok";
            cbxGondozok.Size = new Size(151, 28);
            cbxGondozok.TabIndex = 2;
            cbxGondozok.Text = "összes...";
            // 
            // button1
            // 
            btnSzures.Location = new Point(264, 29);
            btnSzures.Name = "button1";
            btnSzures.Size = new Size(150, 29);
            btnSzures.TabIndex = 3;
            btnSzures.Text = "szűrés";
            btnSzures.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSzures);
            Controls.Add(cbxGondozok);
            Controls.Add(label1);
            Controls.Add(dgvAllatok);
            Name = "FrmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAllatok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllatok;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private ComboBox cbxGondozok;
        private Button btnSzures;
    }
}
