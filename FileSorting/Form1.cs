namespace FileSorting
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            string path = PathText.Text.Trim();
            if (!string.IsNullOrEmpty(path))
            {
                Sorting fileSorting= new Sorting(path);
                fileSorting.RunTheApp();
                MessageBox.Show("Files sorted successfully!");
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = folderBrowserDialog1.SelectedPath;
                UpdateSortButtonEnabled();
            }
        }

        private void UpdateSortButtonEnabled()
        {
            SortBtn.Visible = !string.IsNullOrEmpty(PathText.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}