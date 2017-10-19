using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Kit
{
    public class FileManager
    {
        /* Class ini bertugas untuk melakukan manajemen file database,
         * di mana ia akan melakukan pengecekan ketersediaan file, dan lain sebagainya
         * 
         * @author: Yusril Takeuchi
         * */

        private string fileName;

        /// <summary>
        /// Constructor yang bertugas mengambil nama file database.
        /// </summary>
        /// <param name="file"></param>
        public FileManager(string file)
        {
            this.fileName = file;
        }

        /// <summary>
        /// Membuat file baru
        /// </summary>
        /// <param name="file"></param>
        public void CreateFile(string file)
        {
            File.Create(file);
        }

        /// <summary>
        /// Melakukan pengecekan tersedianya file database.
        /// </summary>
        /// <returns></returns>
        public bool isFileExists()
        {
            if (File.Exists(fileName))
            {
                return true;
            }

            return false;
        }
    }
}
