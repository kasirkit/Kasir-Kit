using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Kit
{
    public partial class JenisBarang : MetroFramework.Forms.MetroForm
    {
        public JenisBarang()
        {
            InitializeComponent();
        }

        //Objek class database
        BarangDataHelper barang;
        Ultilities utils;

        private void JenisBarang_Load(object sender, EventArgs e)
        {
            GetJenisData();
        }

        /// <summary>
        /// Mendapatkan daftar Jenis Barang yang tersedia dalam Database
        /// </summary>
        public void GetJenisData()
        {
            barang = new BarangDataHelper();

            //Menghapus seluruh item di daftar jenis agar tidak terjadi duplikasi data
            comboDaftarJenis.Items.Clear();

            //Melakukan looping dari seluruh jenis barang yang terdapat dalam database
            foreach(string jenis in barang.GetJenisBarang())
            {
                //Memasukkan data tersebut ke dalam comboBox
                comboDaftarJenis.Items.Add(jenis);
            }
        }

        /// <summary>
        /// Menambah Jenis Barang baru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTambah_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();

            if (txtJenis.Text != string.Empty)
            {
                if (!barang.isJenisExists(txtJenis.Text))
                {
                    try
                    {
                        //Menambahkan jenis barang baru
                        barang.AddJenisBarang(txtJenis.Text);

                        txtJenis.Text = string.Empty;
                        utils.ShowMessage("Berhasil menambah jenis barang!", "Tambah Jenis Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /* Setiap data yang dimasukkan, harus direfresh menggunakan
                         * method ini agar data yang ditambahkan ke database akan langsung
                         * bisa terlihat
                         * */
                        GetJenisData();
                    }
                    catch(Exception ex)
                    {
                        utils.ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    utils.ShowMessage("Jenis tersebut sudah ada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                utils.ShowMessage("Silahkan masukkan jenis barang!", "Masukkan Jenis Barang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Menghapus Jenis Barang yang sudah ada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            barang = new BarangDataHelper();
            utils = new Ultilities();
            /* Untuk menghapus beberapa jenis barang,
             * kita hanya perlu memilih jensi barang yang
             * sudah ada melalui combobox 
             * */
            if (comboDaftarJenis.Text != string.Empty)
            {
                try
                {
                    barang.RemoveJenisBarang(comboDaftarJenis.Text);

                    utils.ShowMessage("Berhasil menghapus jenis barang!", "Hapus Jenis Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetJenisData();
                }
                catch(Exception ex)
                {
                    utils.ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
