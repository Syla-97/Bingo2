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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string filePath = openDialog();

            if (filePath == "")
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                Program.Global.saveDataPath = filePath;
                DialogResult = DialogResult.Continue;
            }
            Close();
        }

        public sub()
        {
            InitializeComponent();
        }

        
    }
}
