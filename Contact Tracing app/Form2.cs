using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void showbtn_Click(object sender, EventArgs e)
        {
            StreamReader outputFile = new StreamReader("Contact tracing form.txt");
            resultLabel.Text = outputFile.ReadToEnd();

            showbtn.Hide();
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}