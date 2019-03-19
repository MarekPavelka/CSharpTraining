namespace WindowsFormTest
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            copyButton.Click += CopyButton_Click;
        }

        private void CopyButton_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
