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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
        StreamWriter outputFile = File.CreateText("Contact tracing form.txt");
        outputFile.WriteLine("Name: "+nametxtbx.Text +"");
        outputFile.WriteLine();
            outputFile.WriteLine("Age: " + agetxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Address: " + addresstxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Postal Code: " + postaltxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Contact Number: " + contacttxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Date: " + datetxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Time: " + timetxtbx.Text + "");
            outputFile.WriteLine();
            outputFile.WriteLine("Temperature: " + temptxtxbx.Text + "");
            outputFile.WriteLine();
            outputFile.Close();
        }
    }
}
