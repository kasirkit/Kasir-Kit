namespace Kasir_Kit
{
    partial class JenisBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenisBarang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDaftarJenis = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTambah = new MetroFramework.Controls.MetroButton();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.txtJenis = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboDaftarJenis);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Jenis Barang";
            // 
            // comboDaftarJenis
            // 
            this.comboDaftarJenis.FormattingEnabled = true;
            this.comboDaftarJenis.ItemHeight = 23;
            this.comboDaftarJenis.Location = new System.Drawing.Point(6, 21);
            this.comboDaftarJenis.Name = "comboDaftarJenis";
            this.comboDaftarJenis.Size = new System.Drawing.Size(223, 29);
            this.comboDaftarJenis.TabIndex = 0;
            this.comboDaftarJenis.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.txtJenis);
            this.groupBox2.Location = new System.Drawing.Point(9, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Akses Data";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTambah.Location = new System.Drawing.Point(6, 50);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(105, 35);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseCustomBackColor = true;
            this.btnTambah.UseCustomForeColor = true;
            this.btnTambah.UseSelectable = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHapus.Location = new System.Drawing.Point(117, 50);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 35);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseCustomBackColor = true;
            this.btnHapus.UseCustomForeColor = true;
            this.btnHapus.UseSelectable = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtJenis
            // 
            // 
            // 
            // 
            this.txtJenis.CustomButton.Image = null;
            this.txtJenis.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtJenis.CustomButton.Name = "";
            this.txtJenis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJenis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJenis.CustomButton.TabIndex = 1;
            this.txtJenis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJenis.CustomButton.UseSelectable = true;
            this.txtJenis.CustomButton.Visible = false;
            this.txtJenis.Lines = new string[0];
            this.txtJenis.Location = new System.Drawing.Point(6, 21);
            this.txtJenis.MaxLength = 32767;
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.PasswordChar = '\0';
            this.txtJenis.PromptText = "Nama jenis barang";
            this.txtJenis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJenis.SelectedText = "";
            this.txtJenis.SelectionLength = 0;
            this.txtJenis.SelectionStart = 0;
            this.txtJenis.ShortcutsEnabled = true;
            this.txtJenis.Size = new System.Drawing.Size(221, 23);
            this.txtJenis.TabIndex = 0;
            this.txtJenis.UseCustomForeColor = true;
            this.txtJenis.UseSelectable = true;
            this.txtJenis.WaterMark = "Nama jenis barang";
            this.txtJenis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJenis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // JenisBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(259, 242);
            this.MinimumSize = new System.Drawing.Size(259, 242);
            this.Name = "JenisBarang";
            this.Text = "Jenis Barang";
            this.Load += new System.EventHandler(this.JenisBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox comboDaftarJenis;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtJenis;
        private MetroFramework.Controls.MetroButton btnHapus;
        private MetroFramework.Controls.MetroButton btnTambah;
    }
}