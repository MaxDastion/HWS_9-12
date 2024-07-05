namespace _11HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Число {trackBar1.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            long factorial = CalculateFactorial(n);
            label1.Text = $"{n}!"; 
            textBox1.Text = factorial.ToString();
        }
        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
