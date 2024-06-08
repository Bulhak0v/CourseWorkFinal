namespace CourseWork.Forms
{
    partial class MainForm
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
            MoviesButton = new Button();
            ArtistsButton = new Button();
            GenresButton = new Button();
            StudiosButton = new Button();
            label1 = new Label();
            PlaylistsButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, genreToolStripMenuItem, movieToolStripMenuItem, studioToolStripMenuItem, artistToolStripMenuItem, playlistToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(677, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            genreToolStripMenuItem.Click += genreToolStripMenuItem_Click;
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
            // playlistToolStripMenuItem
            // 
            playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            playlistToolStripMenuItem.Size = new Size(69, 24);
            playlistToolStripMenuItem.Text = "Playlist";
            playlistToolStripMenuItem.Click += playlistToolStripMenuItem_Click;
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
            // MoviesButton
            // 
            MoviesButton.Anchor = AnchorStyles.Top;
            MoviesButton.Location = new Point(91, 172);
            MoviesButton.Name = "MoviesButton";
            MoviesButton.Size = new Size(155, 57);
            MoviesButton.TabIndex = 2;
            MoviesButton.Text = "Movies";
            MoviesButton.UseVisualStyleBackColor = true;
            MoviesButton.Click += MoviesButton_Click;
            // 
            // ArtistsButton
            // 
            ArtistsButton.Anchor = AnchorStyles.Top;
            ArtistsButton.Location = new Point(414, 172);
            ArtistsButton.Name = "ArtistsButton";
            ArtistsButton.Size = new Size(155, 57);
            ArtistsButton.TabIndex = 3;
            ArtistsButton.Text = "Artists";
            ArtistsButton.UseVisualStyleBackColor = true;
            ArtistsButton.Click += ArtistsButton_Click;
            // 
            // GenresButton
            // 
            GenresButton.Anchor = AnchorStyles.Top;
            GenresButton.Location = new Point(91, 314);
            GenresButton.Name = "GenresButton";
            GenresButton.Size = new Size(155, 57);
            GenresButton.TabIndex = 4;
            GenresButton.Text = "Genres";
            GenresButton.UseVisualStyleBackColor = true;
            GenresButton.Click += GenresButton_Click;
            // 
            // StudiosButton
            // 
            StudiosButton.Anchor = AnchorStyles.Top;
            StudiosButton.Location = new Point(414, 314);
            StudiosButton.Name = "StudiosButton";
            StudiosButton.Size = new Size(155, 57);
            StudiosButton.TabIndex = 5;
            StudiosButton.Text = "Studios";
            StudiosButton.UseVisualStyleBackColor = true;
            StudiosButton.Click += StudiosButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(120, 105);
            label1.Name = "label1";
            label1.Size = new Size(437, 22);
            label1.TabIndex = 1;
            label1.Text = "Greetings! Choose the menu from the navbar or here to continue";
            // 
            // PlaylistsButton
            // 
            PlaylistsButton.Anchor = AnchorStyles.Top;
            PlaylistsButton.Location = new Point(255, 414);
            PlaylistsButton.MinimumSize = new Size(155, 57);
            PlaylistsButton.Name = "PlaylistsButton";
            PlaylistsButton.Size = new Size(155, 57);
            PlaylistsButton.TabIndex = 6;
            PlaylistsButton.Text = "Playlists";
            PlaylistsButton.UseVisualStyleBackColor = true;
            PlaylistsButton.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(677, 500);
            Controls.Add(PlaylistsButton);
            Controls.Add(label1);
            Controls.Add(StudiosButton);
            Controls.Add(GenresButton);
            Controls.Add(ArtistsButton);
            Controls.Add(MoviesButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(695, 547);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem genreToolStripMenuItem;
        private ToolStripMenuItem movieToolStripMenuItem;
        private ToolStripMenuItem artistToolStripMenuItem;
        private ToolStripMenuItem studioToolStripMenuItem;
        private Button MoviesButton;
        private Button ArtistsButton;
        private Button GenresButton;
        private Button StudiosButton;
        private Label label1;
        private ToolStripMenuItem playlistToolStripMenuItem;
        private Button PlaylistsButton;
    }
}