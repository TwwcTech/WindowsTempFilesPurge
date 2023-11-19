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
            AboutLabel.Text = "Windows Temp Files Purge is a utility designed to help " +
                "users maintain their digital hygiene by purging unnecessary temporary files that often clutter up storage space. " +
                "\n\n\nOne of the key features of TempFilePurge is its ability to also purge files from the Downloads folder. You have " +
                "the option to select this feature, which can be particularly useful for those who frequently download files " +
                "and forget to delete them later.";
            AboutLabel.AutoSize = false;
            AboutLabel.TextAlign = ContentAlignment.MiddleLeft;
            AboutLabel.Padding = new Padding(20, 0, 0, 0);
        }
    }
}
