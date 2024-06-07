namespace CourseWork.Forms
{
    partial class AddPlaylistForm
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
            AddPlaylistButton = new Button();
            NewPlaylistDescription = new TextBox();
            label5 = new Label();
            NewPlaylistTitle = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddPlaylistButton
            // 
            AddPlaylistButton.Anchor = AnchorStyles.Top;
            AddPlaylistButton.Location = new Point(307, 342);
            AddPlaylistButton.Name = "AddPlaylistButton";
            AddPlaylistButton.Size = new Size(192, 52);
            AddPlaylistButton.TabIndex = 3;
            AddPlaylistButton.Text = "Add Playlist";
            AddPlaylistButton.UseVisualStyleBackColor = true;
            AddPlaylistButton.Click += AddPlaylistButton_Click;
            // 
            // NewPlaylistDescription
            // 
            NewPlaylistDescription.Anchor = AnchorStyles.Top;
            NewPlaylistDescription.Location = new Point(253, 160);
            NewPlaylistDescription.Multiline = true;
            NewPlaylistDescription.Name = "NewPlaylistDescription";
            NewPlaylistDescription.Size = new Size(294, 134);
            NewPlaylistDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(349, 137);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 33;
            label5.Text = "Description";
            // 
            // NewPlaylistTitle
            // 
            NewPlaylistTitle.Anchor = AnchorStyles.Top;
            NewPlaylistTitle.Location = new Point(329, 79);
            NewPlaylistTitle.Name = "NewPlaylistTitle";
            NewPlaylistTitle.Size = new Size(124, 27);
            NewPlaylistTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(368, 56);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 32;
            label1.Text = "Title";
            // 
            // AddPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPlaylistButton);
            Controls.Add(NewPlaylistDescription);
            Controls.Add(label5);
            Controls.Add(NewPlaylistTitle);
            Controls.Add(label1);
            Name = "AddPlaylistForm";
            Text = "AddPlaylistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPlaylistButton;
        private TextBox NewPlaylistDescription;
        private Label label5;
        private TextBox NewPlaylistTitle;
        private Label label1;
    }
}