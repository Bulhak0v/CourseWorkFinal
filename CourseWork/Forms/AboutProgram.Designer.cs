namespace CourseWork.Forms
{
    partial class AboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgram));
            label1 = new Label();
            label2 = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 41);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "Dear User";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(800, 300);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // OkButton
            // 
            OkButton.Location = new Point(243, 371);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(296, 42);
            OkButton.TabIndex = 2;
            OkButton.Text = "Continue";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AboutProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(830, 450);
            Controls.Add(OkButton);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(848, 497);
            MinimumSize = new Size(848, 497);
            Name = "AboutProgram";
            Text = "AboutProgram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button OkButton;
    }
}