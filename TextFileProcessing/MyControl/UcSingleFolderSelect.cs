using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace TextFileProcessingEasy.MyControl
{
    [Serializable]
    public partial class UcSingleFolderSelect : UserControl
    {
        [Browsable(true)]
        [Description("显示目录选择按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowSelectButton
        {
            get => button选择.Visible;
            set => button选择.Visible = value;
        }

        [Browsable(true)]
        [Description("显示目录打开按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowOpenButton
        {
            get => button打开.Visible;
            set => button打开.Visible = value;
        }

        [Browsable(true)]
        [Description("可以拖动"), Category("自定义属性组"), DefaultValue(true)]
        public bool CanDragDrop { get; set; } = true;

        [Browsable(true)]
        [Description("选择的文件夹"), Category("自定义属性组"), DefaultValue(true)]
        public string SelectedPath
        {
            get => textBox文件夹.Text;

            set => textBox文件夹.Text = value;
        }

        public Func<string, bool> FuncSelected;

        public UcSingleFolderSelect()
        {
            InitializeComponent();

            if (CanDragDrop)
            {
                textBox文件夹.AllowDrop = true;
                textBox文件夹.DragDrop += TextBox_DragDrop;
                textBox文件夹.DragEnter += TextBox_DragEnter;
            }
        }

        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
                //其中 label1.Text显示的就是拖进文件的文件名；
                //label1.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

                //string text = File.ReadAllText(
                //    Path.Combine(Environment.CurrentDirectory, file[0]));

                if (files.Length > 1)
                {
                    MessageBox.Show(@"选择了多个文件或文件夹");
                    return;
                }

                //win系统不会让文件夹和文件同名，比如不会有一个IO文件夹和一个名称去后缀为IO的文件!

                var dicText = Path.Combine(Environment.CurrentDirectory, files[0]);

                //要判断文件夹是否存在
                if (!Directory.Exists(dicText))
                {
                    MessageBox.Show(@"请选择文件夹");
                    return;
                }

                if (FuncSelected != null && !FuncSelected.Invoke(dicText))
                {
                    return;
                }


                ((TextBox) sender).Text = dicText;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void button选择_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {Description = @"请选择文件夹"};
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK ||
                folderBrowserDialog.ShowDialog() == DialogResult.Yes)
            {
                if (FuncSelected != null && !FuncSelected.Invoke(folderBrowserDialog.SelectedPath))
                {
                    return;
                }

                textBox文件夹.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button打开_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox文件夹.Text) || !Directory.Exists(textBox文件夹.Text))
            {
                MessageBox.Show("当前文件夹不存在，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                //Directory.CreateDirectory(textBox文件夹.Text);
            }

            System.Diagnostics.Process.Start("ExpLorer", textBox文件夹.Text);
        }
    }
}