namespace Kasir_Kit
{
    partial class Barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barang));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabAdd = new MetroFramework.Controls.MetroTabPage();
            this.btnSimpan = new MetroFramework.Controls.MetroButton();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.btnTambah = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtCari = new MetroFramework.Controls.MetroTextBox();
            this.groupDesc = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBiayaProduksi = new MetroFramework.Controls.MetroRadioButton();
            this.radioHargaBeli = new MetroFramework.Controls.MetroRadioButton();
            this.txtBiayaProduksi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtHargaBeli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtHargaJual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboJenisBarang = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNamaBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtKode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.TabEdit = new MetroFramework.Controls.MetroTabPage();
            this.TabRemove = new MetroFramework.Controls.MetroTabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroTabControl1.SuspendLayout();
            this.TabAdd.SuspendLayout();
            this.groupDesc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabAdd);
            this.metroTabControl1.Controls.Add(this.TabEdit);
            this.metroTabControl1.Controls.Add(this.TabRemove);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(615, 448);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // TabAdd
            // 
            this.TabAdd.Controls.Add(this.btnSimpan);
            this.TabAdd.Controls.Add(this.btnHapus);
            this.TabAdd.Controls.Add(this.btnTambah);
            this.TabAdd.Controls.Add(this.btnSearch);
            this.TabAdd.Controls.Add(this.txtCari);
            this.TabAdd.Controls.Add(this.groupDesc);
            this.TabAdd.Controls.Add(this.groupBox1);
            this.TabAdd.HorizontalScrollbarBarColor = true;
            this.TabAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.TabAdd.HorizontalScrollbarSize = 10;
            this.TabAdd.Location = new System.Drawing.Point(4, 38);
            this.TabAdd.Name = "TabAdd";
            this.TabAdd.Size = new System.Drawing.Size(607, 406);
            this.TabAdd.TabIndex = 0;
            this.TabAdd.Text = "Add Barang";
            this.TabAdd.VerticalScrollbarBarColor = true;
            this.TabAdd.VerticalScrollbarHighlightOnWheel = false;
            this.TabAdd.VerticalScrollbarSize = 10;
            this.TabAdd.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Enabled = false;
            this.btnSimpan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSimpan.Location = new System.Drawing.Point(498, 349);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(106, 50);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseCustomBackColor = true;
            this.btnSimpan.UseCustomForeColor = true;
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Enabled = false;
            this.btnHapus.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHapus.Location = new System.Drawing.Point(498, 290);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(106, 50);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseCustomBackColor = true;
            this.btnHapus.UseCustomForeColor = true;
            this.btnHapus.UseSelectable = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTambah.Location = new System.Drawing.Point(498, 233);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(106, 50);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseCustomBackColor = true;
            this.btnTambah.UseCustomForeColor = true;
            this.btnTambah.UseSelectable = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(538, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 29);
            this.btnSearch.TabIndex = 4;
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
            this.txtCari.CustomButton.Location = new System.Drawing.Point(507, 1);
            this.txtCari.CustomButton.Name = "";
            this.txtCari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCari.CustomButton.TabIndex = 1;
            this.txtCari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCari.CustomButton.UseSelectable = true;
            this.txtCari.CustomButton.Visible = false;
            this.txtCari.Lines = new string[0];
            this.txtCari.Location = new System.Drawing.Point(3, 195);
            this.txtCari.MaxLength = 32767;
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PromptText = "Cari nama barang";
            this.txtCari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCari.SelectedText = "";
            this.txtCari.SelectionLength = 0;
            this.txtCari.SelectionStart = 0;
            this.txtCari.ShortcutsEnabled = true;
            this.txtCari.Size = new System.Drawing.Size(529, 23);
            this.txtCari.TabIndex = 3;
            this.txtCari.UseSelectable = true;
            this.txtCari.WaterMark = "Cari nama barang";
            this.txtCari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // groupDesc
            // 
            this.groupDesc.BackColor = System.Drawing.Color.Transparent;
            this.groupDesc.Controls.Add(this.groupBox2);
            this.groupDesc.Controls.Add(this.txtBiayaProduksi);
            this.groupDesc.Controls.Add(this.metroLabel8);
            this.groupDesc.Controls.Add(this.txtHargaBeli);
            this.groupDesc.Controls.Add(this.metroLabel7);
            this.groupDesc.Controls.Add(this.txtHargaJual);
            this.groupDesc.Controls.Add(this.metroLabel6);
            this.groupDesc.Controls.Add(this.txtSupplier);
            this.groupDesc.Controls.Add(this.metroLabel5);
            this.groupDesc.Controls.Add(this.txtStock);
            this.groupDesc.Controls.Add(this.metroLabel4);
            this.groupDesc.Controls.Add(this.comboJenisBarang);
            this.groupDesc.Controls.Add(this.metroLabel3);
            this.groupDesc.Controls.Add(this.txtNamaBarang);
            this.groupDesc.Controls.Add(this.metroLabel2);
            this.groupDesc.Controls.Add(this.txtKode);
            this.groupDesc.Controls.Add(this.metroLabel1);
            this.groupDesc.Location = new System.Drawing.Point(3, 224);
            this.groupDesc.Name = "groupDesc";
            this.groupDesc.Size = new System.Drawing.Size(489, 179);
            this.groupDesc.TabIndex = 3;
            this.groupDesc.TabStop = false;
            this.groupDesc.Text = "Informasi Barang";
            this.groupDesc.Enter += new System.EventHandler(this.groupDesc_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBiayaProduksi);
            this.groupBox2.Controls.Add(this.radioHargaBeli);
            this.groupBox2.Location = new System.Drawing.Point(288, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 47);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Modal";
            // 
            // radioBiayaProduksi
            // 
            this.radioBiayaProduksi.AutoSize = true;
            this.radioBiayaProduksi.Location = new System.Drawing.Point(85, 21);
            this.radioBiayaProduksi.Name = "radioBiayaProduksi";
            this.radioBiayaProduksi.Size = new System.Drawing.Size(100, 15);
            this.radioBiayaProduksi.TabIndex = 1;
            this.radioBiayaProduksi.Text = "Biaya Produksi";
            this.radioBiayaProduksi.UseSelectable = true;
            this.radioBiayaProduksi.CheckedChanged += new System.EventHandler(this.radioBiayaProduksi_CheckedChanged);
            // 
            // radioHargaBeli
            // 
            this.radioHargaBeli.AutoSize = true;
            this.radioHargaBeli.Location = new System.Drawing.Point(2, 21);
            this.radioHargaBeli.Name = "radioHargaBeli";
            this.radioHargaBeli.Size = new System.Drawing.Size(77, 15);
            this.radioHargaBeli.TabIndex = 0;
            this.radioHargaBeli.Text = "Harga Beli";
            this.radioHargaBeli.UseSelectable = true;
            this.radioHargaBeli.CheckedChanged += new System.EventHandler(this.radioHargaBeli_CheckedChanged);
            // 
            // txtBiayaProduksi
            // 
            // 
            // 
            // 
            this.txtBiayaProduksi.CustomButton.Image = null;
            this.txtBiayaProduksi.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtBiayaProduksi.CustomButton.Name = "";
            this.txtBiayaProduksi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiayaProduksi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiayaProduksi.CustomButton.TabIndex = 1;
            this.txtBiayaProduksi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiayaProduksi.CustomButton.UseSelectable = true;
            this.txtBiayaProduksi.CustomButton.Visible = false;
            this.txtBiayaProduksi.Lines = new string[] {
        "0"};
            this.txtBiayaProduksi.Location = new System.Drawing.Point(288, 89);
            this.txtBiayaProduksi.MaxLength = 32767;
            this.txtBiayaProduksi.Name = "txtBiayaProduksi";
            this.txtBiayaProduksi.PasswordChar = '\0';
            this.txtBiayaProduksi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiayaProduksi.SelectedText = "";
            this.txtBiayaProduksi.SelectionLength = 0;
            this.txtBiayaProduksi.SelectionStart = 0;
            this.txtBiayaProduksi.ShortcutsEnabled = true;
            this.txtBiayaProduksi.Size = new System.Drawing.Size(191, 23);
            this.txtBiayaProduksi.TabIndex = 7;
            this.txtBiayaProduksi.Text = "0";
            this.txtBiayaProduksi.UseSelectable = true;
            this.txtBiayaProduksi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiayaProduksi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(288, 67);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Biaya Produksi:";
            // 
            // txtHargaBeli
            // 
            // 
            // 
            // 
            this.txtHargaBeli.CustomButton.Image = null;
            this.txtHargaBeli.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtHargaBeli.CustomButton.Name = "";
            this.txtHargaBeli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHargaBeli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHargaBeli.CustomButton.TabIndex = 1;
            this.txtHargaBeli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHargaBeli.CustomButton.UseSelectable = true;
            this.txtHargaBeli.CustomButton.Visible = false;
            this.txtHargaBeli.Lines = new string[] {
        "0"};
            this.txtHargaBeli.Location = new System.Drawing.Point(288, 40);
            this.txtHargaBeli.MaxLength = 32767;
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.PasswordChar = '\0';
            this.txtHargaBeli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHargaBeli.SelectedText = "";
            this.txtHargaBeli.SelectionLength = 0;
            this.txtHargaBeli.SelectionStart = 0;
            this.txtHargaBeli.ShortcutsEnabled = true;
            this.txtHargaBeli.Size = new System.Drawing.Size(195, 23);
            this.txtHargaBeli.TabIndex = 6;
            this.txtHargaBeli.Text = "0";
            this.txtHargaBeli.UseSelectable = true;
            this.txtHargaBeli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHargaBeli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(288, 18);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Harga Beli:";
            // 
            // txtHargaJual
            // 
            // 
            // 
            // 
            this.txtHargaJual.CustomButton.Image = null;
            this.txtHargaJual.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtHargaJual.CustomButton.Name = "";
            this.txtHargaJual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHargaJual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHargaJual.CustomButton.TabIndex = 1;
            this.txtHargaJual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHargaJual.CustomButton.UseSelectable = true;
            this.txtHargaJual.CustomButton.Visible = false;
            this.txtHargaJual.Lines = new string[] {
        "0"};
            this.txtHargaJual.Location = new System.Drawing.Point(147, 136);
            this.txtHargaJual.MaxLength = 32767;
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.PasswordChar = '\0';
            this.txtHargaJual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHargaJual.SelectedText = "";
            this.txtHargaJual.SelectionLength = 0;
            this.txtHargaJual.SelectionStart = 0;
            this.txtHargaJual.ShortcutsEnabled = true;
            this.txtHargaJual.Size = new System.Drawing.Size(135, 23);
            this.txtHargaJual.TabIndex = 5;
            this.txtHargaJual.Text = "0";
            this.txtHargaJual.UseSelectable = true;
            this.txtHargaJual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHargaJual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(147, 114);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Harga Jual:";
            // 
            // txtSupplier
            // 
            // 
            // 
            // 
            this.txtSupplier.CustomButton.Image = null;
            this.txtSupplier.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtSupplier.CustomButton.Name = "";
            this.txtSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplier.CustomButton.TabIndex = 1;
            this.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplier.CustomButton.UseSelectable = true;
            this.txtSupplier.CustomButton.Visible = false;
            this.txtSupplier.Lines = new string[0];
            this.txtSupplier.Location = new System.Drawing.Point(147, 40);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.SelectionLength = 0;
            this.txtSupplier.SelectionStart = 0;
            this.txtSupplier.ShortcutsEnabled = true;
            this.txtSupplier.Size = new System.Drawing.Size(135, 23);
            this.txtSupplier.TabIndex = 3;
            this.txtSupplier.UseSelectable = true;
            this.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(147, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Supplier:";
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[] {
        "0"};
            this.txtStock.Location = new System.Drawing.Point(147, 88);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(135, 23);
            this.txtStock.TabIndex = 4;
            this.txtStock.Text = "0";
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(147, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Stock Barang:";
            // 
            // comboJenisBarang
            // 
            this.comboJenisBarang.FormattingEnabled = true;
            this.comboJenisBarang.ItemHeight = 23;
            this.comboJenisBarang.Location = new System.Drawing.Point(6, 136);
            this.comboJenisBarang.Name = "comboJenisBarang";
            this.comboJenisBarang.Size = new System.Drawing.Size(135, 29);
            this.comboJenisBarang.TabIndex = 2;
            this.comboJenisBarang.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 114);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Jenis Barang:";
            // 
            // txtNamaBarang
            // 
            // 
            // 
            // 
            this.txtNamaBarang.CustomButton.Image = null;
            this.txtNamaBarang.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtNamaBarang.CustomButton.Name = "";
            this.txtNamaBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamaBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamaBarang.CustomButton.TabIndex = 1;
            this.txtNamaBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamaBarang.CustomButton.UseSelectable = true;
            this.txtNamaBarang.CustomButton.Visible = false;
            this.txtNamaBarang.Lines = new string[0];
            this.txtNamaBarang.Location = new System.Drawing.Point(6, 88);
            this.txtNamaBarang.MaxLength = 32767;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.SelectionLength = 0;
            this.txtNamaBarang.SelectionStart = 0;
            this.txtNamaBarang.ShortcutsEnabled = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(135, 23);
            this.txtNamaBarang.TabIndex = 1;
            this.txtNamaBarang.UseSelectable = true;
            this.txtNamaBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamaBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama Barang:";
            // 
            // txtKode
            // 
            // 
            // 
            // 
            this.txtKode.CustomButton.Image = null;
            this.txtKode.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtKode.CustomButton.Name = "";
            this.txtKode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKode.CustomButton.TabIndex = 1;
            this.txtKode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKode.CustomButton.UseSelectable = true;
            this.txtKode.CustomButton.Visible = false;
            this.txtKode.Lines = new string[0];
            this.txtKode.Location = new System.Drawing.Point(6, 40);
            this.txtKode.MaxLength = 32767;
            this.txtKode.Name = "txtKode";
            this.txtKode.PasswordChar = '\0';
            this.txtKode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKode.SelectedText = "";
            this.txtKode.SelectionLength = 0;
            this.txtKode.SelectionStart = 0;
            this.txtKode.ShortcutsEnabled = true;
            this.txtKode.Size = new System.Drawing.Size(135, 23);
            this.txtKode.TabIndex = 0;
            this.txtKode.UseSelectable = true;
            this.txtKode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kode Barang:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridBarang);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 186);
            this.groupBox1.TabIndex = 2;
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
            this.dataGridBarang.Location = new System.Drawing.Point(3, 18);
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
            this.dataGridBarang.Size = new System.Drawing.Size(595, 165);
            this.dataGridBarang.TabIndex = 1;
            this.dataGridBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBarang_CellClick);
            this.dataGridBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaksi_CellContentClick);
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
            // TabEdit
            // 
            this.TabEdit.HorizontalScrollbarBarColor = true;
            this.TabEdit.HorizontalScrollbarHighlightOnWheel = false;
            this.TabEdit.HorizontalScrollbarSize = 10;
            this.TabEdit.Location = new System.Drawing.Point(4, 38);
            this.TabEdit.Name = "TabEdit";
            this.TabEdit.Size = new System.Drawing.Size(607, 406);
            this.TabEdit.TabIndex = 1;
            this.TabEdit.Text = "Edit Barang";
            this.TabEdit.VerticalScrollbarBarColor = true;
            this.TabEdit.VerticalScrollbarHighlightOnWheel = false;
            this.TabEdit.VerticalScrollbarSize = 10;
            // 
            // TabRemove
            // 
            this.TabRemove.HorizontalScrollbarBarColor = true;
            this.TabRemove.HorizontalScrollbarHighlightOnWheel = false;
            this.TabRemove.HorizontalScrollbarSize = 10;
            this.TabRemove.Location = new System.Drawing.Point(4, 38);
            this.TabRemove.Name = "TabRemove";
            this.TabRemove.Size = new System.Drawing.Size(607, 406);
            this.TabRemove.TabIndex = 2;
            this.TabRemove.Text = "Remove Barang";
            this.TabRemove.VerticalScrollbarBarColor = true;
            this.TabRemove.VerticalScrollbarHighlightOnWheel = false;
            this.TabRemove.VerticalScrollbarSize = 10;
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 528);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 528);
            this.MinimumSize = new System.Drawing.Size(655, 528);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabAdd.ResumeLayout(false);
            this.groupDesc.ResumeLayout(false);
            this.groupDesc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabAdd;
        private MetroFramework.Controls.MetroTabPage TabEdit;
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
        private System.Windows.Forms.GroupBox groupDesc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox txtCari;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton radioBiayaProduksi;
        private MetroFramework.Controls.MetroRadioButton radioHargaBeli;
        private MetroFramework.Controls.MetroTextBox txtBiayaProduksi;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtHargaJual;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboJenisBarang;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNamaBarang;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtKode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSimpan;
        private MetroFramework.Controls.MetroButton btnHapus;
        private MetroFramework.Controls.MetroButton btnTambah;
        private MetroFramework.Controls.MetroTabPage TabRemove;
        private MetroFramework.Controls.MetroTextBox txtHargaBeli;
    }
}