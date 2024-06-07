namespace CourseWork.Forms
{
    partial class MoviesForm
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
            splitContainer1 = new SplitContainer();
            ScoreToValue = new NumericUpDown();
            label9 = new Label();
            ScoreFromValue = new NumericUpDown();
            label8 = new Label();
            ScoreLabel = new Label();
            PickUpDuration = new NumericUpDown();
            PickUpButton = new Button();
            SearchButton = new Button();
            SearchHistory = new ListBox();
            label6 = new Label();
            SearchMovieTitle = new TextBox();
            ActorBox = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            YearsToValue = new NumericUpDown();
            YearsFromValue = new NumericUpDown();
            label4 = new Label();
            DirectorBox = new ComboBox();
            label1 = new Label();
            DurationToLabel = new Label();
            DurationFromLabel = new Label();
            DurationToValue = new NumericUpDown();
            ClearButton = new Button();
            ApplyButton = new Button();
            StudioBox = new ComboBox();
            ArtistLabel = new Label();
            GenreBox = new ComboBox();
            GenreLabel = new Label();
            DurationFromValue = new NumericUpDown();
            DurationLabel = new Label();
            button1 = new Button();
            AddToPlaylistButton = new Button();
            SaveMovies = new Button();
            EditMovie = new Button();
            DeleteMovie = new Button();
            AddMovieButton = new Button();
            MoviesGrid = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreToValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScoreFromValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PickUpDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearsToValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearsFromValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationToValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationFromValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MoviesGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, genreToolStripMenuItem, movieToolStripMenuItem, studioToolStripMenuItem, artistToolStripMenuItem, playlistToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1282, 28);
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ScoreToValue);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(ScoreFromValue);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(ScoreLabel);
            splitContainer1.Panel1.Controls.Add(PickUpDuration);
            splitContainer1.Panel1.Controls.Add(PickUpButton);
            splitContainer1.Panel1.Controls.Add(SearchButton);
            splitContainer1.Panel1.Controls.Add(SearchHistory);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(SearchMovieTitle);
            splitContainer1.Panel1.Controls.Add(ActorBox);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(YearsToValue);
            splitContainer1.Panel1.Controls.Add(YearsFromValue);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(DirectorBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(DurationToLabel);
            splitContainer1.Panel1.Controls.Add(DurationFromLabel);
            splitContainer1.Panel1.Controls.Add(DurationToValue);
            splitContainer1.Panel1.Controls.Add(ClearButton);
            splitContainer1.Panel1.Controls.Add(ApplyButton);
            splitContainer1.Panel1.Controls.Add(StudioBox);
            splitContainer1.Panel1.Controls.Add(ArtistLabel);
            splitContainer1.Panel1.Controls.Add(GenreBox);
            splitContainer1.Panel1.Controls.Add(GenreLabel);
            splitContainer1.Panel1.Controls.Add(DurationFromValue);
            splitContainer1.Panel1.Controls.Add(DurationLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(AddToPlaylistButton);
            splitContainer1.Panel2.Controls.Add(SaveMovies);
            splitContainer1.Panel2.Controls.Add(EditMovie);
            splitContainer1.Panel2.Controls.Add(DeleteMovie);
            splitContainer1.Panel2.Controls.Add(AddMovieButton);
            splitContainer1.Panel2.Controls.Add(MoviesGrid);
            splitContainer1.Panel2.ForeColor = SystemColors.ControlText;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1282, 621);
            splitContainer1.SplitterDistance = 338;
            splitContainer1.TabIndex = 1;
            // 
            // ScoreToValue
            // 
            ScoreToValue.Anchor = AnchorStyles.Top;
            ScoreToValue.Location = new Point(212, 287);
            ScoreToValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ScoreToValue.Name = "ScoreToValue";
            ScoreToValue.Size = new Size(76, 27);
            ScoreToValue.TabIndex = 10;
            ScoreToValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(212, 266);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 32;
            label9.Text = "To";
            // 
            // ScoreFromValue
            // 
            ScoreFromValue.Anchor = AnchorStyles.Top;
            ScoreFromValue.Location = new Point(212, 233);
            ScoreFromValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ScoreFromValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ScoreFromValue.Name = "ScoreFromValue";
            ScoreFromValue.Size = new Size(76, 27);
            ScoreFromValue.TabIndex = 9;
            ScoreFromValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(212, 209);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 30;
            label8.Text = "From";
            // 
            // ScoreLabel
            // 
            ScoreLabel.Anchor = AnchorStyles.Top;
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(212, 186);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(46, 20);
            ScoreLabel.TabIndex = 29;
            ScoreLabel.Text = "Score";
            // 
            // PickUpDuration
            // 
            PickUpDuration.Anchor = AnchorStyles.Top;
            PickUpDuration.Location = new Point(51, 403);
            PickUpDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PickUpDuration.Name = "PickUpDuration";
            PickUpDuration.Size = new Size(124, 27);
            PickUpDuration.TabIndex = 13;
            // 
            // PickUpButton
            // 
            PickUpButton.Anchor = AnchorStyles.Top;
            PickUpButton.Location = new Point(181, 399);
            PickUpButton.Name = "PickUpButton";
            PickUpButton.Size = new Size(96, 31);
            PickUpButton.TabIndex = 14;
            PickUpButton.Text = "Pick up";
            PickUpButton.UseVisualStyleBackColor = true;
            PickUpButton.Click += PickUpButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top;
            SearchButton.Location = new Point(215, 464);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(73, 31);
            SearchButton.TabIndex = 16;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchHistory
            // 
            SearchHistory.Anchor = AnchorStyles.Top;
            SearchHistory.FormattingEnabled = true;
            SearchHistory.Location = new Point(52, 510);
            SearchHistory.Name = "SearchHistory";
            SearchHistory.Size = new Size(227, 84);
            SearchHistory.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(50, 443);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 26;
            label6.Text = "Search movie";
            // 
            // SearchMovieTitle
            // 
            SearchMovieTitle.Anchor = AnchorStyles.Top;
            SearchMovieTitle.Location = new Point(50, 466);
            SearchMovieTitle.Name = "SearchMovieTitle";
            SearchMovieTitle.Size = new Size(156, 27);
            SearchMovieTitle.TabIndex = 15;
            // 
            // ActorBox
            // 
            ActorBox.Anchor = AnchorStyles.Top;
            ActorBox.FormattingEnabled = true;
            ActorBox.Location = new Point(52, 263);
            ActorBox.Name = "ActorBox";
            ActorBox.Size = new Size(124, 28);
            ActorBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(51, 240);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 23;
            label5.Text = "Actor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(181, 99);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 22;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 21;
            label3.Text = "From";
            // 
            // YearsToValue
            // 
            YearsToValue.Anchor = AnchorStyles.Top;
            YearsToValue.Location = new Point(212, 99);
            YearsToValue.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            YearsToValue.Name = "YearsToValue";
            YearsToValue.Size = new Size(76, 27);
            YearsToValue.TabIndex = 4;
            // 
            // YearsFromValue
            // 
            YearsFromValue.Anchor = AnchorStyles.Top;
            YearsFromValue.Location = new Point(99, 99);
            YearsFromValue.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            YearsFromValue.Minimum = new decimal(new int[] { 1895, 0, 0, 0 });
            YearsFromValue.Name = "YearsFromValue";
            YearsFromValue.Size = new Size(76, 27);
            YearsFromValue.TabIndex = 3;
            YearsFromValue.Value = new decimal(new int[] { 1895, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(50, 76);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 18;
            label4.Text = "Years";
            // 
            // DirectorBox
            // 
            DirectorBox.Anchor = AnchorStyles.Top;
            DirectorBox.FormattingEnabled = true;
            DirectorBox.Location = new Point(51, 317);
            DirectorBox.Name = "DirectorBox";
            DirectorBox.Size = new Size(124, 28);
            DirectorBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(50, 294);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 16;
            label1.Text = "Director";
            // 
            // DurationToLabel
            // 
            DurationToLabel.Anchor = AnchorStyles.Top;
            DurationToLabel.AutoSize = true;
            DurationToLabel.Location = new Point(181, 38);
            DurationToLabel.Name = "DurationToLabel";
            DurationToLabel.Size = new Size(25, 20);
            DurationToLabel.TabIndex = 15;
            DurationToLabel.Text = "To";
            // 
            // DurationFromLabel
            // 
            DurationFromLabel.Anchor = AnchorStyles.Top;
            DurationFromLabel.AutoSize = true;
            DurationFromLabel.Location = new Point(50, 38);
            DurationFromLabel.Name = "DurationFromLabel";
            DurationFromLabel.Size = new Size(43, 20);
            DurationFromLabel.TabIndex = 14;
            DurationFromLabel.Text = "From";
            // 
            // DurationToValue
            // 
            DurationToValue.Anchor = AnchorStyles.Top;
            DurationToValue.Location = new Point(212, 38);
            DurationToValue.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            DurationToValue.Name = "DurationToValue";
            DurationToValue.Size = new Size(76, 27);
            DurationToValue.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top;
            ClearButton.Location = new Point(181, 362);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(96, 31);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Top;
            ApplyButton.Location = new Point(50, 362);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(96, 31);
            ApplyButton.TabIndex = 11;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // StudioBox
            // 
            StudioBox.Anchor = AnchorStyles.Top;
            StudioBox.FormattingEnabled = true;
            StudioBox.Location = new Point(51, 209);
            StudioBox.Name = "StudioBox";
            StudioBox.Size = new Size(124, 28);
            StudioBox.TabIndex = 6;
            // 
            // ArtistLabel
            // 
            ArtistLabel.Anchor = AnchorStyles.Top;
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(50, 186);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(52, 20);
            ArtistLabel.TabIndex = 8;
            ArtistLabel.Text = "Studio";
            // 
            // GenreBox
            // 
            GenreBox.Anchor = AnchorStyles.Top;
            GenreBox.FormattingEnabled = true;
            GenreBox.Location = new Point(51, 155);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(124, 28);
            GenreBox.TabIndex = 5;
            // 
            // GenreLabel
            // 
            GenreLabel.Anchor = AnchorStyles.Top;
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(50, 132);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(48, 20);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre";
            // 
            // DurationFromValue
            // 
            DurationFromValue.Anchor = AnchorStyles.Top;
            DurationFromValue.Location = new Point(99, 38);
            DurationFromValue.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            DurationFromValue.Name = "DurationFromValue";
            DurationFromValue.Size = new Size(76, 27);
            DurationFromValue.TabIndex = 1;
            // 
            // DurationLabel
            // 
            DurationLabel.Anchor = AnchorStyles.Top;
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(50, 15);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(99, 20);
            DurationLabel.TabIndex = 0;
            DurationLabel.Text = "Duration, min";
            // 
            // button1
            // 
            button1.Location = new Point(841, 546);
            button1.Name = "button1";
            button1.Size = new Size(87, 48);
            button1.TabIndex = 24;
            button1.Text = "Statistics";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddToPlaylistButton
            // 
            AddToPlaylistButton.Location = new Point(717, 546);
            AddToPlaylistButton.Name = "AddToPlaylistButton";
            AddToPlaylistButton.Size = new Size(118, 48);
            AddToPlaylistButton.TabIndex = 23;
            AddToPlaylistButton.Text = "Add movie to playlist";
            AddToPlaylistButton.UseVisualStyleBackColor = true;
            AddToPlaylistButton.Click += AddToPlaylistButton_Click;
            // 
            // SaveMovies
            // 
            SaveMovies.Location = new Point(559, 546);
            SaveMovies.Name = "SaveMovies";
            SaveMovies.Size = new Size(152, 48);
            SaveMovies.TabIndex = 22;
            SaveMovies.Text = "Save list";
            SaveMovies.UseVisualStyleBackColor = true;
            SaveMovies.Click += SaveMovies_Click;
            // 
            // EditMovie
            // 
            EditMovie.Location = new Point(360, 546);
            EditMovie.Name = "EditMovie";
            EditMovie.Size = new Size(193, 48);
            EditMovie.TabIndex = 21;
            EditMovie.Text = "Edit Selected Movie";
            EditMovie.UseVisualStyleBackColor = true;
            EditMovie.Click += EditMovie_Click;
            // 
            // DeleteMovie
            // 
            DeleteMovie.Location = new Point(161, 546);
            DeleteMovie.Name = "DeleteMovie";
            DeleteMovie.Size = new Size(193, 48);
            DeleteMovie.TabIndex = 20;
            DeleteMovie.Text = "Delete Selected Movie";
            DeleteMovie.UseVisualStyleBackColor = true;
            DeleteMovie.Click += DeleteMovie_Click;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Location = new Point(3, 546);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(152, 48);
            AddMovieButton.TabIndex = 19;
            AddMovieButton.Text = "Add Movie";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // MoviesGrid
            // 
            MoviesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MoviesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MoviesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MoviesGrid.Location = new Point(3, 3);
            MoviesGrid.Name = "MoviesGrid";
            MoviesGrid.RowHeadersWidth = 51;
            MoviesGrid.Size = new Size(913, 515);
            MoviesGrid.TabIndex = 18;
            // 
            // MoviesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 649);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1300, 696);
            Name = "MoviesForm";
            Text = "Movies";
            Load += MoviesForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScoreToValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScoreFromValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)PickUpDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearsToValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearsFromValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationToValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationFromValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)MoviesGrid).EndInit();
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
        private SplitContainer splitContainer1;
        private DataGridView MoviesGrid;
        private Label DurationLabel;
        private NumericUpDown DurationFromValue;
        private Label GenreLabel;
        private Label ArtistLabel;
        private ComboBox GenreBox;
        private Button ClearButton;
        private Button ApplyButton;
        private ComboBox StudioBox;
        private Button AddMovieButton;
        private Label DurationToLabel;
        private Label DurationFromLabel;
        private NumericUpDown DurationToValue;
        private Button EditMovie;
        private Button DeleteMovie;
        private ToolStripMenuItem studioToolStripMenuItem;
        private ComboBox DirectorBox;
        private Label label1;
        private ComboBox ActorBox;
        private Label label5;
        private Label label2;
        private Label label3;
        private NumericUpDown YearsToValue;
        private NumericUpDown YearsFromValue;
        private Label label4;
        private Label label6;
        private TextBox SearchMovieTitle;
        private ListBox SearchHistory;
        private Button SearchButton;
        private Button SaveMovies;
        private Button PickUpButton;
        private NumericUpDown PickUpDuration;
        private Label label8;
        private Label ScoreLabel;
        private NumericUpDown ScoreToValue;
        private Label label9;
        private NumericUpDown ScoreFromValue;
        private Button AddToPlaylistButton;
        private ToolStripMenuItem playlistToolStripMenuItem;
        private Button button1;
    }
}