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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetAllNumbers_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();

            string content = txtContent.Text;

            MatchCollection matches = Regex.Matches(content, @"(\+994|0)(50|51|55|70|77|99|10)-?(\d{3}-\d{2}-\d{2})|(\d{7})");

            foreach (Match item in matches)
            {
                lstNumbers.Items.Add(item.Value);
            }
        }
    }
}
