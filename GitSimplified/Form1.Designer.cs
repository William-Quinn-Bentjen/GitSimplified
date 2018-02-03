namespace GitSimplified
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Init = new System.Windows.Forms.Button();
            this.Clone = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Pull = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.TextBox();
            this.OpenGitBash = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.BranchBox = new System.Windows.Forms.TextBox();
            this.CreateGitIgnore = new System.Windows.Forms.Button();
            this.CommitMessage = new System.Windows.Forms.TextBox();
            this.URLBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(174, 172);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(98, 23);
            this.Init.TabIndex = 1;
            this.Init.Text = "Initalize and Push";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // Clone
            // 
            this.Clone.Location = new System.Drawing.Point(278, 90);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(94, 23);
            this.Clone.TabIndex = 2;
            this.Clone.Text = "Clone";
            this.Clone.UseVisualStyleBackColor = true;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(278, 172);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(94, 23);
            this.Push.TabIndex = 3;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Pull
            // 
            this.Pull.Location = new System.Drawing.Point(278, 119);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(94, 23);
            this.Pull.TabIndex = 4;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = true;
            this.Pull.Click += new System.EventHandler(this.Pull_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.AllowDrop = true;
            this.SelectFolder.Location = new System.Drawing.Point(12, 66);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(260, 20);
            this.SelectFolder.TabIndex = 7;
            this.SelectFolder.Text = "Folder to run git commands in";
            // 
            // OpenGitBash
            // 
            this.OpenGitBash.Location = new System.Drawing.Point(278, 41);
            this.OpenGitBash.Name = "OpenGitBash";
            this.OpenGitBash.Size = new System.Drawing.Size(94, 23);
            this.OpenGitBash.TabIndex = 8;
            this.OpenGitBash.Text = "Open GitBash";
            this.OpenGitBash.UseVisualStyleBackColor = true;
            this.OpenGitBash.Click += new System.EventHandler(this.OpenGitBash_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(12, 172);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(94, 23);
            this.Help.TabIndex = 9;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // BranchBox
            // 
            this.BranchBox.Location = new System.Drawing.Point(12, 38);
            this.BranchBox.Name = "BranchBox";
            this.BranchBox.Size = new System.Drawing.Size(260, 20);
            this.BranchBox.TabIndex = 10;
            this.BranchBox.Text = "Branch name (if it contains a space won\'t change branch)";
            // 
            // CreateGitIgnore
            // 
            this.CreateGitIgnore.Location = new System.Drawing.Point(278, 12);
            this.CreateGitIgnore.Name = "CreateGitIgnore";
            this.CreateGitIgnore.Size = new System.Drawing.Size(94, 23);
            this.CreateGitIgnore.TabIndex = 11;
            this.CreateGitIgnore.Text = "Create .gitignore";
            this.CreateGitIgnore.UseVisualStyleBackColor = true;
            this.CreateGitIgnore.Click += new System.EventHandler(this.CreateGitIgnore_Click);
            // 
            // CommitMessage
            // 
            this.CommitMessage.Location = new System.Drawing.Point(12, 93);
            this.CommitMessage.Multiline = true;
            this.CommitMessage.Name = "CommitMessage";
            this.CommitMessage.Size = new System.Drawing.Size(260, 73);
            this.CommitMessage.TabIndex = 12;
            this.CommitMessage.Text = "Commit Message";
            // 
            // URLBox
            // 
            this.URLBox.DetectUrls = false;
            this.URLBox.EnableAutoDragDrop = true;
            this.URLBox.Location = new System.Drawing.Point(12, 9);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(260, 23);
            this.URLBox.TabIndex = 13;
            this.URLBox.Text = "URL of repo";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(384, 207);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.CommitMessage);
            this.Controls.Add(this.CreateGitIgnore);
            this.Controls.Add(this.BranchBox);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.OpenGitBash);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.Pull);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Clone);
            this.Controls.Add(this.Init);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 246);
            this.MinimumSize = new System.Drawing.Size(400, 246);
            this.Name = "Form1";
            this.Text = "GitSimplified";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Pull;
        public System.Windows.Forms.TextBox SelectFolder;
        private System.Windows.Forms.Button OpenGitBash;
        private System.Windows.Forms.Button Help;
        public System.Windows.Forms.TextBox BranchBox;
        private System.Windows.Forms.Button CreateGitIgnore;
        public System.Windows.Forms.TextBox CommitMessage;
        private System.Windows.Forms.RichTextBox URLBox;
    }
}

