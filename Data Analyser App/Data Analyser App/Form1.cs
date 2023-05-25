using System.Windows.Forms;

namespace Data_Analyser_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBox1.Text);
            double averageIncreaseRate = double.Parse(textBox2.Text) / 100;
            int Days = int.Parse(textBox3.Text);

            double population = firstNumber;

            listBox3.Items.Clear(); 

            for (int d = 1; d <Days; d++)
            {
               /*Not sure about this part's formula, didn't get to spend much time on this assignment cuz I got kinda stuck with the
                light bulb assignment + tried a formula which didn't work!*/
            }
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
