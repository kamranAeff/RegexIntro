using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppRegex
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGetAllKeys_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;

            bool isLink = Regex.IsMatch(url, @"^(http(s):\/\/.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$");

            if (!isLink)
            {
                MessageBox.Show("Daxil edilen link uygun deyil");
                txtUrl.Focus();
                return;
            }

            using (var client = new HttpClient())
            {
                var envelope = client.GetAsync(url).Result;

                if (!envelope.IsSuccessStatusCode)
                {
                    MessageBox.Show("link tapilmadi");
                    txtUrl.Focus();
                    return;
                }

                string envelopeBody = envelope.Content.ReadAsStringAsync().Result;

                MatchCollection keys = Regex.Matches(envelopeBody, @"[0-9a-zA-Z]{5}-[0-9a-zA-Z]{5}-[0-9a-zA-Z]{5}-[0-9a-zA-Z]{5}-[0-9a-zA-Z]{5}");

                lstKeys.Items.Clear();

                foreach (Match key in keys) {

                    lstKeys.Items.Add(key.Value);
                }
            }
        }
    }
}
