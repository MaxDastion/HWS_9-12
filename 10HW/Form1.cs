namespace _10HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    textBox1.Text = text.Remove(i, 1);
                    textBox1.SelectionStart = i;
                    break;
                }
            }
        }
    }
}
