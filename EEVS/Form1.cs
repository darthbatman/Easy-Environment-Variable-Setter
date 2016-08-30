using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static void Set(string name, string value)
        {
            Environment.SetEnvironmentVariable(name, value, EnvironmentVariableTarget.Machine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oldPath = Environment.GetEnvironmentVariable("Path");
            string newPath;
            System.Diagnostics.Debug.Write(oldPath);
            char last = oldPath[oldPath.Length - 1];
            if (last == ';')
            {
                newPath = oldPath + textBox1.Text;
                newPath += ";";
            }
            else
            {
                newPath = oldPath += ";";
                newPath += textBox1.Text;
                newPath += ";";
            }
            Set("Path", newPath);
        }
    }
}
