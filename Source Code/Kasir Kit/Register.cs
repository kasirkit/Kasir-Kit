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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        //Deklarasi Objek Class
        Account acc;
        Ultilities util;
        Encryption encrypt;

        /// <summary>
        /// Proses pendaftaran account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            acc = new Account();
            util = new Ultilities();
            encrypt = new Encryption();

            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty
                && txtConfirmPassword.Text != string.Empty
                && txtEmail.Text != string.Empty
                && txtFirstname.Text != string.Empty
                && txtLastname.Text != string.Empty)
            {
                //Melakukan pengecekan kecocokan password dan confirm password
                if (txtPassword.Text == txtConfirmPassword.Text)
                {

                    //Username, Password harus terdiri lebih dari 8 karakter
                    if (txtPassword.Text.Length >= 8 
                        && txtConfirmPassword.Text.Length >= 8
                        && txtUsername.Text.Length >= 8)
                    {
                        //Mendeteksi kevalidan email yang di mana terdapat tanda "@"
                        if (txtEmail.Text.Contains("@"))
                        {
                            try
                            {
                                if (!acc.isExistsData(txtUsername.Text))
                                {
                                    //Menambahkan akun yang terdaftar ke dalam database
                                    acc.Add(txtUsername.Text, encrypt.HashPassword(txtPassword.Text), txtEmail.Text, txtFirstname.Text, txtLastname.Text, "Kasir");

                                    util.ShowMessage("Berhasil mendaftar akun!", "Pendaftaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    util.ShowMessage("Username tersebut sudah ada!", "Gagal Mendaftar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                util.ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            util.ShowMessage("Alamat email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        util.ShowMessage("Username dan Password harus\nterdiri lebih dari 8 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    util.ShowMessage("Password tidak sama!", "Gagal Mendaftar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                util.ShowMessage("Silahkan isi semua bagian!", "Gagal Mendaftar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
