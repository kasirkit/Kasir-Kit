using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Kasir_Kit
{
    public class BarangDataHelper
    {
        /* Class ini berfungsi untuk melakukan pengolahan data
         * barang pada sistem 
         * 
         * @author: Yusril Takeuchi
         * */

        //Mendeklarasikan objek class
        DatabaseHelper myDb;

        /// <summary>
        /// Mendapatkan daftar Jenis Barang pada database
        /// </summary>
        /// <returns></returns>
        public List<string> GetJenisBarang()
        {
            myDb = new DatabaseHelper();
            var listJenis = new List<string>();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_jenis", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        listJenis.Add(reader["Jenis Barang"].ToString());
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return listJenis;
        }

        /// <summary>
        /// Mendapatkan daftar ID Barang
        /// </summary>
        /// <returns></returns>
        public List<int> GetID()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        searcher.Add(int.Parse(reader["ID"].ToString()));
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar Kode Barang
        /// </summary>
        /// <returns></returns>
        public List<string> GetKode()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<string>();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        searcher.Add(reader["Kode Barang"].ToString());
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar nama barang
        /// </summary>
        /// <returns></returns>
        public List<string> GetNama()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<string>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(reader["Nama Barang"].ToString());
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan Daftar Jenis Barang
        /// </summary>
        /// <returns></returns>
        public List<string> GetJenis()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<string>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(reader["Jenis Barang"].ToString());
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan Daftar Supplier
        /// </summary>
        /// <returns></returns>
        public List<string> GetSupplier()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<string>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(reader["Supplier"].ToString());
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar stock barang
        /// </summary>
        /// <returns></returns>
        public List<int> GetStock()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(int.Parse(reader["Stock Barang"].ToString()));
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar harga jual barang
        /// </summary>
        /// <returns></returns>
        public List<int> GetHargaJual()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(int.Parse(reader["Harga Jual"].ToString()));
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar harga beli
        /// </summary>
        /// <returns></returns>
        public List<int> GetHargaBeli()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(int.Parse(reader["Harga Beli"].ToString()));
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkat daftar biaya produksi barang
        /// </summary>
        /// <returns></returns>
        public List<int> GetBiayaProduksi()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(int.Parse(reader["Biaya Produksi"].ToString()));
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan daftar terjual barang
        /// </summary>
        /// <returns></returns>
        public List<int> GetTerjual()
        {
            myDb = new DatabaseHelper();
            var searcher = new List<int>();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        searcher.Add(int.Parse(reader["Terjual"].ToString()));
                    }
                    con.Close();
                }
            }
            return searcher;
        }

        /// <summary>
        /// Mendapatkan Total Barang
        /// </summary>
        /// <returns></returns>
        public int GetTotalBarang()
        {
            int count = 0;

            /* Loop semua data ID pada barang
             * lalu menghitungnya menggunakan
             * variable count 
             * */
            foreach (int i in GetID())
            {
                count++;
            }

            return count;
        }

        //Mendapatkan Total Stock Barang
        public int GetTotalStock()
        {
            int count = 0;

            /* Loop semua data Stock pada barang
            * lalu menghitungnya menggunakan
            * variable count 
            * */
            foreach (int i in GetStock())
            {
                count += i;
            }

            return count;
        }

        /// <summary>
        /// Melakukan pengecekan apakah telah tersedia sebuah jenis barang
        /// </summary>
        /// <param name="jenis"></param>
        /// <returns></returns>
        public bool isJenisExists(string jenis)
        {
            myDb = new DatabaseHelper();
            bool exists = false;
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_jenis WHERE [Jenis Barang] = '" + jenis + "'", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exists = true;
                    }
                    con.Close();
                }
            }
            return exists;
        }

        /// <summary>
        /// Menambahkan jenis barang baru
        /// </summary>
        /// <param name="jenis"></param>
        public void AddJenisBarang(string jenis)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO barang_jenis('Jenis Barang') VALUES(@jenis)", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@jenis", jenis));
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        /// <summary>
        /// Menghapus Jenis Barang pada database
        /// </summary>
        /// <param name="jenis"></param>
        public void RemoveJenisBarang(string jenis)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmds = new SQLiteCommand("DELETE FROM barang_jenis WHERE [Jenis Barang] = '" + jenis + "'", con))
                {
                    con.Open();

                    cmds.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Melakukan pengecekan ketersediaan barang
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public bool isBarangExists(string nama)
        {
            myDb = new DatabaseHelper();
            bool exists = false;

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list WHERE [Nama Barang] = '" + nama + "'", con))
                {
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exists = true;
                    }

                    con.Close();
                }
            }
            return exists;
        }

        /// <summary>
        /// Melakukan pengecekan ketersediaan kode barang
        /// </summary>
        /// <param name="kode"></param>
        /// <returns></returns>
        public bool isKodeExists(string kode)
        {
            myDb = new DatabaseHelper();
            bool exists = false;

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM barang_list WHERE [Kode Barang] = '" + kode + "'", con))
                {
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exists = true;
                    }

                    con.Close();
                }
            }
            return exists;
        }

        /// <summary>
        /// Menambah Barang baru ke dalam database
        /// </summary>
        /// <param name="kode"></param>
        /// <param name="nama"></param>
        /// <param name="jenis"></param>
        /// <param name="supplier"></param>
        /// <param name="stock"></param>
        /// <param name="hargaJual"></param>
        /// <param name="hargaBeli"></param>
        /// <param name="biayaProduksi"></param>
        /// <param name="terjual"></param>
        public void AddBarang(string kode, string nama, string jenis, string supplier, int stock, int hargaJual, int hargaBeli, int biayaProduksi, int terjual)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO barang_list([Kode Barang], [Nama Barang], [Jenis Barang], [Supplier], [Stock Barang], [Harga Jual], [Harga Beli], [Biaya Produksi], [Terjual]) VALUES(@kode, @nama, @jenis, @supplier, @stock, @hJual, @hBeli, @bProduksi, @terjual)", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@kode", kode));
                    cmd.Parameters.Add(new SQLiteParameter("@nama", nama));
                    cmd.Parameters.Add(new SQLiteParameter("@jenis", jenis));
                    cmd.Parameters.Add(new SQLiteParameter("@supplier", supplier));
                    cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
                    cmd.Parameters.Add(new SQLiteParameter("@hJual", hargaJual));
                    cmd.Parameters.Add(new SQLiteParameter("@hBeli", hargaBeli));
                    cmd.Parameters.Add(new SQLiteParameter("@bProduksi", biayaProduksi));
                    cmd.Parameters.Add(new SQLiteParameter("@terjual", terjual));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Menghapus barang yang telah terpilih
        /// </summary>
        /// <param name="nama"></param>
        public void RemoveBarang(string nama)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmds = new SQLiteCommand("DELETE FROM barang_list WHERE [Nama Barang] = '" + nama + "'", con))
                {
                    con.Open();

                    cmds.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


        /// <summary>
        /// Melakukan perubahan data barang 
        /// pada data yang sudah ada
        /// </summary>
        /// <param name="kode"></param>
        /// <param name="nama"></param>
        /// <param name="jenis"></param>
        /// <param name="supplier"></param>
        /// <param name="stock"></param>
        /// <param name="hargaJual"></param>
        /// <param name="hargaBeli"></param>
        /// <param name="biayaProduksi"></param>
        public void UpdateBarang(string kode, string nama, string jenis, string supplier, int stock, int hargaJual, int hargaBeli, int biayaProduksi)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE barang_list SET [Kode Barang] = @kode, [Nama Barang] = @nama, [Jenis Barang] = @jenis, [Supplier] = @supplier, [Stock Barang] = @stock, [Harga Jual] = @hJual, [Harga Beli] = @hBeli, [Biaya Produksi] = @bProduksi WHERE [Kode Barang] = '" + kode + "'", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@kode", kode));
                    cmd.Parameters.Add(new SQLiteParameter("@nama", nama));
                    cmd.Parameters.Add(new SQLiteParameter("@jenis", jenis));
                    cmd.Parameters.Add(new SQLiteParameter("@supplier", supplier));
                    cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
                    cmd.Parameters.Add(new SQLiteParameter("@hJual", hargaJual));
                    cmd.Parameters.Add(new SQLiteParameter("@hBeli", hargaBeli));
                    cmd.Parameters.Add(new SQLiteParameter("@bProduksi", biayaProduksi));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Menghitung jumlah keuntungan barang
        /// dari perhitungan modal dan harga jual
        /// </summary>
        /// <param name="hargaJual"></param>
        /// <param name="hargaBeli"></param>
        /// <param name="biayaProduksi"></param>
        /// <returns></returns>
        public int Keuntungan(int hargaJual, int hargaBeli, int biayaProduksi, int terjual)
        {
            return (hargaJual - hargaBeli - biayaProduksi) * terjual;
        }

        /// <summary>
        /// Melakukan update data pada stock barang
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        public void UpdateStock(string name, int amount)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE barang_list SET [Stock Barang] = @newStock WHERE [Nama Barang] = '" + name + "'", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@newStock", amount));
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        /// <summary>
        /// Melakukan update data pada barang terjual
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        public void UpdateTerjual(string name, int amount)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE barang_list SET [Terjual] = @newTerjual WHERE [Nama Barang] = '" + name + "'", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@newTerjual", amount));
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
    }
}
