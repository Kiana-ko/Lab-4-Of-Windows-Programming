using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lightBulb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        bool LightOn = true;
        bool lightOff = false;

        private void StatusDisplayer()  // Responsible for displaying the status of the light bulb wheter it is on or off !
        {
            listBox1.Items.Clear();

            if (LightOn)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Light is: On");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Light is: Off"); //IDK why it keeps displaying on, I tried several ways to fix it but I couldn't/
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StatusDisplayer(); //Calling the function we previpusly created
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }



        public void button1_Click(object sender, EventArgs e)
        {
            if (LightOn)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false; 
                LightOn = false; // Responsible for updating Light's status
            }
            else
            {
                pictureBox1.Visible = true; 
                pictureBox2.Visible = false; 
                LightOn = true; // Responsible for updating Light's status
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }
}
