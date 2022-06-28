using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TextFileProcessingEasy.MyControl
{
    [Serializable]
    public partial class UcSingleFileSelect : UserControl
    {
        [Browsable(true)]
        [Description("显示文件选择按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowSelectButton
        {
            get => button选择.Visible;
            set => button选择.Visible = value;
        }

        [Browsable(true)]
        [Description("显示文件打开按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowOpenButton
        {
            get => button打开.Visible;
            set => button打开.Visible = value;
        }

        [Browsable(true)]
        [Description("可以拖动"), Category("自定义属性组"), DefaultValue(true)]
        public bool CanDragDrop { get; set; } = true;

        [Browsable(true)]
        [Description("选择的文件"), Category("自定义属性组"), DefaultValue("")]
        public string SelectedPath
        {
            get => textBox文件.Text;

            set => textBox文件.Text = value;
        }

        //fileDialog.Title = @"请选择文件";
        //fileDialog.Filter = @"所有文件(*.*)|*.*";
        [Browsable(true)]
        [Description("fileDialog.Title"), Category("自定义属性组"), DefaultValue("请选择文件")]
        public string FileDialogTitle { get; set; } //= "请选择文件";

        [Browsable(true)]
        [Description("fileDialog.Filter"), Category("自定义属性组"), DefaultValue("所有文件(*.*)|*.*")]
        public string FileDialogFilter { get; set; } //= "所有文件(*.*)|*.*";

        public Func<string, bool> FuncSelected;

        public UcSingleFileSelect()
        {
            InitializeComponent();

            if (CanDragDrop)
            {
                textBox文件.AllowDrop = true;
                textBox文件.DragDrop += TextBox_DragDrop;
                textBox文件.DragEnter += TextBox_DragEnter;
            }
        }

        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                //其中 label1.Text显示的就是拖进文件的文件名；
                //label1.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

                //string text = File.ReadAllText(
                //    Path.Combine(Environment.CurrentDirectory, file[0]));

                if (files.Length > 1)
                {
                    //QuickShowMessage.ShowWarning("只能选择一个文件", this);
                    MessageBox.Show(@"只能选择一个文件", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var file = files[0];

                if (!CheckIsFile(file)) return;

                if (FuncSelected != null)
                {
                    if (!FuncSelected(file))
                    {
                        return;
                    }
                }

                textBox文件.Text = file;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CheckIsFile(string file)
        {
            //要判断文件是否存在(之所以判断，是有可能是一个文件夹)
            if (!File.Exists(file))
            {
                MessageBox.Show(@"请选择文件", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void button选择_Click(object sender, EventArgs e)
        {
            //C# 之 OpenFileDialog的使用 https://www.cnblogs.com/xinaixia/p/4861502.html
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                //非多选
                Multiselect = false,
                Title = FileDialogTitle,
                Filter = FileDialogFilter,
                CheckFileExists = true,
                RestoreDirectory = true,
                FilterIndex = 1
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //这是多选
                // //openFileDialog.FileNames 获取对话框中所有选定文件的文件名（String 类型数组），为绝对路径，类似"E:\\code\\123.xml"

                //string[] names = fileDialog.FileNames;
                ////foreach (string file in names)
                ////{
                ////    MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////}

                //if (CheckIsFile(names)) return;

                //if (FuncSelected != null && !FuncSelected.Invoke(names))
                //{
                //    return;
                //}

                string file = fileDialog.FileName;

                if (FuncSelected != null)
                {
                    if (!FuncSelected(file))
                    {
                        return;
                    }
                }

                textBox文件.Text = file;
            }
        }

        private void button打开_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox文件.Text) || !File.Exists(textBox文件.Text))
            {
                MessageBox.Show(@"当前文件不存在，请检查", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process.Start(textBox文件.Text);
        }
    }
}