using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1, R2;
            
            //read varaibles
            double R1;
           double R2;

            
            //read txt box values
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("type a number not letter");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("type a number not letter");
                R2 = 0.0;
            }

            //calculate R1 and R2
            double R1 = R1 cos(angle);
            double R2 = Force * sin(angle);

            //put values for Fx and Fy in labels 
            label1.Text = "Fx = " + Fx + "N";
            label2.Text = "Fy = " + Fy + "N";


        }
    }
