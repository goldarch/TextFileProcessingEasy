using System.Text;
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

            //由于html中的双引号需要转议，太麻烦，直接把文本存入资源文件中！不用转义！
            //全局资源文件设置相对简单
            //wbMain.DocumentText = TextFileProcessingEasy.Properties.Resources.AboutMe;

            //放在form自身的资源文件中便于复制！
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            //wbMain.DocumentText = resources.GetObject("AboutMe")?.ToString();

            wbMain.DocumentText = GenerateHtml();

        }

		private string GenerateHtml()
		{
            var html = @"
<html>
	<style>
		a { text-decoration: none; color: #000; } /* 状态一: 未被访问过的链接 */ a:link {
		text-decoration: none; color: #000; } /* 状态二: 已经访问过的链接 */ a:visited
		{ text-decoration: none; color: #000; } /* 状态三: 鼠标划过(停留)的链接(默认红色) */
		a:hover { text-decoration: none; color: #000; } /* 状态四: 被点击的链接 */ a:active
		{ text-decoration: none; color: #000; } .a1 { color: #000; padding:
		10px; text-decoration: none; font-size: 16px; background-color: #d8ffff;
		} .a1:active { background-color: #d8ffff; } .a2 { background-color: #F1EFC7;
		color: #000; padding: 10px; text-decoration: none; font-size: 16px;
		box-shadow: #666 0px 0px 6px; } .a2:active{ background-color: #bdbc9d;
		}
	</style>
	<body style='  background-gradient-angle: 60; margin: 0; '>
		<blockquote class='whitehole'>
			<p style='margin-top: 0px'>
				<p style='font-size:14px;'>
					<strong>
						金软(GoldArch)：打造黄金品质的软件架构
					</strong>
				</p>
				<p>
					专注于生产制造业管理软件的开发，特别是印刷业MES，烘焙连锁管理，具有丰富的生产制造业管理经验和生产制造业管理软件开发经验。
				</p>
				<p style='font-size:14px;'>
					<strong>
						关于本软件：按指定行数进行文本文件分切
					</strong>
				</p>
				<p>
					本软件主要用于文本文件的分切
					<br />
					如10000行的条码文件，需要分切出1000行,2000行,3000行的条码，
					<br />
					则可以编排分切计划为：
					<br />
					1000,2000,3000&nbsp;
					<br />
					则一个大文件会分为4个文件，
					<br />
					分别为计划的1000，2000，3000行的文件和一个剩下的行数的文件
					<br />
				</p>
				<p style='font-size:14px;'>
					<strong>
						联系方式：
					</strong>
				</p>
				<p>
					WeChat微信号:Goldarch
					<br />
					QQ:99490008
					<br />
					Email:99490008@qq.com
					<br />
					我的Github：https://github.com/goldarch
					<br/>
					我的网站：http://www.posn.net
					<br />
					我的微博：https://weibo.com/posnsoft
				</p>
				<a class='a1' href='https://github.com/goldarch' target='_blank'>
					访问[我的Github]
				</a>
				<a class='a2' href='http://www.posn.net' target='_blank'>
					访问[我的网站]
				</a>
				<a class='a2' href='https://weibo.com/posnsoft' target='_blank'>
					访问[我的微博]
				</a>
			</p>
		</blockquote>
	</body>

</html>

";

            return html;
        }

//		private string GenerateHtml()
//		{
//			//$!{row.身份证}

//			var ver = Application.ProductVersion;
//			var html = @"
//<html>
//	<head>
//		<title>
//			About Me
//		</title>
//	</head>
//	<style>
//		a { text-decoration: none; color: #000; } /* 状态一: 未被访问过的链接 */ a:link {
//		text-decoration: none; color: #FFD700; } /* 状态二: 已经访问过的链接 */ a:visited
//		{ text-decoration: none; color: #FFD700; } /* 状态三: 鼠标划过(停留)的链接(默认红色) */
//		a:hover { text-decoration: none; color: #FFD700; } /* 状态四: 被点击的链接 */ a:active
//		{ text-decoration: none; color: #FFD700; } .a1 { color: #000000; padding:
//		10px; text-decoration: none; font-size: 16px; background-color: #d8ffff;
//		} .a1:active { background-color: #d8ffff; } .a2 { background-color: #F1EFC7;
//		color: #000000; padding: 10px; text-decoration: none; font-size: 16px;
//		box-shadow: #666 0px 0px 6px; } .a2:active{ background-color: #bdbc9d;
//		}
//	</style>
//	<body style='  background-gradient-angle: 60; margin: 0; '>
//		<h1 align='center' style='background-color: #eee; background-gradient: gold; background-gradient-angle: 60; margin: 0; border-style: solid;'>
//			GoldArch-金软架构
//			<br />
//			<span style='font-size: x-small;'>
//				Release $!{ver}
//			</span>
//		</h1>
//		<blockquote class='whitehole'>
//			<p style='margin-top: 0px'>
//				<p style='font-size:14px;'>
//					<strong>
//						关于：GoldArch-金软架构
//					</strong>
//				</p>
//				<p>
//					专注于生产制造业管理软件的开发，特别是印刷业MES，烘焙连锁管理，具有丰富的生产制造业管理经验和生产制造业管理软件开发经验。
//				</p>
//				<p style='font-size:14px;'>
//					<strong>
//						关于本软件：HtmlRenderer测试
//					</strong>
//				</p>
//				<p>
//					本软件主要用于文本文件的分切
//					<br />
//					如10000行的条码文件，需要分切出1000行,2000行,3000行的条码，
//					<br />
//					则可以编排分切计划为：
//					<br />
//					1000,2000,3000&nbsp;
//					<br />
//					则一个大文件会分为4个文件，
//					<br />
//					分别为计划的1000，2000，3000行的文件和一个剩下的行数的文件
//					<br />
//				</p>
//				<p style='font-size:14px;'>
//					<strong>
//						联系方式：
//					</strong>
//				</p>
//				<p>
//					WeChat微信号:Goldarch
//					<br />
//					QQ:99490008
//					<br />
//					Email:99490008@qq.com
//					<br />
//					我的Github：https://Github.com/goldarch
//					<br/>
//					我的网站：http://www.posn.net
//					<br />
//					我的微博：https://weibo.com/posnsoft
//				</p>
//				<a class='a1' href='#'>
//					访问[我的Github]
//				</a>
//				<a class='a2' href='#'>
//					访问[我的网站]
//				</a>
//				<a class='a2' href='#'>
//					访问[我的微博]
//				</a>
//			</p>
//		</blockquote>
//	</body>

//</html>

//";
//			//ver的变量设置为{0}来进行替换时，这个替换太简单粗暴，会报错的！
//			//return string.Format(html, ver);

//			//更复杂的参与“数据导出”
//			var template = new NVelocityHelper(html, 0, "GB2312", Encoding.GetEncoding("GB2312"));
//			template.Put("ver", ver);

//			return template.ToString();
//		}
	}
}
