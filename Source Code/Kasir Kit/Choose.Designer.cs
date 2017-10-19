namespace Kasir_Kit
{
    partial class Choose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtCari = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridBarang = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(492, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCari
            // 
            // 
            // 
            // 
            this.txtCari.CustomButton.Image = null;
            this.txtCari.CustomButton.Location = new System.Drawing.Point(432, 1);
            this.txtCari.CustomButton.Name = "";
            this.txtCari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCari.CustomButton.TabIndex = 1;
            this.txtCari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCari.CustomButton.UseSelectable = true;
            this.txtCari.CustomButton.Visible = false;
            this.txtCari.Lines = new string[0];
            this.txtCari.Location = new System.Drawing.Point(32, 254);
            this.txtCari.MaxLength = 32767;
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PromptText = "Cari nama barang";
            this.txtCari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCari.SelectedText = "";
            this.txtCari.SelectionLength = 0;
            this.txtCari.SelectionStart = 0;
            this.txtCari.ShortcutsEnabled = true;
            this.txtCari.Size = new System.Drawing.Size(454, 23);
            this.txtCari.TabIndex = 7;
            this.txtCari.UseSelectable = true;
            this.txtCari.WaterMark = "Cari nama barang";
            this.txtCari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridBarang);
            this.groupBox1.Location = new System.Drawing.Point(32, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Barang";
            // 
            // dataGridBarang
            // 
            this.dataGridBarang.AllowUserToAddRows = false;
            this.dataGridBarang.AllowUserToDeleteRows = false;
            this.dataGridBarang.AllowUserToResizeRows = false;
            this.dataGridBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBarang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBarang.EnableHeadersVisualStyles = false;
            this.dataGridBarang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridBarang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridBarang.Location = new System.Drawing.Point(3, 16);
            this.dataGridBarang.Name = "dataGridBarang";
            this.dataGridBarang.ReadOnly = true;
            this.dataGridBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBarang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBarang.RowHeadersVisible = false;
            this.dataGridBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBarang.Size = new System.Drawing.Size(595, 167);
            this.dataGridBarang.TabIndex = 1;
            this.dataGridBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBarang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Barang";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jenis Barang";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Supplier";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Harga Jual";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Harga Beli";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Biaya Produksi";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Terjual";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Keuntungan";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(564, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 29);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 288);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choose";
            this.Text = "Pilih Barang";
            this.Load += new System.EventHandler(this.Choose_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtCari;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dataGridBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}