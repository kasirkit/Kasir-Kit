using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        //Username user kasir
        public string username;

        //Deklarasi Objek Class
        DatabaseHelper myDb;
        FileManager myFile;
        Account acc;
        Ultilities utils;
        Transaksi tss;
        BarangDataHelper barang;

        private void Main_Load(object sender, EventArgs e)
        {

            //Melakukan calling objek class
            myDb = new DatabaseHelper();
            myFile = new FileManager(myDb.DatabaseName);
            utils = new Ultilities();

            //Pengecekan file database tersedia
            if (!myFile.isFileExists())
            {
                myDb.CreateDatabase();
                int num = 0;
                myDb.InsertTotalTransaksi(num);
            }
     
            
            //Authentication Login Account
            if (Authentication())
            {
                //Melakukan seleksi tab control ke detail transaksi
                metroTabControl1.SelectedIndex = 0;

                //Membuat Kolom yang diperlukan
                CreateBelanjaColumns();
                CreateBarangTerlarisColumns();

                //Mendapatkan biodata user
                GetBiodata();

                //Mendapatkan total profit
                GetProfit();
                //Mendapatkan total barang
                GetTotalBarang();
                //Mendapatkan total stock barang
                GetTotalStock();

                //Mendapatkan daftar barang
                GetDaftarBarang();

                //Mendapatkan nomor diskon
                GetDiscNum();

                //Mendapatkan daftar transaksi
                GetTransaksi();

                //Mendapatkan total nominal transaksi
                GetTotalPay();

                //Mendapatkan barang terlaris
                GetBarangTerlaris();
            }
        }

        /// <summary>
        /// Membuat Kolom untuk Daftar Keranjang Belanja
        /// </summary>
        private void CreateBelanjaColumns()
        {
            listKeranjang.Columns.Add("Barang", 110);
            listKeranjang.Columns.Add("Harga", 80);
            listKeranjang.Columns.Add("Jumlah", 40);
        }

        /// <summary>
        /// Membuat Kolom untuk Daftar Barang Terlaris
        /// </summary>
        private void CreateBarangTerlarisColumns()
        {
            listBarangTerlaris.Columns.Add("Barang", 80);
            listBarangTerlaris.Columns.Add("Harga", 60);
            listBarangTerlaris.Columns.Add("Terjual", 50);
            listBarangTerlaris.Columns.Add("Rank", 40);
        }
  

        /// <summary>
        /// Proses autentikasi login ketika aplikasi pertama kali dibuka.
        /// </summary>
        /// <returns></returns>
        public bool Authentication()
        {
            bool logged = false;
            Login login = new Login();
            login.ShowDialog();

            /* Memastikan bahwa user telah berhasil login
             dengan ditandainya variable isLogged telah menjadi "True". 
             Namun jika false, aplikasi akan otomatis tertutup, guna 
             mencegah terjadinya bug login */
            if (login.isLogged)
            {
                //Mengambil value username pada form login
                username = login.username;
                logged = true;
            }
            else
            {
                //Menutup program
                this.Close();
            }
            return logged;
        }

        /// <summary>
        /// Mendapatkan biodata kasir
        /// </summary>
        public void GetBiodata()
        {
            acc = new Account();

            lblUser.Text = acc.GetFirstname(username) 
                + " " 
                + acc.GetLastname(username) 
                + " (" + acc.GetType(username) + ")";
        }

        /// <summary>
        /// Mendapatkan total profit
        /// dari keuntungan barang
        /// </summary>
       public void GetProfit()
        {
            tss = new Transaksi();
            lblProfit.Text = "Rp" + tss.GetProfit().ToString("N0");
        }

        /// <summary>
        /// Mendapatkan jumlah barang
        /// </summary>
        public void GetTotalBarang()
        {
            barang = new BarangDataHelper();
            lblTotalBarang.Text = barang.GetTotalBarang().ToString();
        }

        /// <summary>
        /// Mendapatkan total stock barang
        /// </summary>
        public void GetTotalStock()
        {
            barang = new BarangDataHelper();
            lblTotalStock.Text = barang.GetTotalStock().ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnJenisBarang_Click(object sender, EventArgs e)
        {
            JenisBarang jenis = new JenisBarang();
            jenis.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            Barang _barang = new Barang();
            _barang.ShowDialog();

            //Mendapatkan total profit
            GetProfit();
            //Mendapatkan total barang
            GetTotalBarang();
            //Mendapatkan total stock barang
            GetTotalStock();
            //Mendapatkan daftar barang
            GetDaftarBarang();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            utils = new Ultilities();

            Choose _choose = new Choose();
            _choose.ShowDialog();

            try
            {
                comboBarang.SelectedIndex = comboBarang.Items.IndexOf(_choose.barangChoose);
            }
            catch(Exception ex)
            {
                utils.ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mendapatkan seluruh barang yang 
        /// ada dan menambahkannya ke dalam combobox
        /// </summary>
        private void GetDaftarBarang()
        {
            barang = new BarangDataHelper();
            comboBarang.Items.Clear();

            foreach(string name in barang.GetNama())
            {
                comboBarang.Items.Add(name);
            }
        }

        /// <summary>
        /// Proses pemilihan barang dari combobox
        /// lalu sistem akan otomatis menginput details 
        /// barang tersebut ke dalam textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();

            for(int i=0; i < barang.GetID().Count; i++)
            {
                if (barang.GetNama()[i] == comboBarang.Text)
                {
                    txtKode.Text = barang.GetKode()[i];
                    txtJenisBarang.Text = barang.GetJenis()[i];
                    txtSupplier.Text = barang.GetSupplier()[i];
                    txtStock.Text = barang.GetStock()[i].ToString();
                    txtHargaBarang.Text = barang.GetHargaJual()[i].ToString();
                }
            }
        }

        List<string> _kode = new List<string>();
        List<string> _name = new List<string>();
        List<string> _jenis = new List<string>();
        List<string> _supplier = new List<string>();
        List<int> _stock = new List<int>();
        List<int> _jumlah = new List<int>();
        List<int> _rawHarga = new List<int>();
        List<int> _harga = new List<int>();
        List<int> _diskon = new List<int>();
        string[] rows = new string[4];
        
        //Variable yang akan menyimpan total biaya transaksi
        private int TotalBiaya;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();
            if (txtJumlah.Text != string.Empty)
            {

                if (txtStock.Text == "0")
                {
                    utils.ShowMessage("Stock barang telah habis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listKeranjang.Items.Clear();

                if (comboDiskon.Text == string.Empty)
                {
                    comboDiskon.SelectedIndex = 0;
                }
                int hargaBarang = int.Parse(txtHargaBarang.Text);

                if (int.Parse(comboDiskon.Text.Replace("%", "")) > 0)
                {
                    int subt = hargaBarang * int.Parse(comboDiskon.Text.Replace("%", "")) / 100;
                    hargaBarang -= subt;
                }

                AddKeranjang(comboBarang.Text, int.Parse(txtJumlah.Text), hargaBarang, int.Parse(comboDiskon.Text.Replace("%", "")));

                //Menambah biaya
                AddTotalBiaya(hargaBarang, int.Parse(txtJumlah.Text));
                AddDetails(comboBarang.Text, txtKode.Text, txtJenisBarang.Text, hargaBarang, int.Parse(txtJumlah.Text));

                for (int i = 0; i < _name.Count; i++)
                {
                    rows[0] = "Rp" + _harga[i].ToString("N0");
                    rows[1] = _jumlah[i].ToString();

                    listKeranjang.Items.Add(_name[i], 0).SubItems.AddRange(rows);
                }

                //Refresh UI
                comboBarang.SelectedIndex = -1;
                comboDiskon.SelectedIndex = -1;
                utils.ClearTextBox(txtKode, string.Empty);
                utils.ClearTextBox(txtJenisBarang, string.Empty);
                utils.ClearTextBox(txtSupplier, string.Empty);
                utils.ClearTextBox(txtStock, string.Empty);
                utils.ClearTextBox(txtHargaBarang, string.Empty);
                utils.ClearTextBox(txtJumlah, string.Empty);
            }
            else
            {
                utils.ShowMessage("Masukkan jumlah belanja", "Penambahan Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Berfungsi sebagai penampil details transaksi.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kode"></param>
        /// <param name="jenis"></param>
        /// <param name="harga"></param>
        private void AddDetails(string name, string kode, string jenis, int harga, int jumlah)
        {
            utils = new Ultilities();

            utils.ClearLabel(lblDetailBarang, name);
            utils.ClearLabel(lblDetailKode, kode);
            utils.ClearLabel(lblDetailJenis, jenis);
            utils.ClearLabel(lblDetailJumlah, jumlah.ToString());
            if (int.Parse(comboDiskon.Text.Replace("%", "")) > 0)
            {
                utils.ClearLabel(lblDetailHarga, "Rp" + harga.ToString("N0") + " (" + comboDiskon.Text + ")");
            }
            else
            {
                utils.ClearLabel(lblDetailHarga, "Rp" + harga.ToString("N0"));
            }
        }

        /// <summary>
        /// Menghapus details transaksi
        /// </summary>
        private void RemoveDetails()
        {
            utils = new Ultilities();

            for(int i=0; i < _kode.Count; i++)
            {
                if (_kode[i] != null)
                {
                    utils.ClearLabel(lblDetailBarang, _name[i]);
                    utils.ClearLabel(lblDetailKode, _kode[i]);
                    utils.ClearLabel(lblDetailJenis, _jenis[i]);
                    utils.ClearLabel(lblDetailJumlah, _jumlah[i].ToString());
                    if (_diskon[i] > 0)
                    {
                        utils.ClearLabel(lblDetailHarga, "Rp" + _harga[i].ToString("N0") + " (" + _diskon[i] + "%)");
                    }
                    else
                    {
                        utils.ClearLabel(lblDetailHarga, "Rp" + _harga[i].ToString("N0"));
                    }
                }
            }

            if (_kode.Count == 0)
            {
                utils.ClearLabel(lblDetailBarang, "?");
                utils.ClearLabel(lblDetailKode, "?");
                utils.ClearLabel(lblDetailJenis, "?");
                utils.ClearLabel(lblDetailJumlah, "?");
                utils.ClearLabel(lblDetailHarga, "?");
            }
        }

        /// <summary>
        /// Menambah harga ke total biaya
        /// </summary>
        /// <param name="harga"></param>
        private void AddTotalBiaya(int harga, int jumlah)
        {
            TotalBiaya += harga * jumlah;
            lblDetailTotalBiaya.Text = "Rp" + TotalBiaya.ToString("N0");
        }

        /// <summary>
        /// Mengurangi nilai nominal total biaya
        /// </summary>
        /// <param name="harga"></param>
        private void RemoveTotalBiaya(int harga, int jumlah)
        {
            TotalBiaya -= harga;
            lblDetailTotalBiaya.Text = "Rp" + TotalBiaya.ToString("N0");
        }

        /// <summary>
        /// Menambahkan barang ke keranja barang
        /// </summary>
        /// <param name="name"></param>
        /// <param name="jumlah"></param>
        /// <param name="harga"></param>
        private void AddKeranjang(string name, int jumlah, int harga, int diskon)
        {
            _kode.Add(txtKode.Text);
            _name.Add(comboBarang.Text);
            _jenis.Add(txtJenisBarang.Text);
            _supplier.Add(txtSupplier.Text);
            _stock.Add(int.Parse(txtStock.Text));
            _jumlah.Add(int.Parse(txtJumlah.Text));
            _diskon.Add(diskon);

            _rawHarga.Add(int.Parse(txtHargaBarang.Text));
            int price = harga * jumlah;
            _harga.Add(price);

        }

        /// <summary>
        /// Membersihkan data keranjang belanja
        /// </summary>
        private void ClearKeranjang()
        {
            _kode.Clear();
            _name.Clear();
            _jenis.Clear();
            _supplier.Clear();
            _stock.Clear();
            _jumlah.Clear();
            _rawHarga.Clear();
            _harga.Clear();
            _diskon.Clear();

            listKeranjang.Items.Clear();
            RemoveDetails();
            if (cash > TotalBiaya)
            {
                int kembali = cash - TotalBiaya;
                utils.ShowMessage("Kembalian: Rp" + kembali.ToString("N0") + "\nTerima kasih telah berbelanja...", "Kembalian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TotalBiaya = 0;
            cash = 0;
        }

        /// <summary>
        /// Menghapus barang belanjaan 
        /// dari keranjang belanja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            utils = new Ultilities();

            int count = 0;
            foreach (string name in _name)
            {
                if (name != null)
                {
                    count++;
                }
            }

            if (count > 0)
            {

                int index = _kode.Count;

                //Mengurangi harga total biaya
                RemoveTotalBiaya(_harga[index - 1], _jumlah[index - 1]);

                _kode.RemoveAt(index - 1);
                _name.RemoveAt(index - 1);
                _jenis.RemoveAt(index - 1);
                _supplier.RemoveAt(index - 1);
                _jumlah.RemoveAt(index - 1);
                _harga.RemoveAt(index - 1);
                _diskon.RemoveAt(index - 1);

                listKeranjang.Items.RemoveAt(index - 1);
                RemoveDetails();
            }
            else
            {
                utils.ShowMessage("Keranjang belanja kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Cara instant buat yang males
        /// nambahin angka diskon manual
        /// di combobox
        /// </summary>
        private void GetDiscNum()
        {
            for(int i=0; i < 101; i++)
            {
                comboDiskon.Items.Add(i + "%");
            }
        }


        private int cash;
        private void btnBayar_Click(object sender, EventArgs e)
        {
            utils = new Ultilities();
            barang = new BarangDataHelper();
            tss = new Transaksi();

            string tanggal = DateTime.Now.ToString("dd-MM-yyyy");

            if (_kode.Count > 0)
            {
                Cash _cash = new Cash();
                _cash.ShowDialog();

                //Mengambil input nominal dari form cash
                cash = int.Parse(_cash.txtCash.Text);

                //Jika nominal lebih besar / sama dengan dari total biaya
                if (cash >= TotalBiaya)
                {
                    int newTotalTrans;
                    //Mengupdate total transaksi
                    newTotalTrans = tss.GetTotalTransaksi();
                    newTotalTrans += 1;
                    tss.UpdateTotalTransaksi(newTotalTrans);

                    //Mengambil data pada keranjang belanja
                    for (int i = 0; i < _kode.Count; i++)
                    {
                        /* Mengambil value stock pada barang
                         * di keranjang belanja untuk langsung
                         * dikurangi dengan jumlah pembelian.
                         * */
                        int newStock = 0, newTerjual = 0;
                        for (int b=0; b < barang.GetNama().Count; b++)
                        {
                            if (barang.GetNama()[b] == _name[i])
                            {
                                newStock = barang.GetStock()[b];
                                newTerjual = barang.GetTerjual()[b];
                            }
                        }
                        //Mengupdate jumlah stock barang tersebut
                        newStock -= _jumlah[i];
                        barang.UpdateStock(_name[i], newStock);
                        //Mengupdate barang terjual
                        newTerjual += _jumlah[i];
                        barang.UpdateTerjual(_name[i], newTerjual);

                        //Mendapatkan ID Transaksi
                        string IDTransaksi = "TR" + tss.GetTotalTransaksi().ToString("00000");

                        //Menambah data transaksi ke dalam database
                        tss.AddTransaksi(IDTransaksi, _name[i], _kode[i], _jenis[i], _stock[i], _jumlah[i], _rawHarga[i], tanggal, username, _diskon[i], _harga[i]);

                    }

                    //Membersihkan keranjang belanja
                    ClearKeranjang();

                    //Mendapatkan data transaksi
                    GetTransaksi();

                    //Mendapatkan total Stock
                    GetTotalStock();

                    //Mendapatkan total profit
                    GetProfit();

                    //Mendapatkan total nominal transaksi
                    GetTotalPay();

                    //Mendapatkan barang terlaris
                    GetBarangTerlaris();

                    lblDetailTotalBiaya.Text = "Rp0";
                }
                else
                {
                    utils.ShowMessage("Nominal cash tidak mencukupi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                utils.ShowMessage("Keranjang Belanjang kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
        }

        /// <summary>
        /// Mendapatkan data transaksi
        /// lalu menampilkannya dalam datagridview
        /// </summary>
        private void GetTransaksi()
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM kasir_transaksi", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    dataGridTransaksi.Rows.Clear();
                    while (reader.Read())
                    {

                        string hGet = reader.GetValue(reader.GetOrdinal("Harga Barang")).ToString();
                        string tBiaya = reader.GetValue(reader.GetOrdinal("Total Biaya")).ToString();
                        dataGridTransaksi.Rows.Add(new object[]
                        {
                            reader.GetValue(reader.GetOrdinal("ID")),
                            reader.GetValue(reader.GetOrdinal("ID Transaksi")),
                            reader.GetValue(reader.GetOrdinal("Nama Barang")),
                            reader.GetValue(reader.GetOrdinal("Kode Barang")),
                            reader.GetValue(reader.GetOrdinal("Jenis Barang")),
                            reader.GetValue(reader.GetOrdinal("Stock Barang")),
                            reader.GetValue(reader.GetOrdinal("Jumlah Barang")),
                            "Rp" + int.Parse(hGet).ToString("N0"),
                            reader.GetValue(reader.GetOrdinal("Tanggal")),
                            reader.GetValue(reader.GetOrdinal("Kasir")),
                            reader.GetValue(reader.GetOrdinal("Diskon")),
                            "Rp" + int.Parse(tBiaya).ToString("N0")
                        });
                    }
                    con.Close();
                }
            }

        }

        /// <summary>
        /// Mendapatkan total nominal transaksi
        /// </summary>
        public void GetTotalPay()
        {
            tss = new Transaksi();
            lblTotalTransaksi.Text = "Rp" + tss.GetTotalPay().ToString("N0");
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            Pengaturan setting = new Pengaturan();
            setting.username = username;
            setting.ShowDialog();

            //UI akan merefresh biodata user
            GetBiodata();
        }

        /// <summary>
        /// Mendapatkan barang terlaris
        /// </summary>
        /// 
        private string[] row = new string[4];
        private void GetBarangTerlaris()
        {
            myDb = new DatabaseHelper();

            listBarangTerlaris.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list ORDER BY [Terjual] DESC", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    int rank = 0;
                    while (reader.Read())
                    {
                        rank++;
                        int harga = int.Parse(reader["Harga Jual"].ToString());
                        row[0] = "Rp" + harga.ToString("N0");
                        row[1] = reader["Terjual"].ToString();
                        row[2] = rank.ToString();
                        
                        if (row[1] != "0")
                        {
                            listBarangTerlaris.Items.Add(reader["Nama Barang"].ToString(), 0).SubItems.AddRange(row);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void btnTentang_Click(object sender, EventArgs e)
        {
            Tentang about = new Tentang();
            about.Show();
        }

        private void btnInfoProfit_Click(object sender, EventArgs e)
        {
            utils = new Ultilities();

            utils.ShowMessage("Perolehan profit berdasarkan pada hasil\ndari harga jual barang dikurangi oleh\nharga beli barang.\nDan transaksi yang memakai diskon \nakan tetap mengambil value profit no diskon.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }
    }
}
