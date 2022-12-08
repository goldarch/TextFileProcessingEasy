using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextFileProcessingEasy
{
    public partial class 行数量拆分计划 : Form
    {
        public 行数量拆分计划()
        {
            InitializeComponent();
        }

        private void 拆分行数计划_Load(object sender, EventArgs e)
        {
            ucSingleFileSelect1.FuncSelected += AfterFileSelected;
        }

        bool AfterFileSelected(string filePath)
        {
            //var fileInfo = new FileInfo(path);
            //textBoxFileNameHeader.Text = fileInfo.Name;
            //"获取文件的名称没有后缀："
            var nameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            //str = "获取路径的后缀扩展名称：" + Path.GetExtension(filePath); //-->.xml
            //自带"."
            var fileExtension = Path.GetExtension(filePath);

            var 分隔符转换信息 = "";
            if (checkBox分隔符转换.Checked)
            {
                分隔符转换信息 = $"(分隔符转换_{comboBox原始分隔符.Text}_转_{comboBox目标分隔符.Text})";
            }

            var template = $"{nameWithoutExtension}{分隔符转换信息}_Splite{{0}}{fileExtension}";

            textBoxFileNameTemplate.Text = template;

            ucSingleFolderSelect1.SelectedPath = Path.GetDirectoryName(filePath);

            return true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////阻止从键盘输入键
            //e.Handled = true;
            //if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
            //{
            //    if ((e.KeyChar == (char)8)) { e.Handled = false; return; }
            //    else
            //    {
            //        int len = TxtUser.Text.Length;
            //        if (len < 5)
            //        {
            //            if (len == 0 && e.KeyChar != '0')
            //            {
            //                e.Handled = false; return;
            //            }
            //            else if (len == 0)
            //            {
            //                MessageBox.Show("编号不能以0开头！"); return;
            //            }
            //            e.Handled = false; return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("编号最多只能输入5位数字！");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("编号只能输入数字！");
            //}

            //C# textbox限制仅输入数字和小数点
            //public static void Key_Press(KeyPressEventArgs e, TextBox txt)
            //{
            //    if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)

            //        e.Handled = true;


            //    //小数点的处理。

            //    if (e.KeyChar == 46)                           //小数点
            //    {
            //        if (txt.Text.Length == 0)
            //            e.Handled = true;   //小数点不能在第一位
            //        else
            //        {
            //            float f;
            //            float oldf;
            //            bool b1 = false, b2 = false;
            //            b1 = float.TryParse(txt.Text, out oldf);
            //            b2 = float.TryParse(txt.Text + e.KeyChar.ToString(), out f);
            //            if (b2 == false)
            //            {
            //                if (b1 == true)
            //                    e.Handled = true;
            //                else
            //                    e.Handled = false;
            //            }
            //        }
            //    }
            //}
            //————————————————
            //版权声明：本文为CSDN博主「seven_apple」的原创文章，遵循CC 4.0 BY - SA版权协议，转载请附上原文出处链接及本声明。
            //原文链接：https://blog.csdn.net/seven_apple/article/details/108961094
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormEditSplite(textBoxSpliteString.Text);
            var result = frm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                textBoxSpliteString.Text = frm.SpliteString;
            }
        }

        private void button拆分_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucSingleFileSelect1.SelectedPath))
            {
                MessageBox.Show(@"拆分文件不能为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(ucSingleFileSelect1.SelectedPath))
            {
                MessageBox.Show(@"拆分文件不存在", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ucSingleFolderSelect1.SelectedPath))
            {
                MessageBox.Show(@"目录文件夹不能为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(ucSingleFolderSelect1.SelectedPath))
            {
                MessageBox.Show(@"目录文件夹不存在", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSpliteString.Text) && !checkBox分隔符转换.Checked)
            {
                MessageBox.Show(@"拆分计划不能为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFileNameTemplate.Text))
            {
                MessageBox.Show(@"拆分名称模板不能为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!textBoxFileNameTemplate.Text.Contains("{0}"))
            {
                MessageBox.Show(@"拆分名称模板必须包含{0}", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox分隔符转换.Checked && (string.IsNullOrWhiteSpace(comboBox原始分隔符.Text) ||
                                          string.IsNullOrWhiteSpace(comboBox目标分隔符.Text)))
            {
                MessageBox.Show(@"原始分隔符和目标分隔符不能为空", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox分隔符转换.Checked && comboBox原始分隔符.Text == comboBox目标分隔符.Text)
            {
                MessageBox.Show(@"原始分隔符和目标分隔符相同，不需要转换", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var arrayList = new ArrayList();

            if (checkBox分隔符转换.Checked && string.IsNullOrWhiteSpace(textBoxSpliteString.Text))
            {
                arrayList.Add(int.MaxValue.ToString());
            }
            else
            {
                //要判断拆分数据合法性
                var strArray = textBoxSpliteString.Text.Trim(',').Split(',');

                //验证非零的正整数
                Regex regex = new Regex("^\\+?[1-9][0-9]*$");
                foreach (string s in strArray)
                {
                    if (!regex.IsMatch(s))
                    {
                        MessageBox.Show(@"拆分计划不规范，请检查", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                arrayList.AddRange(strArray);
            }


            //var fileSuffix = 0;


            //foreach (string s in strArray)
            //{
            //    var i = int.Parse(s);

            //}

            //检查是否需要分隔符转换
            CheckDelimiterConversion();

            var list = new List<string>();
            var no = 0;
            //批次标识,防止多次制作，产生意外，比如，第一次测试做了三个分段，而第二次测试做了二个分段！那么第一次的第三个文件，如果没有批准标识，则会容易让人造成失误！
            var batchId = DateTime.Now.ToString("yyyyMMdd-HHmmss");

            using (var fie = File.OpenRead(ucSingleFileSelect1.SelectedPath))
            using (var reader = new StreamReader(fie))
            {
                var large = Convert.ToInt32(arrayList[0]);
                //扫尾
                var windUp = false;
                while (!reader.EndOfStream)
                {
                    var s = reader.ReadLine();
                    //dx:这里要加入判断是插入空间的判断参数!
                    //今后，可以做一个是否为空的参数设置
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        list.Add(DelimiterConversion(s));
                    }

                    //dx:当正好=large时，写入一个文件，并且重置list
                    if (!windUp && list.Count >= large)
                    {
                        list = WriteLinesToFile(list, no, batchId);

                        if (arrayList.Count == ++no)
                        {
                            //最后未定义的数量,全部扫尾
                            windUp = true;
                        }
                        else
                        {
                            //no已经++了！
                            large = Convert.ToInt32(arrayList[no]);
                        }
                    }
                }
            }

            //收尾的部分
            if (list.Count > 0)
            {
                WriteLinesToFile(list, no, batchId);
            }


            //返回值和自身的变化的值，有两个概念
            //int n = 1;
            //int x = n++; // x will be 1 and n will be 2

            //int n = 1;
            //int x = ++n; // both x and n will be 2

            MessageBox.Show(@"拆分完成", @"信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<string> WriteLinesToFile(List<string> list, int no, string batchId)
        {
            //no是从0开始的，转成从1开始
            var shortFile = string.Format(textBoxFileNameTemplate.Text, $"({batchId})({no+1})(N{list.Count})");
            var fullFileName = Path.Combine(ucSingleFolderSelect1.SelectedPath, shortFile);
            if (string.IsNullOrWhiteSpace(comboBox文本编码.Text))
            {
                //https://learn.microsoft.com/zh-cn/dotnet/api/system.io.file.writealllines?view=net-7.0
                //此方法的默认行为 WriteAllLines(String, IEnumerable<String>) 是使用 utf-8 编码而不使用字节顺序标记 (BOM) 来写出数据。
                //如果需要在文件的开头包含 UTF-8 标识符，如字节顺序标记，请将 WriteAllLines(String, IEnumerable<String>, Encoding) 方法重载用于 UTF8 编码。
                File.WriteAllLines(fullFileName, list);
            }
            else
            {
                File.WriteAllLines(fullFileName, list, Encoding.GetEncoding(comboBox文本编码.Text));
            }

            list = new List<string>();
            return list;
        }

        ///// <summary>
        ///// 关注性能问题
        ///// 因每次转换都是重新求值，观察性能问题
        ///// </summary>
        ///// <param name="originalStr"></param>
        ///// <returns></returns>
        //string DelimiterConversion(string originalStr)
        //{
        //    var delimiterList = new List<KeyValuePair<string, string>>()
        //    {
        //        new KeyValuePair<string, string>("一空格", " "),
        //        new KeyValuePair<string, string>("四空格", "    "),
        //        new KeyValuePair<string, string>("一分号", ";")
        //    };

        //    var originalDelimiterChar = delimiterList.FirstOrDefault(o => o.Key == comboBox原始分隔符.Text).Value;
        //    var targetDelimiterChar = delimiterList.FirstOrDefault(o => o.Key == comboBox目标分隔符.Text).Value;

        //    var replace = originalStr.Replace(originalDelimiterChar, targetDelimiterChar);

        //    return replace;
        //}

        //用一个不可能重复的字符设置原始分隔符，防止意外替换
        private string _originalDelimiterChar = "31A533B7-2231-4137-A05B-AA3CD571FEEB";
        private string _targetDelimiterChar = "";
        bool isDelimiterConversion = false;

        void GetDelimiter()
        {
            var delimiterList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("一空格", " "),
                new KeyValuePair<string, string>("四空格", "    "),
                new KeyValuePair<string, string>("一分号", ";"),
                new KeyValuePair<string, string>("一逗号", ",")
            };

            _originalDelimiterChar = delimiterList.FirstOrDefault(o => o.Key == comboBox原始分隔符.Text).Value;
            _targetDelimiterChar = delimiterList.FirstOrDefault(o => o.Key == comboBox目标分隔符.Text).Value;
        }

        string DelimiterConversion(string originalStr)
        {
            if (!isDelimiterConversion)
            {
                //直接返回字符
                return originalStr;
            }
            var replace = originalStr.Replace(_originalDelimiterChar, _targetDelimiterChar);
            return replace;
        }

        void CheckDelimiterConversion()
        {
            if (checkBox分隔符转换.Checked)
            {
                isDelimiterConversion = true;
                GetDelimiter();
            }
        }

        private void button关于_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog(this);
        }

        private void comboBox原始分隔符_TextChanged(object sender, EventArgs e)
        {
            AfterFileSelected(ucSingleFileSelect1.SelectedPath);
        }

        private void comboBox目标分隔符_TextChanged(object sender, EventArgs e)
        {
            AfterFileSelected(ucSingleFileSelect1.SelectedPath);
        }

        private void checkBox分隔符转换_CheckedChanged(object sender, EventArgs e)
        {
            AfterFileSelected(ucSingleFileSelect1.SelectedPath);
        }
    }
}