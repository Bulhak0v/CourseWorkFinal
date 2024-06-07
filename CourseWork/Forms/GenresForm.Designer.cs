namespace CourseWork.Forms
{
    partial class GenresForm
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            playlistToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, genreToolStripMenuItem, movieToolStripMenuItem, studioToolStripMenuItem, artistToolStripMenuItem, playlistToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
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
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // genreToolStripMenuItem
            // 
            genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            genreToolStripMenuItem.Size = new Size(62, 24);
            genreToolStripMenuItem.Text = "Genre";
            // 
            // movieToolStripMenuItem
            // 
            movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            movieToolStripMenuItem.Size = new Size(64, 24);
            movieToolStripMenuItem.Text = "Movie";
            movieToolStripMenuItem.Click += movieToolStripMenuItem_Click;
            // 
            // studioToolStripMenuItem
            // 
            studioToolStripMenuItem.Name = "studioToolStripMenuItem";
            studioToolStripMenuItem.Size = new Size(66, 24);
            studioToolStripMenuItem.Text = "Studio";
            studioToolStripMenuItem.Click += studioToolStripMenuItem_Click;
            // 
            // artistToolStripMenuItem
            // 
            artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            artistToolStripMenuItem.Size = new Size(58, 24);
            artistToolStripMenuItem.Text = "Artist";
            artistToolStripMenuItem.Click += artistToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(142, 26);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // playlistToolStripMenuItem
            // 
            playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            playlistToolStripMenuItem.Size = new Size(69, 24);
            playlistToolStripMenuItem.Text = "Playlist";
            playlistToolStripMenuItem.Click += playlistToolStripMenuItem_Click;
            // 
            // GenresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(820, 497);
            Name = "GenresForm";
            Text = "GenresForm";
            Load += GenresForm_Load;
            Resize += GenresForm_Resize;
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
        private ToolStripMenuItem artistToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem studioToolStripMenuItem;
        private ToolStripMenuItem playlistToolStripMenuItem;
    }
}