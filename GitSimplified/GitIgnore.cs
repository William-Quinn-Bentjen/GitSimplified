using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSimplified
{
    public partial class GitIgnore : Form
    {
        public GitIgnore()
        {
            InitializeComponent();
            BackColor = Form1. DefaultBackColor;
        }

        private void GitIgnore_Load(object sender, EventArgs e)
        {
            //Contents.Text = Form1.gitIgnorePath;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //save
            string[] lines = Contents.Lines;
            System.IO.File.WriteAllLines(Form1.gitIgnorePath + @"\.gitignore", lines);
            Close();
        }
    }
}
