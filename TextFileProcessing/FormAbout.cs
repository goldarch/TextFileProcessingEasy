using System.Windows.Forms;

namespace TextFileProcessingEasy
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            versionLabel.Text = @"Ver："  + Application.ProductVersion;
            descTextBox.SelectionStart = 0;
        }
    }
}
