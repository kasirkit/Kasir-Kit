using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public class Transaksi
    {
        /* Class ini berfungsi ketika melakukan
         * proses manajemen transaksi yang berkaitan
         * dengan database
         * 
         * @author: Yusril Takeuchi
         * */


        //Deklasrasi objek class
        BarangDataHelper barang;
        DatabaseHelper myDb;

        /// <summary>
        /// Mendapatkan profit penjualan berdasarkan
        /// barang yang terjual
        /// </summary>
        /// <returns></returns>
        public int GetProfit()
        {
            barang = new BarangDataHelper();

            int untung = 0;
            //Loop semua data id barang pada database
            for (int i = 0; i < barang.GetID().Count; i++)
            {
                /* Lalu melakukan perhitungan keuntungan
                 * dari tiap barang, dan menjumlahkan totalnya
                 * hingga menjadi bilangan profit utuh
                 * */
                untung += barang.Keuntungan(barang.GetHargaJual()[i]
                    , barang.GetHargaBeli()[i]
                    , barang.GetBiayaProduksi()[i]
                    , barang.GetTerjual()[i]);
            }

            return untung;
        }


        /// <summary>
        /// Mendapatkan total transaksi
        /// </summary>
        /// <returns></returns>
        public int GetTotalTransaksi()
        {
            myDb = new DatabaseHelper();
            string num = "0";

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM kasir_total", con))
                {
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        num = reader["Total Transaksi"].ToString();
                    }

                    con.Close();
                }
            }
            return int.Parse(num);
        }

        /// <summary>
        /// Mengupdate total transaksi
        /// </summary>
        /// <param name="amount"></param>
        public void UpdateTotalTransaksi(int amount)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE kasir_total SET [Total Transaksi] = @newTotal", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@newTotal", amount));
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        /// <summary>
        /// Menambahkan Data Transaksi ke dalam database
        /// </summary>
        /// <param name="idTrans"></param>
        /// <param name="name"></param>
        /// <param name="kode"></param>
        /// <param name="jenis"></param>
        /// <param name="stock"></param>
        /// <param name="jumlah"></param>
        /// <param name="harga"></param>
        /// <param name="tanggal"></param>
        /// <param name="kasir"></param>
        /// <param name="diskon"></param>
        /// <param name="totBiaya"></param>
        public void AddTransaksi(string idTrans, string name, string kode, string jenis, int stock, int jumlah, int harga, string tanggal, string kasir, int diskon, int totBiaya)
        {
            myDb = new DatabaseHelper();

            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO kasir_transaksi([ID Transaksi], [Nama Barang], [Kode Barang], [Jenis Barang], [Stock Barang], [Jumlah Barang], [Harga Barang], [Tanggal], [Kasir], [Diskon], [Total Biaya]) VALUES(@idTrans, @name, @kode, @jenis, @stock, @jumlah, @harga, @tanggal, @kasir, @diskon, @totBiaya)", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@idTrans", idTrans));
                    cmd.Parameters.Add(new SQLiteParameter("@name", name));
                    cmd.Parameters.Add(new SQLiteParameter("@kode", kode));
                    cmd.Parameters.Add(new SQLiteParameter("@jenis", jenis));
                    cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
                    cmd.Parameters.Add(new SQLiteParameter("@jumlah", jumlah));
                    cmd.Parameters.Add(new SQLiteParameter("@harga", harga));
                    cmd.Parameters.Add(new SQLiteParameter("@tanggal", tanggal));
                    cmd.Parameters.Add(new SQLiteParameter("@kasir", kasir));
                    cmd.Parameters.Add(new SQLiteParameter("@diskon", diskon));
                    cmd.Parameters.Add(new SQLiteParameter("@totBiaya", totBiaya));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Mendapatkan nominal total transaksi 
        /// </summary>
        /// <returns></returns>
        public int GetTotalPay()
        {
            int pay = 0;
            myDb = new DatabaseHelper();
            
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM kasir_transaksi", con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string money = reader["Total Biaya"].ToString();
                        pay += int.Parse(money);
                    }
                    con.Close();
                }
            }

            return pay;
        }
    }
}
