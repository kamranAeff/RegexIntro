using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsAppRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
            #fff
            #a0f9ff
         */
        private void btnValidate_Click(object sender, EventArgs e)
        {
            string time = txtTime.Text;

            string pattern = @"^([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$";

            bool isValid = Regex.IsMatch(time, pattern);

            if (isValid)
            {
                MessageBox.Show("Duzgun tarix!");
            }
            else
            {
                MessageBox.Show("Tarix duzgun deyil!");
            }
        }

        private void btnColorValidate_Click(object sender, EventArgs e)
        {
            string hexCode = txtHexColor.Text;

            bool isValid = Regex.IsMatch(hexCode, @"^#([a-fA-F0-9]{3}|[a-fA-F0-9]{6})$");

            if (isValid)
            {
                MessageBox.Show("Reng Duzgundur");
            }
            else
            {
                MessageBox.Show("Reng duzgun deyil!");
            }
        }

        private void btnTestMathc_Click(object sender, EventArgs e)
        {
            string time = txtTime.Text;

            Match state = Regex.Match(time, @"^([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$");

            //10 saat 12deq 33san

            if (state.Success)
            {
                string fullTime = state.Groups[0].Value;
                string saat = state.Groups[1].Value;
                string deqiqe = state.Groups[2].Value;
                string saniye = state.Groups[3].Value;

                MessageBox.Show(fullTime);
                MessageBox.Show($"{saat} saat {deqiqe}deq {saniye}san");
            }
            else
            {
                MessageBox.Show("Tarix duzgun deyil!");
            }
        }

        private void btnMobilePhoneCheck_Click(object sender, EventArgs e)
        {
            string data = txtPhone.Text;

            var state = Regex.Match(data, @"^(?<cCode>\+994|0)(?<oCode>50|51|55|70|77|99|10)-(?<number>\d{3}-\d{2}-\d{2})$");

            if (state.Success)
            {
                string countryCode = state.Groups["cCode"].Value;
                string operatorCode = state.Groups["oCode"].Value;
                string number = state.Groups["number"].Value;

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("Ölkə kodu: {0}",countryCode);
                sb.Append(Environment.NewLine);
                sb.AppendFormat("Operator kodu: {0}", operatorCode);
                sb.Append(Environment.NewLine);
                sb.AppendFormat("Nömrə: {0}\n", number);


                txtResponse.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Telefon nomresi duzgun deyil!");
            }
        }
    }
}