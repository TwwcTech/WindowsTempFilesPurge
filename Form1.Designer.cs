namespace WindowsTempFilesPurge
{
    partial class TempPurgeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TempPurgeMenu = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            PurgeFilesButton = new Button();
            DownloadsCheckbox = new CheckBox();
            progressBar1 = new ProgressBar();
            TempPurgeMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TempPurgeMenu
            // 
            TempPurgeMenu.ImageScalingSize = new Size(24, 24);
            TempPurgeMenu.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            TempPurgeMenu.Location = new Point(0, 0);
            TempPurgeMenu.Name = "TempPurgeMenu";
            TempPurgeMenu.Size = new Size(562, 33);
            TempPurgeMenu.TabIndex = 0;
            TempPurgeMenu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, documentationToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(237, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new Size(237, 34);
            documentationToolStripMenuItem.Text = "Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // PurgeFilesButton
            // 
            PurgeFilesButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PurgeFilesButton.Location = new Point(89, 153);
            PurgeFilesButton.Name = "PurgeFilesButton";
            PurgeFilesButton.Size = new Size(381, 60);
            PurgeFilesButton.TabIndex = 1;
            PurgeFilesButton.Text = "Purge Temporary Files";
            PurgeFilesButton.UseVisualStyleBackColor = true;
            PurgeFilesButton.Click += PurgeFilesButton_Click;
            // 
            // DownloadsCheckbox
            // 
            DownloadsCheckbox.AutoSize = true;
            DownloadsCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DownloadsCheckbox.Location = new Point(106, 244);
            DownloadsCheckbox.Name = "DownloadsCheckbox";
            DownloadsCheckbox.Size = new Size(350, 34);
            DownloadsCheckbox.TabIndex = 2;
            DownloadsCheckbox.Text = "Include files in Downloads";
            DownloadsCheckbox.UseVisualStyleBackColor = true;
            DownloadsCheckbox.CheckedChanged += DownloadsCheckbox_CheckedChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 389);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(538, 34);
            progressBar1.TabIndex = 3;
            // 
            // TempPurgeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(progressBar1);
            Controls.Add(DownloadsCheckbox);
            Controls.Add(PurgeFilesButton);
            Controls.Add(TempPurgeMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = TempPurgeMenu;
            MaximizeBox = false;
            Name = "TempPurgeForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purge Temporary Files";
            Load += TempPurgeForm_Load;
            TempPurgeMenu.ResumeLayout(false);
            TempPurgeMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TempPurgeMenu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private Button PurgeFilesButton;
        private CheckBox DownloadsCheckbox;
        private ProgressBar progressBar1;
    }
}
