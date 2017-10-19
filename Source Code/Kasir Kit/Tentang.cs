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
    public partial class Tentang : MetroFramework.Forms.MetroForm
    {
        public Tentang()
        {
            InitializeComponent();
        }

        private void Tentang_Load(object sender, EventArgs e)
        {

        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://yuranicorp.blogspot.com");
        }

        private void btnDonateUs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://yuranicorp.blogspot.co.id/p/donasi.html");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/yuranicorp/");
        }
    }
}
