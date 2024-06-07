namespace CourseWork.Forms
{
    partial class PlaylistInfoForm
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
            DeletePlaylistButton = new Button();
            EditPlaylistButton = new Button();
            PlaylistGrid = new DataGridView();
            PlaylistDescription = new TextBox();
            label5 = new Label();
            PlaylistTitle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PlaylistGrid).BeginInit();
            SuspendLayout();
            // 
            // DeletePlaylistButton
            // 
            DeletePlaylistButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeletePlaylistButton.Location = new Point(488, 354);
            DeletePlaylistButton.Name = "DeletePlaylistButton";
            DeletePlaylistButton.Size = new Size(226, 48);
            DeletePlaylistButton.TabIndex = 37;
            DeletePlaylistButton.Text = "Delete";
            DeletePlaylistButton.UseVisualStyleBackColor = true;
            DeletePlaylistButton.Click += DeletePlaylistButton_Click;
            // 
            // EditPlaylistButton
            // 
            EditPlaylistButton.Location = new Point(237, 354);
            EditPlaylistButton.Name = "EditPlaylistButton";
            EditPlaylistButton.Size = new Size(226, 48);
            EditPlaylistButton.TabIndex = 36;
            EditPlaylistButton.Text = "Edit";
            EditPlaylistButton.UseVisualStyleBackColor = true;
            EditPlaylistButton.Click += EditPlaylistButton_Click;
            // 
            // PlaylistGrid
            // 
            PlaylistGrid.Anchor = AnchorStyles.Top;
            PlaylistGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlaylistGrid.Location = new Point(312, 22);
            PlaylistGrid.Name = "PlaylistGrid";
            PlaylistGrid.RowHeadersWidth = 51;
            PlaylistGrid.Size = new Size(598, 304);
            PlaylistGrid.TabIndex = 35;
            // 
            // PlaylistDescription
            // 
            PlaylistDescription.Anchor = AnchorStyles.Top;
            PlaylistDescription.Location = new Point(12, 98);
            PlaylistDescription.Multiline = true;
            PlaylistDescription.Name = "PlaylistDescription";
            PlaylistDescription.ReadOnly = true;
            PlaylistDescription.Size = new Size(294, 228);
            PlaylistDescription.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(12, 75);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 39;
            label5.Text = "Description";
            // 
            // PlaylistTitle
            // 
            PlaylistTitle.Anchor = AnchorStyles.Top;
            PlaylistTitle.Location = new Point(12, 45);
            PlaylistTitle.Name = "PlaylistTitle";
            PlaylistTitle.ReadOnly = true;
            PlaylistTitle.Size = new Size(124, 27);
            PlaylistTitle.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 38;
            label1.Text = "Title";
            // 
            // PlaylistInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 425);
            Controls.Add(DeletePlaylistButton);
            Controls.Add(EditPlaylistButton);
            Controls.Add(PlaylistGrid);
            Controls.Add(PlaylistDescription);
            Controls.Add(label5);
            Controls.Add(PlaylistTitle);
            Controls.Add(label1);
            Name = "PlaylistInfoForm";
            Text = "PlaylistInfoForm";
            ((System.ComponentModel.ISupportInitialize)PlaylistGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeletePlaylistButton;
        private Button EditPlaylistButton;
        private DataGridView PlaylistGrid;
        private TextBox PlaylistDescription;
        private Label label5;
        private TextBox PlaylistTitle;
        private Label label1;
    }
}