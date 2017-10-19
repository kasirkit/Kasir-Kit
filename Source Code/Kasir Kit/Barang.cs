using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public partial class Barang : MetroFramework.Forms.MetroForm
    {
        public Barang()
        {
            InitializeComponent();
        }

        //Deklarasi objek class
        BarangDataHelper barang;
        Ultilities utils;
        DatabaseHelper myDb;

        private void Barang_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            //Mengambil Daftar Jenis Barang
            GetJenisData();
            GetDaftarBarang();

            radioHargaBeli.Checked = true;
        }

        private void groupDesc_Enter(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Add Barang Selected
            if (metroTabControl1.SelectedTab.Text == "Add Barang")
            {
                metroTabControl1.SelectedIndex = 0;
                TabEdit.Text = "Edit Barang";
                TabRemove.Text = "Remove Barang";
                TabAdd.Text = "Add Barang";
                groupDesc.Enabled = true;

                btnTambah.Enabled = true;
                btnHapus.Enabled = false;
                btnSimpan.Enabled = false;
                txtKode.Enabled = true;

                ClearText();
                indexBarang = string.Empty;
            
            }

            //Edit Barang Selected
            if (metroTabControl1.SelectedTab.Text == "Edit Barang")
            {
                metroTabControl1.SelectedIndex = 0;
                TabEdit.Text = "Add Barang";
                TabRemove.Text = "Remove Barang";
                TabAdd.Text = "Edit Barang";
                groupDesc.Enabled = true;

                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                btnSimpan.Enabled = true;
                txtKode.Enabled = false;

                ClearText();
                indexBarang = string.Empty;
            }

            //Remove Barang Selected
            if (metroTabControl1.SelectedTab.Text == "Remove Barang")
            {
                metroTabControl1.SelectedIndex = 0;
                TabEdit.Text = "Edit Barang";
                TabRemove.Text = "Add Barang";
                TabAdd.Text = "Remove Barang";
                groupDesc.Enabled = false;

                btnTambah.Enabled = false;
                btnHapus.Enabled = true;
                btnSimpan.Enabled = false;

                ClearText();
                indexBarang = string.Empty;
            }
        }

        /// <summary>
        /// Mendapatkan daftar Jenis Barang yang tersedia dalam Database
        /// </summary>
        public void GetJenisData()
        {
            barang = new BarangDataHelper();

            //Menghapus seluruh item di daftar jenis agar tidak terjadi duplikasi data
            comboJenisBarang.Items.Clear();

            //Melakukan looping dari seluruh jenis barang yang terdapat dalam database
            foreach (string jenis in barang.GetJenisBarang())
            {
                //Memasukkan data tersebut ke dalam comboBox
                comboJenisBarang.Items.Add(jenis);
            }
        }

        /// <summary>
        /// Menambah barang baru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTambah_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();

            if (txtKode.Text != string.Empty
                && txtNamaBarang.Text != string.Empty
                && comboJenisBarang.Text != string.Empty
                && txtSupplier.Text != string.Empty
                && txtStock.Text != string.Empty
                && txtHargaJual.Text != string.Empty
                && txtHargaBeli.Text != string.Empty
                && txtBiayaProduksi.Text != string.Empty)
            {
                if (!barang.isBarangExists(txtNamaBarang.Text) 
                    && !barang.isKodeExists(txtKode.Text))
                {
                    try
                    {
                        int terjual = 0;

                        barang.AddBarang(txtKode.Text
                            , txtNamaBarang.Text
                            , comboJenisBarang.Text
                            , txtSupplier.Text
                            , int.Parse(txtStock.Text)
                            , int.Parse(txtHargaJual.Text)
                            , int.Parse(txtHargaBeli.Text)
                            , int.Parse(txtBiayaProduksi.Text)
                            , terjual);

                        utils.ShowMessage("Berhasil menambah barang", "Tambah Barang Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Clear Textbox
                        ClearText();

                        /* Menjalankan method di background
                         * hal ini mencegah terjadinya crash jika melakukan
                         * load barang dalam jumlah gede
                         * */
                        Thread daftar = new Thread(() => GetDaftarBarang());
                        daftar.Start();
                    }
                    catch(Exception ex)
                    {
                        utils.ShowMessage(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    utils.ShowMessage("Barang tersebut sudah ada!", "Gagal Tambah Barang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                utils.ShowMessage("Silahkan isi semua bagian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Membersihkan text Textbox
        /// </summary>
        private void ClearText()
        {
            utils = new Ultilities();
            utils.ClearTextBox(txtKode, string.Empty);
            utils.ClearTextBox(txtNamaBarang, string.Empty);
            comboJenisBarang.SelectedIndex = -1;
            utils.ClearTextBox(txtSupplier, string.Empty);
            utils.ClearTextBox(txtStock, string.Empty);
            utils.ClearTextBox(txtHargaJual, string.Empty);
            utils.ClearTextBox(txtHargaBeli, "0");
            utils.ClearTextBox(txtBiayaProduksi, "0");
        }

        /// <summary>
        /// Mendapatkan daftar barang
        /// </summary>
        private void GetDaftarBarang()
        {
            /* Jika kalian ingin membuat sebuah method
             * yang dipanggil melalui system threading.
             * Maka Anda harus menginvoke UI-UI yang akan
             * dieksekusi terlebih dahulu 
             * */
            Invoke((MethodInvoker)delegate {
                barang = new BarangDataHelper();
                dataGridBarang.Rows.Clear();

                for (int i = 0; i < barang.GetID().Count; i++)
                {
                    dataGridBarang.Rows.Add(new object[]
                    {
                    barang.GetID()[i],
                    barang.GetKode()[i],
                    barang.GetNama()[i],
                    barang.GetJenis()[i],
                    barang.GetSupplier()[i],
                    barang.GetStock()[i],
                    "Rp" + barang.GetHargaJual()[i].ToString("N0"),
                    "Rp" + barang.GetHargaBeli()[i].ToString("N0"),
                    "Rp" + barang.GetBiayaProduksi()[i].ToString("N0"),
                    barang.GetTerjual()[i],
                    "Rp" + barang.Keuntungan(barang.GetHargaJual()[i]
                    , barang.GetHargaBeli()[i], barang.GetBiayaProduksi()[i]
                    , barang.GetTerjual()[i]).ToString("N0")
                    });
                }
            });         
        }

        private void radioHargaBeli_CheckedChanged(object sender, EventArgs e)
        {
            txtHargaBeli.Enabled = true;
            txtHargaBeli.Text = "0";

            txtBiayaProduksi.Enabled = false;
            txtBiayaProduksi.Text = "0";
        }

        private void radioBiayaProduksi_CheckedChanged(object sender, EventArgs e)
        {
            txtHargaBeli.Enabled = false;
            txtHargaBeli.Text = "0";

            txtBiayaProduksi.Enabled = true;
            txtBiayaProduksi.Text = "0";
        }


        /// <summary>
        /// Menghapus barang dari database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();

            if (indexBarang != string.Empty)
            {
                try
                {
                    barang.RemoveBarang(indexBarang);
                    utils.ShowMessage("Barang berhasil terhapus!", "Hapus Barang Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Melakukan refresh UI
                    ClearText();
                    indexBarang = string.Empty;

                    /* Menjalankan method di background
                     * hal ini mencegah terjadinya crash jika melakukan
                     * load barang dalam jumlah gede
                     * */
                    Thread daftar = new Thread(() => GetDaftarBarang());
                    daftar.Start();
                }
                catch(Exception ex)
                {
                    utils.ShowMessage(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        string indexBarang;
        private void dataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroTabControl1.SelectedTab.Text == "Remove Barang" || metroTabControl1.SelectedTab.Text == "Edit Barang")
            {
                txtKode.Text = dataGridBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                indexBarang = dataGridBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNamaBarang.Text = indexBarang;
                comboJenisBarang.SelectedIndex = comboJenisBarang.Items.IndexOf(dataGridBarang.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtSupplier.Text = dataGridBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStock.Text = dataGridBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtHargaJual.Text = dataGridBarang.Rows[e.RowIndex].Cells[6].Value.ToString().Replace("Rp", "").Replace(",", "");
                txtHargaBeli.Text = dataGridBarang.Rows[e.RowIndex].Cells[7].Value.ToString().Replace("Rp", "").Replace(",", ""); ;
                txtBiayaProduksi.Text = dataGridBarang.Rows[e.RowIndex].Cells[8].Value.ToString().Replace("Rp", "").Replace(",", ""); ;
            }
        }

        /// <summary>
        /// Melakukan perubahan data pada barang ke data baru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();

            if (indexBarang != string.Empty)
            {
                try
                {
                    barang.UpdateBarang(txtKode.Text
                        , txtNamaBarang.Text
                        , comboJenisBarang.Text
                        , txtSupplier.Text
                        , int.Parse(txtStock.Text)
                        , int.Parse(txtHargaJual.Text)
                        , int.Parse(txtHargaBeli.Text)
                        , int.Parse(txtBiayaProduksi.Text));

                    utils.ShowMessage("Berhasil mengubah data!", "Edit Barang Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Melakukan refresh UI
                    ClearText();
                    indexBarang = string.Empty;

                    /* Menjalankan method di background
                     * hal ini mencegah terjadinya crash jika melakukan
                     * load barang dalam jumlah gede
                     * */
                    Thread daftar = new Thread(() => GetDaftarBarang());
                    daftar.Start();
                }
                catch(Exception ex)
                {
                    utils.ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool search = false;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCari.Text != string.Empty)
            {
                if (!search)
                {
                    search = true;
                    btnSearch.Text = "Batal";

                    //Mencari barang sesuai keyword
                    searchSomething(txtCari.Text);
                }
                else
                {
                    search = false;
                    btnSearch.Text = "Search";
                    txtCari.Text = string.Empty;

                    //Mengembalikan keadaan semula
                    Thread daftar = new Thread(() => GetDaftarBarang());
                    daftar.Start();
                }
            }
        }

        /// <summary>
        /// Mencari barang sesuai keyword dari database
        /// </summary>
        /// <param name="keyword"></param>
        private void searchSomething(string keyword)
        {
            myDb = new DatabaseHelper();
            utils = new Ultilities();
            barang = new BarangDataHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list WHERE [Nama Barang] LIKE '%" + keyword + "%'", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        dataGridBarang.Rows.Clear();
                        count++;
                        string obj = reader.GetValue(reader.GetOrdinal("Harga Jual")).ToString();
                        string obj2 = reader.GetValue(reader.GetOrdinal("Harga Beli")).ToString();
                        string obj3 = reader.GetValue(reader.GetOrdinal("Biaya Produksi")).ToString();
                        string obj4 = reader.GetValue(reader.GetOrdinal("Terjual")).ToString();
                        int untung = barang.Keuntungan(int.Parse(obj), int.Parse(obj2), int.Parse(obj3), int.Parse(obj4));

                        dataGridBarang.Rows.Add(new object[]
                        {
                            reader.GetValue(reader.GetOrdinal("ID")),
                            reader.GetValue(reader.GetOrdinal("Kode Barang")),
                            reader.GetValue(reader.GetOrdinal("Nama Barang")),
                            reader.GetValue(reader.GetOrdinal("Jenis Barang")),
                            reader.GetValue(reader.GetOrdinal("Supplier")),
                            reader.GetValue(reader.GetOrdinal("Stock Barang")),
                            "Rp" + int.Parse(obj).ToString("N0"),
                            "Rp" + int.Parse(obj2).ToString("N0"),
                            "Rp" + int.Parse(obj3).ToString("N0"),
                            obj4,
                            "Rp" + untung.ToString("N0")
                        });
                    }
                    if (count < 1)
                    {
                        utils.ShowMessage("Pencarian tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        search = false;
                        txtCari.Text = string.Empty;
                        btnSearch.Text = "Search";

                        //Mengembalikan keadaan semula
                        Thread daftar = new Thread(() => GetDaftarBarang());
                        daftar.Start();
                    }
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Ketika menekan enter pada saat mencari barang
        /// maka akan otomatis mengaktifkan tombol search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
    }
}
