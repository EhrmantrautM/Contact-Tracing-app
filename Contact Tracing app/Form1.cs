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
        public void submitbtn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.CreateText("Contact tracing form.txt");
            outputFile.WriteLine("Name: " + nametxtbx.Text + "");
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
            this.Visible = false;
            {//Scrutinizer      
            if (int.Parse(agetxtbx.Text) < (Convert.ToByte("18")))
                MessageBox.Show("WARNING: In Accordance with the guidelines of the IATF and Local Government Units, persons from 18 to 65 years of age are only authorized to enter the premises.");           
            else if (float.Parse(temptxtxbx.Text) > Convert.ToByte("37"))
                 MessageBox.Show("WARNING: In Accordance with the guidelines of the IATF and Local Government Units, persons lower than 37 degree Celcius are only authorized to enter the premises. ");
            else
              {
              Form2 Form2 = new Form2();
              Form2.ShowDialog();
              }
              this.Close();
           }
        }
    }
 }
 