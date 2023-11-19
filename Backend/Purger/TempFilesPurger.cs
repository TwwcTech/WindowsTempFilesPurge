using System.Runtime.InteropServices;

namespace WindowsTempFilesPurge.Backend.Purger
{
    internal class TempFilesPurger
    {
        public string? TempFilesPath { get; private set; }
        public string? DownloadsPath { get; private set; }

        public TempFilesPurger()
        {
            var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            TempFilesPath = Path.GetFullPath($@"{localAppDataPath}\Temp");

            var downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            DownloadsPath = Path.GetFullPath($@"{downloadsPath}\Downloads");
        }

        public void PurgeTempFiles([Optional] ProgressBar tempProgressBar)
        {
            string[] allTempFiles = Directory.GetFiles(TempFilesPath!);
            if (allTempFiles.Length == 0)
            {
                MessageBox.Show("No file to purge", "No Files Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tempProgressBar.Maximum = allTempFiles.Length;
            for (int fileIndex = 0; fileIndex < allTempFiles.Length; fileIndex++)
            {
                try
                {
                    File.Delete(allTempFiles[fileIndex]);
                }
                catch { }
                tempProgressBar.Value = fileIndex + 1;
            }
            MessageBox.Show("Complete! \nThe files that were still in use could not be purged", "Temp File Purge Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tempProgressBar.Value = 0;
        }

        public void PurgeFilesInDownloads([Optional] ProgressBar downsProgressBar)
        {
            string[] downloadsFiles = Directory.GetFiles(DownloadsPath!);
            if (downloadsFiles.Length == 0)
            {
                MessageBox.Show("Downloads folder has no files!", "No Files Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            downsProgressBar.Maximum = downloadsFiles.Length;
            for (int fileIndex = 0; fileIndex < downloadsFiles.Length; fileIndex++)
            {
                try
                {
                    File.Delete(downloadsFiles[fileIndex]);
                    downsProgressBar.Value = fileIndex;
                }
                catch { }
                downsProgressBar.Value = fileIndex + 1;
            }
            MessageBox.Show("Complete! \nThe files that were still in use have not been purged", "Downloads Files Purge Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            downsProgressBar.Value = 0;
        }
    }
}
