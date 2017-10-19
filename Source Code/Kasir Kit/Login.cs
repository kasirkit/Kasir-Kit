using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Kit
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public string username;
        public bool isLogged;

        //Mendeklarasikan objek class
        Account acc;
        Encryption encrypt;
        Ultilities utils;

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberID)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                checkBoxRemember.Checked = true;
            }
        }

        /// <summary>
        /// Membuka form registrasi akun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.ShowDialog();
        }

        /// <summary>
        /// Proses login akun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            acc = new Account();
            encrypt = new Encryption();
            utils = new Ultilities();

            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty)
            {
                if (acc.Login(txtUsername.Text, encrypt.HashPassword(txtPassword.Text))){

                    /* Menyimpan username yang berhasil login ke variable username
                     * yang berguna untuk diambill melalui form utama 
                     * */
                    username = txtUsername.Text;
                    isLogged = true;

                    utils.ShowMessage("Berhasil login!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (Properties.Settings.Default.RememberID)
                    {
                        Properties.Settings.Default.Username = username;
                        Properties.Settings.Default.Save();
                    }

                    this.Close();
                }
                else
                {
                    utils.ShowMessage("Username / password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = string.Empty;
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemember.Checked)
            {
                Properties.Settings.Default.RememberID = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.RememberID = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
