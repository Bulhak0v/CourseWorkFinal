namespace CourseWork.Forms
{
    partial class AddToPlaylistForm
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
            MovieLabel = new Label();
            PlaylistLabel = new Label();
            MoviesBox = new ComboBox();
            PlaylistBox = new ComboBox();
            AddPlaylistButton = new Button();
            AddMovieToPlaylistButton = new Button();
            SuspendLayout();
            // 
            // MovieLabel
            // 
            MovieLabel.Anchor = AnchorStyles.Top;
            MovieLabel.AutoSize = true;
            MovieLabel.Location = new Point(270, 29);
            MovieLabel.Name = "MovieLabel";
            MovieLabel.Size = new Size(50, 20);
            MovieLabel.TabIndex = 0;
            MovieLabel.Text = "Movie";
            // 
            // PlaylistLabel
            // 
            PlaylistLabel.AutoSize = true;
            PlaylistLabel.Location = new Point(270, 114);
            PlaylistLabel.Name = "PlaylistLabel";
            PlaylistLabel.Size = new Size(55, 20);
            PlaylistLabel.TabIndex = 1;
            PlaylistLabel.Text = "Playlist";
            // 
            // MoviesBox
            // 
            MoviesBox.Anchor = AnchorStyles.Top;
            MoviesBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MoviesBox.FormattingEnabled = true;
            MoviesBox.Location = new Point(189, 68);
            MoviesBox.Name = "MoviesBox";
            MoviesBox.Size = new Size(235, 28);
            MoviesBox.TabIndex = 2;
            // 
            // PlaylistBox
            // 
            PlaylistBox.Anchor = AnchorStyles.Top;
            PlaylistBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlaylistBox.FormattingEnabled = true;
            PlaylistBox.Location = new Point(189, 149);
            PlaylistBox.Name = "PlaylistBox";
            PlaylistBox.Size = new Size(235, 28);
            PlaylistBox.TabIndex = 3;
            // 
            // AddPlaylistButton
            // 
            AddPlaylistButton.Location = new Point(430, 149);
            AddPlaylistButton.Name = "AddPlaylistButton";
            AddPlaylistButton.Size = new Size(29, 28);
            AddPlaylistButton.TabIndex = 12;
            AddPlaylistButton.Text = "+";
            AddPlaylistButton.UseVisualStyleBackColor = true;
            AddPlaylistButton.Click += AddPlaylistButton_Click;
            // 
            // AddMovieToPlaylistButton
            // 
            AddMovieToPlaylistButton.Location = new Point(238, 216);
            AddMovieToPlaylistButton.Name = "AddMovieToPlaylistButton";
            AddMovieToPlaylistButton.Size = new Size(119, 40);
            AddMovieToPlaylistButton.TabIndex = 13;
            AddMovieToPlaylistButton.Text = "Save";
            AddMovieToPlaylistButton.UseVisualStyleBackColor = true;
            AddMovieToPlaylistButton.Click += AddMovieToPlaylistButton_Click;
            // 
            // AddToPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(AddMovieToPlaylistButton);
            Controls.Add(AddPlaylistButton);
            Controls.Add(PlaylistBox);
            Controls.Add(MoviesBox);
            Controls.Add(PlaylistLabel);
            Controls.Add(MovieLabel);
            Name = "AddToPlaylistForm";
            Text = "AddToPlaylistForm";
            Load += AddToPlaylistForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MovieLabel;
        private Label PlaylistLabel;
        private ComboBox MoviesBox;
        private ComboBox PlaylistBox;
        private Button AddPlaylistButton;
        private Button AddMovieToPlaylistButton;
    }
}