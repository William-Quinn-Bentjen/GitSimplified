using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GitSimplified
{
    public partial class Form1 : Form
    {
        public static string gitIgnorePath = "";
        private static string quote = "\"";
        private static string push = "push";
        private static string pull = "pull";
        private static string clone = "clone";
        private static string init = "init";
        string GitSimplifiedBat = Directory.GetCurrentDirectory() + @"\GitSimplifed.bat";
        public Form1()
        {
            InitializeComponent();
            this.SelectFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.SelectFolder_DragDrop);
            this.SelectFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.SelectFolder_DragEnter);
        }
        private void SelectFolder_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void SelectFolder_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            string retValue = "";
            for (i = 0; i < s.Length; i++)
            {
                retValue = retValue + s[i];
            }
            SelectFolder.Text = retValue;
        }
        private void OpenGitBash_Click(object sender, EventArgs e)
        {
            //open gitbash in SelectFolder.Text if != "Folder for git to run commands in"
            if (File.Exists(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Git\Git Bash.lnk"))
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Git\Git Bash.lnk");
            }
            else if (File.Exists(@"C:\Program Files\Git\git-bash.exe"))
            {
                Process.Start(@"C:\ProgramFiles\Git\git-bash.exe");
            }
            else
            {
                //gitbash not found
                MessageBox.Show("gitbash not found");
            }
        }

        private void CreateGitIgnore_Click(object sender, EventArgs e)
        {
            //folder good?
            if (CheckTextBox(GetFolder()))
            {
                //create .gitignore dialog box
                gitIgnorePath = SelectFolder.Text;
                GitIgnore CreateGitIgnoreForm = new GitIgnore();
                CreateGitIgnoreForm.ShowDialog();
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            //help
            Process.Start("http://google.com");
        }

        private void Push_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(GetFolder()) && CheckTextBox(GetCommitMessage()))
            {
                string workingDirectory = GetFolder();
                string commitMessage = GetCommitMessage();
                //no valid branch name (pass no branch)
                if (CheckTextBox(GetBranch()) == false)
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1} {2}",
                                                push,
                                                workingDirectory,
                                                commitMessage)
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                }
                //valid branch name (pass banch name)
                else
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1} {2} {3}",
                                                push,
                                                workingDirectory,
                                                commitMessage,
                                                GetBranch())
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                }
            }
        }

        private void Init_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(GetFolder()) && CheckTextBox(GetURL()) && CheckTextBox(GetCommitMessage()))
            {
                string workingDirectory = GetFolder();
                string repoURL = GetURL();
                string commitMessage = GetCommitMessage();
                var process = new Process
                {
                    StartInfo = {
                      Arguments = string.Format("{0} {1} {2} {3}",
                                                init,
                                                workingDirectory,
                                                repoURL,
                                                commitMessage)
                                }
                };
                process.StartInfo.FileName = GitSimplifiedBat;
                bool b = process.Start();
            }
        }

        private void Pull_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(GetFolder()))
            {
                string workingDirectory = GetFolder();
                if (CheckTextBox(GetBranch()) == false)
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1}",
                                                pull,
                                                workingDirectory)
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1} {2}",
                                                pull,
                                                workingDirectory,
                                                GetBranch())
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                }
            }
        }

        private void Clone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetURL());
            if (CheckTextBox(GetFolder()) && CheckTextBox(GetURL()))
            {
                string workingDirectory = GetFolder();
                string repoURL = GetURL();
                if (CheckTextBox(GetBranch()) == false)
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1} {2}",
                                                clone,
                                                workingDirectory,
                                                repoURL)
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                    MessageBox.Show(repoURL);
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo = {
                      Arguments = string.Format("{0} {1} {2} {3}",
                                                clone,
                                                workingDirectory,
                                                repoURL,
                                                GetBranch())
                                }
                    };
                    process.StartInfo.FileName = GitSimplifiedBat;
                    bool b = process.Start();
                }
            }
        }

        private string GetURL()
        {
            if (URLBox.Text.Contains(" "))
            {
                MessageBox.Show("URL can not contain a space, aborting action");
                return "STRING ERROR";
            }
            return URLBox.Text;
        }

        private string GetBranch()
        {
            if (BranchBox.Text.Contains(" "))
            {
                //will use no branch on bat file uncomment line below to give user a message that the box contains a space
                //MessageBox.Show("Branch contains a space continueing without a branch");
                return "BRANCH ERROR";
            }
            return BranchBox.Text;
        }

        private string GetFolder()
        {
            if (Directory.Exists(SelectFolder.Text) == false)
            {
                MessageBox.Show("Folder to run git commands in doesn't seem to be a valid folder, aborting action");
                return "FOLDER ERROR";
            }
            return quote + SelectFolder.Text + quote;
        }

        private string GetCommitMessage()
        {
            if (CommitMessage.Text == "")
            {
                MessageBox.Show("Commit message box can not be left blank!");
                return "COMMIT ERROR";
            }
            return quote + CommitMessage.Text + quote;
        }

        //use CheckTextBox(GetURL()); to get a bool of if the box is invalid
        private bool CheckTextBox(string input)
        {
            if (input == "STRING ERROR" || input == "BRANCH ERROR" || input == "FOLDER ERROR" || input == "COMMIT ERROR")
            {
                return false;
            }
            if (CommitMessage.Text == "Commit Message" && input == GetCommitMessage())
            {
                DialogResult dialogResult = MessageBox.Show("You have left the default commit message of\nCommit Message\nWould you like to go back and change it?", "Commit Message is default", MessageBoxButtons.YesNo);
                switch (dialogResult)
                {
                    case DialogResult.No:
                        return true;
                    case DialogResult.Yes:
                        return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

