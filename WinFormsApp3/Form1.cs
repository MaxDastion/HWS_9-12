namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                File.WriteAllText(textBox2.Text, textBox1.Text);
                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Please, enter file name");
            }
        }

        private void FontB_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void ColorB_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }
    }
}
