using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Kit
{
    public class Ultilities
    {
        /* Class ini hanya sebagain Ultilitas saja, yaitu tidak menyimpan instruksi 
         * yang terlalu penting, hanya sebagai custom saja.
         *
         * @author: Yusril Takeuchi
         * */

        /// <summary>
        /// Membuat Custom MessageBox yang dapat dipanggil menggunakan Method baru
        /// </summary>
        /// <param name="text"></param>
        /// <param name="header"></param>
        /// <param name="button"></param>
        /// <param name="icon"></param>
        public void ShowMessage(string text, string header, MessageBoxButtons button, MessageBoxIcon icon)
        {
            MessageBox.Show(text, header, button, icon);
        }

        /// <summary>
        /// Melakukan pembersihan text pada TextBox
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public MetroFramework.Controls.MetroTextBox ClearTextBox(MetroFramework.Controls.MetroTextBox textBox, string text)
        {
            textBox.Text = text;
            return textBox;
        }

        /// <summary>
        /// Melakukan pengeksekusian pada UI di luar form
        /// </summary>
        /// <param name="label"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public MetroFramework.Controls.MetroLabel ClearLabel(MetroFramework.Controls.MetroLabel label, string text)
        {
            label.Text = text;
            return label;
        }
    }
}
