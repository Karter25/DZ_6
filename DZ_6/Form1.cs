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

namespace DZ_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   StreamWriter textFile;
               FileInfo file = new FileInfo("");
               textFile = file.AppendText();
               textFile.WriteLine(textBox1.Text);
               textFile.Close();
   */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {



                StreamReader Reader = new StreamReader(openFileDialog1.FileName);
                string str = "";
                while (!Reader.EndOfStream)
                {
                    str += Reader.ReadLine();
                }

                label2.Text = str.Trim().Split(' ').Length.ToString();
                label1.Text = str;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

