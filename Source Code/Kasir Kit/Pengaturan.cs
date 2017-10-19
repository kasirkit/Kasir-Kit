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
    public partial class Pengaturan : MetroFramework.Forms.MetroForm
    {
        public Pengaturan()
        {
            InitializeComponent();
        }

        //Deklarasi objek class
        Account acc;
        Ultilities utils;
        Encryption security;

        //Username kasir
        public string username;
        private void Pengaturan_Load(object sender, EventArgs e)
        {
            tabSettings.SelectedIndex = 0;

            //Mendapatkan details user
            GetDetails();
        }


        /// <summary>
        /// Mendapatkan detail user 
        /// seperti firstname, lastname dan email
        /// </summary>
        private void GetDetails()
        {
            acc = new Account();
            utils = new Ultilities();

            utils.ClearTextBox(txtFirstname, acc.GetFirstname(username));
            utils.ClearTextBox(txtLastname, acc.GetLastname(username));
            utils.ClearTextBox(txtEmail, acc.GetEmail(username));
        }

        /// <summary>
        /// Menyimpan data perubahan details user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            acc = new Account();
            utils = new Ultilities();

            if (txtEmail.Text != string.Empty
                && txtFirstname.Text != string.Empty
                && txtLastname.Text != string.Empty)
            {
                acc.UpdateUser(username, txtFirstname.Text, txtLastname.Text, txtEmail.Text);

                utils.ShowMessage("Berhasil menyimpan perubahan!", "Ubah Details Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                utils.ShowMessage("Field tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSimpanPW_Click(object sender, EventArgs e)
        {
            security = new Encryption();
            utils = new Ultilities();
            acc = new Account();

            if (txtPasswordLama.Text != string.Empty
                && txtPasswordBaru.Text != string.Empty)
            {
                if (security.HashPassword(txtPasswordLama.Text) == acc.GetPassword(username))
                {
                    acc.UpdatePassword(username, security.HashPassword(txtPasswordBaru.Text));

                    utils.ShowMessage("Berhasil mengubah password", "Ubah Password Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    utils.ClearTextBox(txtPasswordLama, string.Empty);
                    utils.ClearTextBox(txtPasswordBaru, string.Empty);
                }
                else
                {
                    utils.ShowMessage("Password lama salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
