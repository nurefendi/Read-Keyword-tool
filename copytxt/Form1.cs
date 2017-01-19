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

namespace copytxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentLine = File.ReadLines(@namatxt).Skip(LastLineNumber).First();
            CurrentLine = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CurrentLine.ToLower());
            textBox1.Text = CurrentLine;

            this.Text = ".:: Copy TXT Ala masfen ::. | " + namatxt;
        }
        string CurrentLine;
        int LastLineNumber;
        string namatxt = "ini.txt";

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    CurrentLine = File.ReadLines(@namatxt).Skip(LastLineNumber).First();
                    CurrentLine = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CurrentLine.ToLower());
                    textBox1.Text = CurrentLine;
                    LastLineNumber++;
                    textBox1.Focus();
                    textBox1.SelectAll();
                    textBox1.Copy();


                }
                catch
                {
                    SendKeys.Send("z");
                    Application.Exit();

                }           
        }
    }
}
