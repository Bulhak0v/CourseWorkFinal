namespace CourseWork.Forms
{
    partial class StudioInfoForm
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
            DeleteStudioButton = new Button();
            EditStudioButton = new Button();
            StudioGrid = new DataGridView();
            StudioDescription = new TextBox();
            label5 = new Label();
            StudioTitle = new TextBox();
            label1 = new Label();
            StudioAddress = new TextBox();
            label2 = new Label();
            StudioId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudioGrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteStudioButton
            // 
            DeleteStudioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteStudioButton.Location = new Point(467, 390);
            DeleteStudioButton.Name = "DeleteStudioButton";
            DeleteStudioButton.Size = new Size(226, 48);
            DeleteStudioButton.TabIndex = 7;
            DeleteStudioButton.Text = "Delete";
            DeleteStudioButton.UseVisualStyleBackColor = true;
            DeleteStudioButton.Click += DeleteStudioButton_Click;
            // 
            // EditStudioButton
            // 
            EditStudioButton.Location = new Point(239, 390);
            EditStudioButton.Name = "EditStudioButton";
            EditStudioButton.Size = new Size(226, 48);
            EditStudioButton.TabIndex = 6;
            EditStudioButton.Text = "Edit";
            EditStudioButton.UseVisualStyleBackColor = true;
            EditStudioButton.Click += EditStudioButton_Click;
            // 
            // StudioGrid
            // 
            StudioGrid.Anchor = AnchorStyles.Top;
            StudioGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudioGrid.Location = new Point(304, 12);
            StudioGrid.Name = "StudioGrid";
            StudioGrid.RowHeadersWidth = 51;
            StudioGrid.Size = new Size(823, 304);
            StudioGrid.TabIndex = 5;
            // 
            // StudioDescription
            // 
            StudioDescription.Anchor = AnchorStyles.Top;
            StudioDescription.Location = new Point(4, 88);
            StudioDescription.Multiline = true;
            StudioDescription.Name = "StudioDescription";
            StudioDescription.ReadOnly = true;
            StudioDescription.Size = new Size(294, 112);
            StudioDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(4, 65);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 39;
            label5.Text = "Description";
            // 
            // StudioTitle
            // 
            StudioTitle.Anchor = AnchorStyles.Top;
            StudioTitle.Location = new Point(4, 35);
            StudioTitle.Name = "StudioTitle";
            StudioTitle.ReadOnly = true;
            StudioTitle.Size = new Size(124, 27);
            StudioTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(4, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 37;
            label1.Text = "Title";
            // 
            // StudioAddress
            // 
            StudioAddress.Anchor = AnchorStyles.Top;
            StudioAddress.Location = new Point(4, 238);
            StudioAddress.Name = "StudioAddress";
            StudioAddress.ReadOnly = true;
            StudioAddress.Size = new Size(281, 27);
            StudioAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(4, 215);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 44;
            label2.Text = "Address";
            // 
            // StudioId
            // 
            StudioId.Anchor = AnchorStyles.Top;
            StudioId.Location = new Point(4, 289);
            StudioId.Name = "StudioId";
            StudioId.ReadOnly = true;
            StudioId.Size = new Size(281, 27);
            StudioId.TabIndex = 4;
            // 
            // StudioInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 450);
            Controls.Add(StudioId);
            Controls.Add(StudioAddress);
            Controls.Add(label2);
            Controls.Add(DeleteStudioButton);
            Controls.Add(EditStudioButton);
            Controls.Add(StudioGrid);
            Controls.Add(StudioDescription);
            Controls.Add(label5);
            Controls.Add(StudioTitle);
            Controls.Add(label1);
            MinimumSize = new Size(1169, 497);
            Name = "StudioInfoForm";
            Text = "StudioInfoForm";
            Load += StudioInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudioGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteStudioButton;
        private Button EditStudioButton;
        private DataGridView StudioGrid;
        private TextBox StudioDescription;
        private Label label5;
        private TextBox StudioTitle;
        private Label label1;
        private TextBox StudioAddress;
        private Label label2;
        private TextBox StudioId;
    }
}