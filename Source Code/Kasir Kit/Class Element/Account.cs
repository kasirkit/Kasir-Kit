using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kasir_Kit
{
    public class Account
    {

        /* Class ini berfungsi untuk melakukan manajemen user account 
         * seperti menambah akun baru saat register, melakukan pengecekan akun saat login
         * bahkan sampai pengubahan data diri di bagian pengaturan 
         *
         * @author: Yusril Takeuchi
         * */

        //Mendeklarasikan objek class
        DatabaseHelper myDb;

        /// <summary>
        /// Mengambil nama depan pada user
        /// </summary>
        public string GetFirstname(string username)
        {
            myDb = new DatabaseHelper();
            string firstname = string.Empty;

            //Mengambil koneksi berdasarkan data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        firstname = reader["Firstname"].ToString();
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return firstname;
        }


        /// <summary>
        /// Mengambil data Lastname pada user
        /// </summary>
        public string GetLastname(string username)
        {
            myDb = new DatabaseHelper();
            string lastname = string.Empty;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        lastname = reader["Lastname"].ToString();
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return lastname;
        }

        /// <summary>
        /// Mendapatkan email user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetEmail(string username)
        {
            myDb = new DatabaseHelper();
            string email = string.Empty;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        email = reader["Email"].ToString();
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return email;
        }

        /// <summary>
        /// Mengambil data Type akun dari database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetType(string username)
        {
            myDb = new DatabaseHelper();
            string type = string.Empty;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        type = reader["Type"].ToString();
                    }
                    //Menutup koneksi database
                    con.Close();
                }

            }
            return type;
        }

        /// <summary>
        /// Mendapatkan password user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetPassword(string username)
        {
            myDb = new DatabaseHelper();
            string pw = string.Empty;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Proses pembacaan data berdasarkan kolom
                        pw = reader["Password"].ToString();
                    }
                    //Menutup koneksi database
                    con.Close();
                }

            }
            return pw;
        }

        /// <summary>
        /// Melakukan pengecekan apakah username tersebut ada pada database atau tidak
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool isExistsData(string username)
        {
            myDb = new DatabaseHelper();
            bool exists = false;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Jika data akun berhasil ditemukan maka value = true
                        exists = true;
                    }
                    //Menutup koneksi database
                    con.Close();
                }
            }
            return exists;
        }

        /// <summary>
        /// Membuat sebuah akun baru dan menambahkannya ke dalam database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="type"></param>
        public void Add(string users, string password, string email, string firstname, string lastname, string type)
        {
            myDb = new DatabaseHelper();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO user_account(Username, Password, Email, Firstname, Lastname, Type) VALUES(@username, @password, @email, @firstname, @lastname, @type)", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    //Parameter yang akan melakukan store data baru ke database melalui parameter @
                    cmd.Parameters.Add(new SQLiteParameter("@username", users));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.Parameters.Add(new SQLiteParameter("@firstname", firstname));
                    cmd.Parameters.Add(new SQLiteParameter("@lastname", lastname));
                    cmd.Parameters.Add(new SQLiteParameter("@type", type));

                    cmd.ExecuteNonQuery();
                    //Menutup koneksi database
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Autentikasi Login user pada aplikasi
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            myDb = new DatabaseHelper();
            bool logged = false;

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user_account WHERE Username = '" + username + "' AND Password = '" + password + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Jika input username dan password cocok dengan data maka value = true
                        logged = true;
                    }
                    //Menutup koneksi database
                    con.Close();
                }               
            }
            return logged;
        }

        /// <summary>
        /// Mengubah biodata user 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        public void UpdateUser(string username, string firstname, string lastname, string email)
        {
            myDb = new DatabaseHelper();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE user_account SET [Firstname] = @firstname, [Lastname] = @lastname, [Email] = @email WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    //Parameter yang akan melakukan store data baru ke database melalui parameter @
                    cmd.Parameters.Add(new SQLiteParameter("@firstname", firstname));
                    cmd.Parameters.Add(new SQLiteParameter("@lastname", lastname));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));

                    cmd.ExecuteNonQuery();
                    //Menutup koneksi database
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Mengupdate password user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void UpdatePassword(string username, string password)
        {
            myDb = new DatabaseHelper();

            //Mengambil koneksi berdasarkan query data source dari class DatabaseHelper
            using (SQLiteConnection con = new SQLiteConnection(myDb.GetConnection()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE user_account SET [Password] = @password WHERE Username = '" + username + "'", con))
                {
                    //Membuka koneksi database
                    con.Open();

                    //Parameter yang akan melakukan store data baru ke database melalui parameter @
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));

                    cmd.ExecuteNonQuery();
                    //Menutup koneksi database
                    con.Close();
                }
            }
        }

    }
}
