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
    public partial class Cash : MetroFramework.Forms.MetroForm
    {
        public Cash()
        {
            InitializeComponent();
        }

        private void Cash_Load(object sender, EventArgs e)
        {

        }

        Ultilities utils;
        private void btnOK_Click(object sender, EventArgs e)
        {
            utils = new Ultilities();
            if (txtCash.Text != string.Empty)
            {
                this.Close();
            }
            else
            {
                utils.ShowMessage("Nominal Cash tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(this, new EventArgs());
            }
        }
    }
}
