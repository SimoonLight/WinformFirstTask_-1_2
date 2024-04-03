
using Microsoft.VisualBasic.Devices;

namespace task1_2
{
    public partial class Form1 : Form
    {
        public static int choice = 1;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer=new();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += Control_time;
        }

        private void Control_time(object s,EventArgs e )
        {
            if(choice == 1)
            {
               label1.Text = DateTime.Now.ToString();
            }
            else
            {
               label1.Text = DateTime.Now.AddHours(-3.0).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //baki
            //label1.Text= 
            Clock clock1 = new Clock();

            choice= 1;

            pictureBox1.Image = Properties.Resources.baki_sekil;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //london

            Clock clock1 = new Clock();

            choice= 2;

            pictureBox1.Image = Properties.Resources.london_sekil;

        }
    }
}
