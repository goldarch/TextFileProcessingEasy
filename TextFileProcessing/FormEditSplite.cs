using System;
using System.Text;
using System.Windows.Forms;

namespace TextFileProcessingEasy
{
    public partial class FormEditSplite : Form
    {
        public string SpliteString;
        public FormEditSplite(string str)
        {
            InitializeComponent();

            SpliteString = str;
        }

        private void FormEditSplite_Load(object sender, EventArgs e)
        {
            var strArray = SpliteString.Split(',');
            textBox1.Lines = strArray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var str in textBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    continue;
                }

                if (str=="0")
                {
                    continue;
                }

                sb.Append(str + ",");
            }

            SpliteString = sb.ToString();

            DialogResult = DialogResult.OK;

        }

        private void button取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
