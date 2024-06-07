namespace CourseWork.Forms
{
    partial class PlaylistsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            genreToolStripMenuItem = new ToolStripMenuItem();
            movieToolStripMenuItem = new ToolStripMenuItem();
            studioToolStripMenuItem = new ToolStripMenuItem();
            artistToolStripMenuItem = new ToolStripMenuItem();
            playlistToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, genreToolStripMenuItem, movieToolStripMenuItem, studioToolStripMenuItem, artistToolStripMenuItem, playlistToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // genreToolStripMenuItem
            // 
            genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            genreToolStripMenuItem.Size = new Size(62, 24);
            genreToolStripMenuItem.Text = "Genre";
            genreToolStripMenuItem.Click += genreToolStripMenuItem_Click;
            // 
            // movieToolStripMenuItem
            // 
            movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            movieToolStripMenuItem.Size = new Size(64, 24);
            movieToolStripMenuItem.Text = "Movie";
            movieToolStripMenuItem.Click += movieToolStripMenuItem_Click_1;
            // 
            // studioToolStripMenuItem
            // 
            studioToolStripMenuItem.Name = "studioToolStripMenuItem";
            studioToolStripMenuItem.Size = new Size(66, 24);
            studioToolStripMenuItem.Text = "Studio";
            studioToolStripMenuItem.Click += studioToolStripMenuItem_Click_1;
            // 
            // artistToolStripMenuItem
            // 
            artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            artistToolStripMenuItem.Size = new Size(58, 24);
            artistToolStripMenuItem.Text = "Artist";
            artistToolStripMenuItem.Click += artistToolStripMenuItem_Click_1;
            // 
            // playlistToolStripMenuItem
            // 
            playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            playlistToolStripMenuItem.Size = new Size(69, 24);
            playlistToolStripMenuItem.Text = "Playlist";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // PlaylistsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(818, 497);
            Name = "PlaylistsForm";
            Text = "PlaylistsForm";
            Resize += PlaylistsForm_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem genreToolStripMenuItem;
        private ToolStripMenuItem movieToolStripMenuItem;
        private ToolStripMenuItem studioToolStripMenuItem;
        private ToolStripMenuItem artistToolStripMenuItem;
        private ToolStripMenuItem playlistToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}