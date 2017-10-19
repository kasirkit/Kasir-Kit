using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public partial class Choose : MetroFramework.Forms.MetroForm
    {
        public Choose()
        {
            InitializeComponent();
        }

        //Deklarasi objek class
        BarangDataHelper barang;
        Ultilities utils;
        DatabaseHelper myDb;

        private void Choose_Load(object sender, EventArgs e)
        {
            GetDaftarBarang();
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

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        public string barangChoose;
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            barangChoose = dataGridBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
