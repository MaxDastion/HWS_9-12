namespace _12HW
{
    public partial class Form1 : Form
    {
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Random.Next(0, 3);
            if (n == 0)
            {
                pictureBox1.Image = Properties.Resources.R;
            }
            else if (n == 1)
            {

                pictureBox1.Image = Properties.Resources.F;
            }
            else
            {

                pictureBox1.Image = Properties.Resources.E;
            }

            if (comboBox1.SelectedIndex == 0 && n == 2)
            {
                label1.Text = "You lose";
            }
            else if (comboBox1.SelectedIndex == 1 && n == 0)
            {

                label1.Text = "You lose";
            }
            else if (comboBox1.SelectedIndex == 2 && n == 1)
            {

                label1.Text = "You lose";
            }
            else if (comboBox1.SelectedIndex == n)
            {
                n = Random.Next(0, 3);
            }
            else
            {

                label1.Text = "You win";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox2.Image = Properties.Resources.R;
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                pictureBox2.Image = Properties.Resources.F;
                
            }
            else
            {

                pictureBox2.Image = Properties.Resources.E;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
