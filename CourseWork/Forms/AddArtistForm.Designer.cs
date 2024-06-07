namespace CourseWork.Forms
{
    partial class AddArtistForm
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
            AddArtistButton = new Button();
            NewArtistBiography = new TextBox();
            label5 = new Label();
            NewArtistTitle = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddArtistButton
            // 
            AddArtistButton.Anchor = AnchorStyles.Top;
            AddArtistButton.Location = new Point(307, 342);
            AddArtistButton.Name = "AddArtistButton";
            AddArtistButton.Size = new Size(192, 52);
            AddArtistButton.TabIndex = 3;
            AddArtistButton.Text = "Add Artist";
            AddArtistButton.UseVisualStyleBackColor = true;
            AddArtistButton.Click += AddArtistButton_Click;
            // 
            // NewArtistBiography
            // 
            NewArtistBiography.Anchor = AnchorStyles.Top;
            NewArtistBiography.Location = new Point(253, 160);
            NewArtistBiography.Multiline = true;
            NewArtistBiography.Name = "NewArtistBiography";
            NewArtistBiography.Size = new Size(294, 134);
            NewArtistBiography.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(349, 137);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 33;
            label5.Text = "Biography";
            // 
            // NewArtistTitle
            // 
            NewArtistTitle.Anchor = AnchorStyles.Top;
            NewArtistTitle.Location = new Point(329, 79);
            NewArtistTitle.Name = "NewArtistTitle";
            NewArtistTitle.Size = new Size(124, 27);
            NewArtistTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(368, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 31;
            label1.Text = "Name";
            // 
            // AddArtistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddArtistButton);
            Controls.Add(NewArtistBiography);
            Controls.Add(label5);
            Controls.Add(NewArtistTitle);
            Controls.Add(label1);
            Name = "AddArtistForm";
            Text = "AddArtistForm";
            Load += AddArtistForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddArtistButton;
        private TextBox NewArtistBiography;
        private Label label5;
        private TextBox NewArtistTitle;
        private Label label1;
    }
}