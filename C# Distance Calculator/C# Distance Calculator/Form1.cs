using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double drivenHours) && double.TryParse(textBox2.Text, out double vehicleSpeed))
            {
                listBox1.Items.Clear();
                

                double totalDistance = drivenHours * vehicleSpeed;
                double averageSpeed = totalDistance / drivenHours;

                int hourEstimator = 1;
                while (hourEstimator <= drivenHours)
                {
                    double distance = hourEstimator * vehicleSpeed;
                    listBox1.Items.Add($"The Distance After Hour {hourEstimator}: {distance}");
                    hourEstimator++;
                }


                listBox2.Items.Clear();


                listBox2.Items.Add($"Total Driven Hours: {drivenHours}");
                listBox2.Items.Add($"Total Distance: {totalDistance}");
                listBox2.Items.Add($"Average Speed: {averageSpeed}");
            }
            else
            {
                MessageBox.Show("OOPS... Try Inputting an Integer");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Image Resource: https://unsplash.com/photos/-6LYjG0H32E //
        }
    }
}
