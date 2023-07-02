namespace FileSorting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            PathText = new TextBox();
            SortBtn = new Button();
            ExitBtn = new Button();
            BrowseBtn = new Button();
            SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // PathText
            // 
            PathText.Location = new Point(34, 89);
            PathText.Name = "PathText";
            PathText.Size = new Size(392, 23);
            PathText.TabIndex = 0;
            PathText.TextChanged += textBox1_TextChanged;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(34, 145);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(258, 23);
            SortBtn.TabIndex = 1;
            SortBtn.Text = "Sort";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(296, 145);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(258, 23);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(432, 89);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(122, 23);
            BrowseBtn.TabIndex = 3;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 223);
            Controls.Add(BrowseBtn);
            Controls.Add(ExitBtn);
            Controls.Add(SortBtn);
            Controls.Add(PathText);
            Name = "Form1";
            Text = "Welcome Sorting App ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox PathText;
        private Button SortBtn;
        private Button ExitBtn;
        private Button BrowseBtn;
    }
}