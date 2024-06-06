namespace PdfMerger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnMergeFiles;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button btnRemoveFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSelectFiles = new Button();
            btnMergeFiles = new Button();
            btnMoveUp = new Button();
            btnMoveDown = new Button();
            listBoxFiles = new ListBox();
            btnRemoveFile = new Button();
            SuspendLayout();
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Location = new Point(13, 12);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(113, 34);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Add Files";
            btnSelectFiles.UseVisualStyleBackColor = true;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // btnMergeFiles
            // 
            btnMergeFiles.Location = new Point(483, 12);
            btnMergeFiles.Name = "btnMergeFiles";
            btnMergeFiles.Size = new Size(103, 34);
            btnMergeFiles.TabIndex = 1;
            btnMergeFiles.Text = "Merge Files";
            btnMergeFiles.UseVisualStyleBackColor = true;
            btnMergeFiles.Click += btnMergeFiles_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Location = new Point(592, 53);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(75, 53);
            btnMoveUp.TabIndex = 2;
            btnMoveUp.Text = "Up";
            btnMoveUp.UseVisualStyleBackColor = true;
            btnMoveUp.Click += btnMoveUp_Click_1;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Location = new Point(592, 363);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(75, 53);
            btnMoveDown.TabIndex = 3;
            btnMoveDown.Text = "Down";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += btnMoveDown_Click_1;
            // 
            // listBoxFiles
            // 
            listBoxFiles.AllowDrop = true;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.Location = new Point(13, 52);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(573, 364);
            listBoxFiles.TabIndex = 4;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            listBoxFiles.DragDrop += listBoxFiles_DragDrop;
            listBoxFiles.DragEnter += listBoxFiles_DragEnter;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.Location = new Point(132, 12);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(125, 34);
            btnRemoveFile.TabIndex = 4;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.UseVisualStyleBackColor = true;
            btnRemoveFile.Click += btnRemoveFile_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(678, 420);
            Controls.Add(listBoxFiles);
            Controls.Add(btnMoveDown);
            Controls.Add(btnRemoveFile);
            Controls.Add(btnMoveUp);
            Controls.Add(btnMergeFiles);
            Controls.Add(btnSelectFiles);
            Name = "Form1";
            Text = "PDF Merger - By Tuner Brands";
            ResumeLayout(false);
        }
    }
}
