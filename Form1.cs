using System.Diagnostics;
using System.Security.Policy;
using WindowsTempFilesPurge.Backend.Purger;

namespace WindowsTempFilesPurge
{
    public partial class TempPurgeForm : Form
    {
        public TempPurgeForm()
        {
            InitializeComponent();
        }

        private void TempPurgeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $@"/c start https://github.com/TwwcTech") { CreateNoWindow = true }); // complete the url
        }

        private void PurgeFilesButton_Click(object sender, EventArgs e)
        {
            TempFilesPurger purger = new();
            purger.PurgeTempFiles(PurgeProgressBar);

            if(DownloadsCheckbox.Checked)
            {
                purger.PurgeFilesInDownloads(PurgeProgressBar);
            }
        }

        private void DownloadsCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
