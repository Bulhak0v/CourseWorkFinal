namespace CourseWork.Forms
{
    partial class ArtistInfoForm
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
            DeleteArtistButton = new Button();
            EditArtistButton = new Button();
            ArtistGrid = new DataGridView();
            ArtistBiography = new TextBox();
            label5 = new Label();
            ArtistTitle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ArtistGrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteArtistButton
            // 
            DeleteArtistButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteArtistButton.Location = new Point(488, 354);
            DeleteArtistButton.Name = "DeleteArtistButton";
            DeleteArtistButton.Size = new Size(226, 48);
            DeleteArtistButton.TabIndex = 5;
            DeleteArtistButton.Text = "Delete";
            DeleteArtistButton.UseVisualStyleBackColor = true;
            DeleteArtistButton.Click += DeleteArtistButton_Click;
            // 
            // EditArtistButton
            // 
            EditArtistButton.Location = new Point(237, 354);
            EditArtistButton.Name = "EditArtistButton";
            EditArtistButton.Size = new Size(226, 48);
            EditArtistButton.TabIndex = 4;
            EditArtistButton.Text = "Edit";
            EditArtistButton.UseVisualStyleBackColor = true;
            EditArtistButton.Click += EditArtistButton_Click;
            // 
            // ArtistGrid
            // 
            ArtistGrid.Anchor = AnchorStyles.Top;
            ArtistGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArtistGrid.Location = new Point(312, 22);
            ArtistGrid.Name = "ArtistGrid";
            ArtistGrid.RowHeadersWidth = 51;
            ArtistGrid.Size = new Size(598, 304);
            ArtistGrid.TabIndex = 3;
            // 
            // ArtistBiography
            // 
            ArtistBiography.Anchor = AnchorStyles.Top;
            ArtistBiography.Location = new Point(12, 98);
            ArtistBiography.Multiline = true;
            ArtistBiography.Name = "ArtistBiography";
            ArtistBiography.ReadOnly = true;
            ArtistBiography.Size = new Size(294, 228);
            ArtistBiography.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(12, 75);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 39;
            label5.Text = "Biography";
            // 
            // ArtistTitle
            // 
            ArtistTitle.Anchor = AnchorStyles.Top;
            ArtistTitle.Location = new Point(12, 45);
            ArtistTitle.Name = "ArtistTitle";
            ArtistTitle.ReadOnly = true;
            ArtistTitle.Size = new Size(124, 27);
            ArtistTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 37;
            label1.Text = "Name";
            // 
            // ArtistInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 425);
            Controls.Add(DeleteArtistButton);
            Controls.Add(EditArtistButton);
            Controls.Add(ArtistGrid);
            Controls.Add(ArtistBiography);
            Controls.Add(label5);
            Controls.Add(ArtistTitle);
            Controls.Add(label1);
            MinimumSize = new Size(940, 472);
            Name = "ArtistInfoForm";
            Text = "ArtistInfoForm";
            Load += ArtistInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)ArtistGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteArtistButton;
        private Button EditArtistButton;
        private DataGridView ArtistGrid;
        private TextBox ArtistBiography;
        private Label label5;
        private TextBox ArtistTitle;
        private Label label1;
    }
}