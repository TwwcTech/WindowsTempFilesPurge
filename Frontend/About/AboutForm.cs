namespace WindowsTempFilesPurge.Frontend.About
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            AboutLabel.Text = ""; // Complete the label text
        }
    }
}
