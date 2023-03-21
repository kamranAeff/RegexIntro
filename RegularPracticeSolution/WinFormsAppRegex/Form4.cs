using System.Text.RegularExpressions;

namespace WinFormsAppRegex
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text;

            //content = content.Replace(txtFrom.Text, txtTo.Text);
            //000-00-00
            //content = Regex.Replace(content,txtFrom.Text, txtTo.Text);

            content = Regex.Replace(content, @"(?<symbol>[$£€₼₺])(?<amount>\d+(\.\d+)?)", "${amount}${symbol}", RegexOptions.Multiline);

            txtContent.Text = content;
        }
    }
}
