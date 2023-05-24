using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo2
{
    public partial class sub : Form
    {
        private string openDialog()
        {
            string path = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "data.txt";

            ofd.InitialDirectory = @"C:\";

            ofd.Filter = "Text Files (*.txt)| *.*";

            ofd.Title = "Please select save data file";

            ofd.RestoreDirectory = true;

            ofd.CheckFileExists = true;

            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }

            return path;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Program.Global.code = 0;
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string filePath = openDialog();

            if (filePath == "")
            {
                Program.Global.code = 0;
            }
            else
            {
                Program.Global.code = 1;
            }
            Close();
        }

        public sub()
        {
            InitializeComponent();
        }
    }
}
