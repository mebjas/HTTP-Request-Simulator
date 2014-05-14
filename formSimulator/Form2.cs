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

namespace formSimulator
{
    public partial class Form2 : Form
    {
        private string tempfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/formsimulatortemp.txt";
        public Form2(string regex)
        {
            InitializeComponent();
            string data = File.ReadAllText(tempfile);
            regexdata.Text = data;
            this.Text = "REGEX: " +regex;
        }

        private void regexdata_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
