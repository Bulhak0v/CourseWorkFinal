namespace CourseWork.Forms
{
    partial class AddStudioForm
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
            AddStudioButton = new Button();
            NewStudioDescription = new TextBox();
            label5 = new Label();
            NewStudioTitle = new TextBox();
            label1 = new Label();
            NewStudioAddress = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // AddStudioButton
            // 
            AddStudioButton.Anchor = AnchorStyles.Top;
            AddStudioButton.Location = new Point(308, 375);
            AddStudioButton.Name = "AddStudioButton";
            AddStudioButton.Size = new Size(192, 52);
            AddStudioButton.TabIndex = 4;
            AddStudioButton.Text = "Add Studio";
            AddStudioButton.UseVisualStyleBackColor = true;
            AddStudioButton.Click += AddStudioButton_Click;
            // 
            // NewStudioDescription
            // 
            NewStudioDescription.Anchor = AnchorStyles.Top;
            NewStudioDescription.Location = new Point(239, 123);
            NewStudioDescription.Multiline = true;
            NewStudioDescription.Name = "NewStudioDescription";
            NewStudioDescription.Size = new Size(294, 134);
            NewStudioDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(335, 100);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 33;
            label5.Text = "Description";
            // 
            // NewStudioTitle
            // 
            NewStudioTitle.Anchor = AnchorStyles.Top;
            NewStudioTitle.Location = new Point(288, 42);
            NewStudioTitle.Name = "NewStudioTitle";
            NewStudioTitle.Size = new Size(193, 27);
            NewStudioTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(358, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 31;
            label1.Text = "Title";
            // 
            // NewStudioAddress
            // 
            NewStudioAddress.Anchor = AnchorStyles.Top;
            NewStudioAddress.Location = new Point(239, 294);
            NewStudioAddress.Name = "NewStudioAddress";
            NewStudioAddress.Size = new Size(294, 27);
            NewStudioAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(358, 271);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 36;
            label2.Text = "Address";
            // 
            // AddStudioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewStudioAddress);
            Controls.Add(label2);
            Controls.Add(AddStudioButton);
            Controls.Add(NewStudioDescription);
            Controls.Add(label5);
            Controls.Add(NewStudioTitle);
            Controls.Add(label1);
            Name = "AddStudioForm";
            Text = "AddStudioForm";
            Load += AddStudioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddStudioButton;
        private TextBox NewStudioDescription;
        private Label label5;
        private TextBox NewStudioTitle;
        private Label label1;
        private TextBox NewStudioAddress;
        private Label label2;
    }
}