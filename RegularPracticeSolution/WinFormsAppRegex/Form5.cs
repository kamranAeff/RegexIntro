using System.Text.RegularExpressions;

namespace WinFormsAppRegex
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGetWords_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text;

            string[] words = Regex.Split(content,@"[^a-zA-Z0-9İəŞşöıüÜ]");

            lstWords.Items.Clear();
            lstWords.Items.AddRange(words);
        }
    }
}
