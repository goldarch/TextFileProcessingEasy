using System.Windows.Forms;
using TextFileProcessingEasy.Properties;

namespace TextFileProcessingEasy
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            versionLabel.Text = @"Ver："  + Application.ProductVersion;
        }

        private void FormAbout_Load(object sender, System.EventArgs e)
        {
            //            richTextBox1.Rtf = @"GoldArch 金软架构，主要从事企业管理软件的开发，具有制造业管理经验和软件开发经验。

            //说明：
            //本软件主要用于文本文件的分切
            //如10000行的条码文件，需要分切出1000行,2000行,3000行的条码，
            //则可以编排分切计划为：
            //1000,2000,3000 
            //则一个大文件会分为4个文件，
            //分别为计划的1000，2000，3000行的文件和一个剩下的行数的文件

            //WeChat微信号:Goldarch
            //QQ:99490008
            //Email:99490008@qq.com
            //https://github.com/goldarch
            //http://www.posn.net/
            //";

            //在线html编辑器
            //http://kindeditor.net/demo.php 
            //https://www.lddgo.net/string/htmleditor
            //https://www.qianbo.com.cn/Tool/HtmlEditor.html
            wbMain.DocumentText = Resources.AboutMe;

        }
    }
}
