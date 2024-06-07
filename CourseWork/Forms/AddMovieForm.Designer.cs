namespace CourseWork.Forms
{
    partial class AddMovieForm
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
            NewMovieStudio = new ComboBox();
            ArtistLabel = new Label();
            NewMovieGenre = new ComboBox();
            GenreLabel = new Label();
            label1 = new Label();
            NewMovieTitle = new TextBox();
            label2 = new Label();
            NewMovieYear = new NumericUpDown();
            NewMovieDuration = new NumericUpDown();
            label3 = new Label();
            AddMovieButton = new Button();
            NewMovieScore = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            NewMovieDescription = new TextBox();
            AddGenreButton = new Button();
            NewStudioButton = new Button();
            panel1 = new Panel();
            DeleteArtistButton = new Button();
            ArtistsGrid = new DataGridView();
            AddToDataGrid = new Button();
            RoleLabel = new Label();
            RoleName = new ComboBox();
            AddActorButton = new Button();
            ArtistNameLabel = new Label();
            ArtistName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NewMovieYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMovieDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMovieScore).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ArtistsGrid).BeginInit();
            SuspendLayout();
            // 
            // NewMovieStudio
            // 
            NewMovieStudio.DropDownStyle = ComboBoxStyle.DropDownList;
            NewMovieStudio.FormattingEnabled = true;
            NewMovieStudio.Location = new Point(266, 49);
            NewMovieStudio.Name = "NewMovieStudio";
            NewMovieStudio.Size = new Size(124, 28);
            NewMovieStudio.TabIndex = 5;
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(276, 25);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(52, 20);
            ArtistLabel.TabIndex = 11;
            ArtistLabel.Text = "Studio";
            // 
            // NewMovieGenre
            // 
            NewMovieGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            NewMovieGenre.FormattingEnabled = true;
            NewMovieGenre.Location = new Point(31, 154);
            NewMovieGenre.Name = "NewMovieGenre";
            NewMovieGenre.Size = new Size(124, 28);
            NewMovieGenre.TabIndex = 3;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(41, 131);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(48, 20);
            GenreLabel.TabIndex = 12;
            GenreLabel.Text = "Genre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 15;
            label1.Text = "Title";
            // 
            // NewMovieTitle
            // 
            NewMovieTitle.Location = new Point(31, 49);
            NewMovieTitle.Name = "NewMovieTitle";
            NewMovieTitle.Size = new Size(124, 27);
            NewMovieTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 17;
            label2.Text = "Year";
            // 
            // NewMovieYear
            // 
            NewMovieYear.Location = new Point(31, 101);
            NewMovieYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            NewMovieYear.Minimum = new decimal(new int[] { 1895, 0, 0, 0 });
            NewMovieYear.Name = "NewMovieYear";
            NewMovieYear.Size = new Size(124, 27);
            NewMovieYear.TabIndex = 2;
            NewMovieYear.Value = new decimal(new int[] { 1895, 0, 0, 0 });
            // 
            // NewMovieDuration
            // 
            NewMovieDuration.Location = new Point(266, 102);
            NewMovieDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NewMovieDuration.Name = "NewMovieDuration";
            NewMovieDuration.Size = new Size(124, 27);
            NewMovieDuration.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 79);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 19;
            label3.Text = "Duration";
            // 
            // AddMovieButton
            // 
            AddMovieButton.Anchor = AnchorStyles.Bottom;
            AddMovieButton.Location = new Point(329, 464);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(151, 43);
            AddMovieButton.TabIndex = 16;
            AddMovieButton.Text = "Save";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // NewMovieScore
            // 
            NewMovieScore.Location = new Point(266, 157);
            NewMovieScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NewMovieScore.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewMovieScore.Name = "NewMovieScore";
            NewMovieScore.Size = new Size(124, 27);
            NewMovieScore.TabIndex = 8;
            NewMovieScore.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 132);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 22;
            label4.Text = "Score";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(566, 25);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 24;
            label5.Text = "Description";
            // 
            // NewMovieDescription
            // 
            NewMovieDescription.Anchor = AnchorStyles.Top;
            NewMovieDescription.Location = new Point(449, 50);
            NewMovieDescription.Multiline = true;
            NewMovieDescription.Name = "NewMovieDescription";
            NewMovieDescription.Size = new Size(342, 134);
            NewMovieDescription.TabIndex = 9;
            // 
            // AddGenreButton
            // 
            AddGenreButton.Location = new Point(161, 154);
            AddGenreButton.Name = "AddGenreButton";
            AddGenreButton.Size = new Size(29, 28);
            AddGenreButton.TabIndex = 4;
            AddGenreButton.Text = "+";
            AddGenreButton.UseVisualStyleBackColor = true;
            AddGenreButton.Click += AddGenreButton_Click;
            // 
            // NewStudioButton
            // 
            NewStudioButton.Location = new Point(396, 48);
            NewStudioButton.Name = "NewStudioButton";
            NewStudioButton.Size = new Size(29, 28);
            NewStudioButton.TabIndex = 6;
            NewStudioButton.Text = "+";
            NewStudioButton.UseVisualStyleBackColor = true;
            NewStudioButton.Click += NewStudioButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DeleteArtistButton);
            panel1.Controls.Add(ArtistsGrid);
            panel1.Controls.Add(AddToDataGrid);
            panel1.Controls.Add(RoleLabel);
            panel1.Controls.Add(RoleName);
            panel1.Controls.Add(AddActorButton);
            panel1.Controls.Add(ArtistNameLabel);
            panel1.Controls.Add(ArtistName);
            panel1.Location = new Point(31, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 239);
            panel1.TabIndex = 28;
            // 
            // DeleteArtistButton
            // 
            DeleteArtistButton.Location = new Point(613, 12);
            DeleteArtistButton.Name = "DeleteArtistButton";
            DeleteArtistButton.Size = new Size(133, 51);
            DeleteArtistButton.TabIndex = 14;
            DeleteArtistButton.Text = "Delete selected";
            DeleteArtistButton.UseVisualStyleBackColor = true;
            DeleteArtistButton.Click += DeleteArtistButton_Click;
            // 
            // ArtistsGrid
            // 
            ArtistsGrid.Anchor = AnchorStyles.Bottom;
            ArtistsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArtistsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArtistsGrid.Location = new Point(9, 86);
            ArtistsGrid.Name = "ArtistsGrid";
            ArtistsGrid.RightToLeft = RightToLeft.No;
            ArtistsGrid.RowHeadersWidth = 51;
            ArtistsGrid.Size = new Size(734, 121);
            ArtistsGrid.TabIndex = 15;
            // 
            // AddToDataGrid
            // 
            AddToDataGrid.Location = new Point(474, 12);
            AddToDataGrid.Name = "AddToDataGrid";
            AddToDataGrid.Size = new Size(133, 51);
            AddToDataGrid.TabIndex = 13;
            AddToDataGrid.Text = "Save";
            AddToDataGrid.UseVisualStyleBackColor = true;
            AddToDataGrid.Click += AddToDataGrid_Click;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(305, 13);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(39, 20);
            RoleLabel.TabIndex = 29;
            RoleLabel.Text = "Role";
            // 
            // RoleName
            // 
            RoleName.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleName.FormattingEnabled = true;
            RoleName.Location = new Point(279, 36);
            RoleName.Name = "RoleName";
            RoleName.Size = new Size(189, 28);
            RoleName.TabIndex = 12;
            // 
            // AddActorButton
            // 
            AddActorButton.Location = new Point(204, 35);
            AddActorButton.Name = "AddActorButton";
            AddActorButton.Size = new Size(29, 28);
            AddActorButton.TabIndex = 11;
            AddActorButton.Text = "+";
            AddActorButton.UseVisualStyleBackColor = true;
            AddActorButton.Click += button1_Click;
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.AutoSize = true;
            ArtistNameLabel.Location = new Point(35, 13);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(88, 20);
            ArtistNameLabel.TabIndex = 1;
            ArtistNameLabel.Text = "Artist Name";
            // 
            // ArtistName
            // 
            ArtistName.DropDownStyle = ComboBoxStyle.DropDownList;
            ArtistName.FormattingEnabled = true;
            ArtistName.Location = new Point(9, 36);
            ArtistName.Name = "ArtistName";
            ArtistName.Size = new Size(189, 28);
            ArtistName.TabIndex = 10;
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 514);
            Controls.Add(panel1);
            Controls.Add(NewStudioButton);
            Controls.Add(AddGenreButton);
            Controls.Add(NewMovieDescription);
            Controls.Add(label5);
            Controls.Add(NewMovieScore);
            Controls.Add(label4);
            Controls.Add(AddMovieButton);
            Controls.Add(NewMovieDuration);
            Controls.Add(label3);
            Controls.Add(NewMovieYear);
            Controls.Add(label2);
            Controls.Add(NewMovieTitle);
            Controls.Add(label1);
            Controls.Add(NewMovieStudio);
            Controls.Add(ArtistLabel);
            Controls.Add(NewMovieGenre);
            Controls.Add(GenreLabel);
            MinimumSize = new Size(839, 561);
            Name = "AddMovieForm";
            Text = "New Movie";
            Load += AddMovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)NewMovieYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMovieDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMovieScore).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ArtistsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox NewMovieStudio;
        private Label ArtistLabel;
        private ComboBox NewMovieGenre;
        private Label GenreLabel;
        private Label label1;
        private TextBox NewMovieTitle;
        private Label label2;
        private NumericUpDown NewMovieYear;
        private NumericUpDown NewMovieDuration;
        private Label label3;
        private Button AddMovieButton;
        private NumericUpDown NewMovieScore;
        private Label label4;
        private Label label5;
        private TextBox NewMovieDescription;
        private Button AddGenreButton;
        private Button NewStudioButton;
        private Panel panel1;
        private Label ArtistNameLabel;
        private ComboBox ArtistName;
        private DataGridView ArtistsGrid;
        private Button AddToDataGrid;
        private Label RoleLabel;
        private ComboBox RoleName;
        private Button AddActorButton;
        private Button DeleteArtistButton;
    }
}