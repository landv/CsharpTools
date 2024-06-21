using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_hex.Text = string.Empty;
            textBox_string.Text = string.Empty;
            textBox_hex.Focus();
        }

        private void textBox_hex_TextChanged(object sender, EventArgs e)
        {
            if (textBox_hex.Focused)
            {
                textBox_string.Text = string.Empty;
                StringTools stringTools = new StringTools();
                Encoding encoding = Encoding.GetEncoding(comboBox_Encoding.Text);

                if (stringTools.DecodeHexString(textBox_hex.Text, encoding) == null)
                {
                    textBox_hex.Text = string.Empty;
                    textBox_string.Text = string.Empty;
                    textBox_hex.Focus();

                }
                else
                {
                    textBox_string.Text = stringTools.DecodeHexString(textBox_hex.Text, encoding);
                }

            }


        }

        private void textBox_string_TextChanged(object sender, EventArgs e)
        {
            if (textBox_string.Focused)
            {
                textBox_hex.Text = string.Empty;
                StringTools stringTools = new StringTools();
                Encoding encoding = Encoding.GetEncoding(comboBox_Encoding.Text);
                textBox_hex.Text = stringTools.EncodeToHexString(textBox_string.Text, encoding);
            }
        }

        private void textBox_hex_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_hex.SelectAll();
            Clipboard.SetText(textBox_hex.SelectedText);
        }

        private void textBox_string_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_string.SelectAll();
            Clipboard.SetText(textBox_string.SelectedText);
        }
    }
}
