namespace FileNameCopy
{
    partial class FileDropForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDropForm));
            this.fileDropListBox = new System.Windows.Forms.ListBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.fileNameButton = new System.Windows.Forms.Button();
            this.fullNameButton = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileDropListBox
            // 
            this.fileDropListBox.FormattingEnabled = true;
            this.fileDropListBox.Location = new System.Drawing.Point(13, 13);
            this.fileDropListBox.Name = "fileDropListBox";
            this.fileDropListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fileDropListBox.Size = new System.Drawing.Size(267, 69);
            this.fileDropListBox.TabIndex = 0;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(15, 95);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(75, 23);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "Path";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // fileNameButton
            // 
            this.fileNameButton.Location = new System.Drawing.Point(103, 95);
            this.fileNameButton.Name = "fileNameButton";
            this.fileNameButton.Size = new System.Drawing.Size(75, 23);
            this.fileNameButton.TabIndex = 2;
            this.fileNameButton.Text = "FileName";
            this.fileNameButton.UseVisualStyleBackColor = true;
            this.fileNameButton.Click += new System.EventHandler(this.fileNameButton_Click);
            // 
            // fullNameButton
            // 
            this.fullNameButton.Location = new System.Drawing.Point(191, 95);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(91, 23);
            this.fullNameButton.TabIndex = 3;
            this.fullNameButton.Text = "Name + Path";
            this.fullNameButton.UseVisualStyleBackColor = true;
            this.fullNameButton.Click += new System.EventHandler(this.fullNameButton_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "File Name Copier";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 124);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 153);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fullNameButton);
            this.Controls.Add(this.fileNameButton);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.fileDropListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Name Copier";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileDropListBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Button fileNameButton;
        private System.Windows.Forms.Button fullNameButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Button clearButton;

    }
}

