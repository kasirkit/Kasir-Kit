using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public class DatabaseHelper
    {
        /* Class ini berfungsi untuk melakukan manajemen backend database.
         * Di mana sebagian sistem dikerjakan di sini, seperti pembuatan database, sampai
         * penyedia koneksi data source 
         *
         * @author: Yusril Takeuchi
         * */

        SQLiteCommand cmd;

        //Database filename
        public string DatabaseName = "Kasir.db";

        /// <summary>
        /// Method untuk mengambil Data Source Connection database.
        /// </summary>
        /// <returns></returns>
        public string GetConnection()
        {
            return @"Data Source=" + DatabaseName + "; Version=3";
        }

        /// <summary>
        /// Method untuk membuat database Table dan Columns
        /// </summary>
        public void CreateDatabase()
        {
            using (SQLiteConnection con = new SQLiteConnection(GetConnection()))
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;

                string user = @"CREATE TABLE user_account (ID INTEGER PRIMARY KEY AUTOINCREMENT, Username Text(50), Password Text(50), Email Text(50), Firstname Text(50), Lastname Text(50), Type Text(25))";
                cmd.CommandText = user;
                cmd.ExecuteNonQuery();

                string barangList = @"CREATE TABLE barang_list (ID INTEGER PRIMARY KEY AUTOINCREMENT, 'Kode Barang' Text(25), 'Nama Barang' Text(50), 'Jenis Barang' Text(50), Supplier Text(50), 'Stock Barang' INTEGER, 'Harga Jual' INTEGER, Terjual INTEGER, 'Harga Beli' INTEGER, 'Biaya Produksi' INTEGER)";
                cmd.CommandText = barangList;
                cmd.ExecuteNonQuery();

                string barangJenis = @"CREATE TABLE barang_jenis (ID INTEGER PRIMARY KEY AUTOINCREMENT, 'Jenis Barang' Text(50))";
                cmd.CommandText = barangJenis;
                cmd.ExecuteNonQuery();

                string kasirTransaksi = @"CREATE TABLE kasir_transaksi (ID INTEGER PRIMARY KEY AUTOINCREMENT, 'ID Transaksi' Text(50), 'Nama Barang' Text(50), 'Kode Barang' Text(50), 'Jenis Barang' Text(50), 'Stock Barang' Text(50), 'Jumlah Barang' INTEGER, 'Harga Barang' INTEGER, Tanggal Text(50), Kasir Text(50), Diskon INTEGER, 'Total Biaya' INTEGER)";
                cmd.CommandText = kasirTransaksi;
                cmd.ExecuteNonQuery();

                string kasirTotal = @"CREATE TABLE kasir_total (ID INTEGER PRIMARY KEY AUTOINCREMENT, 'Total Transaksi' INTEGER)";
                cmd.CommandText = kasirTotal;
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        /// <summary>
        /// Input value 0 ke total transaksi
        /// </summary>
        /// <param name="num"></param>
        public void InsertTotalTransaksi(int num)
        {
            using (SQLiteConnection con = new SQLiteConnection(GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO kasir_total([Total Transaksi]) VALUES(@total)", con))
                {
                    con.Open();

                    cmd.Parameters.Add(new SQLiteParameter("@total", num));
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
    }
}
