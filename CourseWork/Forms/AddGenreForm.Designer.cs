namespace CourseWork.Forms
{
    partial class AddGenreForm
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
            NewGenreDescription = new TextBox();
            label5 = new Label();
            NewGenreTitle = new TextBox();
            label1 = new Label();
            AddGenreButton = new Button();
            SuspendLayout();
            // 
            // NewGenreDescription
            // 
            NewGenreDescription.Anchor = AnchorStyles.Top;
            NewGenreDescription.Location = new Point(240, 113);
            NewGenreDescription.Multiline = true;
            NewGenreDescription.Name = "NewGenreDescription";
            NewGenreDescription.Size = new Size(294, 134);
            NewGenreDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(336, 90);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 28;
            label5.Text = "Description";
            // 
            // NewGenreTitle
            // 
            NewGenreTitle.Anchor = AnchorStyles.Top;
            NewGenreTitle.Location = new Point(316, 32);
            NewGenreTitle.Name = "NewGenreTitle";
            NewGenreTitle.Size = new Size(124, 27);
            NewGenreTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 26;
            label1.Text = "Title";
            // 
            // AddGenreButton
            // 
            AddGenreButton.Anchor = AnchorStyles.Top;
            AddGenreButton.Location = new Point(294, 295);
            AddGenreButton.Name = "AddGenreButton";
            AddGenreButton.Size = new Size(192, 52);
            AddGenreButton.TabIndex = 3;
            AddGenreButton.Text = "Add Genre";
            AddGenreButton.UseVisualStyleBackColor = true;
            AddGenreButton.Click += AddGenreButton_Click;
            // 
            // AddGenreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddGenreButton);
            Controls.Add(NewGenreDescription);
            Controls.Add(label5);
            Controls.Add(NewGenreTitle);
            Controls.Add(label1);
            Name = "AddGenreForm";
            Text = "AddGenreForm";
            Load += AddGenreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewGenreDescription;
        private Label label5;
        private TextBox NewGenreTitle;
        private Label label1;
        private Button AddGenreButton;
    }
}