namespace CourseWork.Forms
{
    partial class GenreInfoForm
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
            GenreDescription = new TextBox();
            label5 = new Label();
            GenreTitle = new TextBox();
            label1 = new Label();
            GenreGrid = new DataGridView();
            EditGenreButton = new Button();
            DeleteGenreButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GenreGrid).BeginInit();
            SuspendLayout();
            // 
            // GenreDescription
            // 
            GenreDescription.Anchor = AnchorStyles.Top;
            GenreDescription.Location = new Point(12, 85);
            GenreDescription.Multiline = true;
            GenreDescription.Name = "GenreDescription";
            GenreDescription.ReadOnly = true;
            GenreDescription.Size = new Size(294, 228);
            GenreDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 32;
            label5.Text = "Description";
            // 
            // GenreTitle
            // 
            GenreTitle.Anchor = AnchorStyles.Top;
            GenreTitle.Location = new Point(12, 32);
            GenreTitle.Name = "GenreTitle";
            GenreTitle.ReadOnly = true;
            GenreTitle.Size = new Size(124, 27);
            GenreTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 30;
            label1.Text = "Title";
            // 
            // GenreGrid
            // 
            GenreGrid.Anchor = AnchorStyles.Top;
            GenreGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GenreGrid.Location = new Point(312, 9);
            GenreGrid.Name = "GenreGrid";
            GenreGrid.RowHeadersWidth = 51;
            GenreGrid.Size = new Size(598, 304);
            GenreGrid.TabIndex = 3;
            // 
            // EditGenreButton
            // 
            EditGenreButton.Location = new Point(237, 341);
            EditGenreButton.Name = "EditGenreButton";
            EditGenreButton.Size = new Size(226, 48);
            EditGenreButton.TabIndex = 4;
            EditGenreButton.Text = "Edit";
            EditGenreButton.UseVisualStyleBackColor = true;
            EditGenreButton.Click += EditGenreButton_Click;
            // 
            // DeleteGenreButton
            // 
            DeleteGenreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteGenreButton.Location = new Point(488, 341);
            DeleteGenreButton.Name = "DeleteGenreButton";
            DeleteGenreButton.Size = new Size(226, 48);
            DeleteGenreButton.TabIndex = 5;
            DeleteGenreButton.Text = "Delete";
            DeleteGenreButton.UseVisualStyleBackColor = true;
            DeleteGenreButton.Click += DeleteGenreButton_Click;
            // 
            // GenreInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 425);
            Controls.Add(DeleteGenreButton);
            Controls.Add(EditGenreButton);
            Controls.Add(GenreGrid);
            Controls.Add(GenreDescription);
            Controls.Add(label5);
            Controls.Add(GenreTitle);
            Controls.Add(label1);
            MinimumSize = new Size(940, 472);
            Name = "GenreInfoForm";
            Text = "GenreInfoForm";
            Load += GenreInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)GenreGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GenreDescription;
        private Label label5;
        private TextBox GenreTitle;
        private Label label1;
        private DataGridView GenreGrid;
        private Button EditGenreButton;
        private Button DeleteGenreButton;
    }
}