
namespace TextFileProcessingEasy.MyControl
{
    partial class UcSingleFolderSelect
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox文件夹 = new System.Windows.Forms.TextBox();
            this.button选择 = new System.Windows.Forms.Button();
            this.button打开 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox文件夹
            // 
            this.textBox文件夹.BackColor = System.Drawing.SystemColors.Info;
            this.textBox文件夹.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox文件夹.Location = new System.Drawing.Point(0, 0);
            this.textBox文件夹.Margin = new System.Windows.Forms.Padding(4);
            this.textBox文件夹.Multiline = true;
            this.textBox文件夹.Name = "textBox文件夹";
            this.textBox文件夹.Size = new System.Drawing.Size(481, 22);
            this.textBox文件夹.TabIndex = 2;
            // 
            // button选择
            // 
            this.button选择.Dock = System.Windows.Forms.DockStyle.Right;
            this.button选择.Location = new System.Drawing.Point(481, 0);
            this.button选择.Name = "button选择";
            this.button选择.Size = new System.Drawing.Size(48, 22);
            this.button选择.TabIndex = 3;
            this.button选择.Text = "选择";
            this.button选择.UseVisualStyleBackColor = true;
            this.button选择.Click += new System.EventHandler(this.button选择_Click);
            // 
            // button打开
            // 
            this.button打开.Dock = System.Windows.Forms.DockStyle.Right;
            this.button打开.Location = new System.Drawing.Point(529, 0);
            this.button打开.Name = "button打开";
            this.button打开.Size = new System.Drawing.Size(48, 22);
            this.button打开.TabIndex = 16;
            this.button打开.Text = "打开";
            this.button打开.UseVisualStyleBackColor = true;
            this.button打开.Click += new System.EventHandler(this.button打开_Click);
            // 
            // UcSingleFolderSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox文件夹);
            this.Controls.Add(this.button选择);
            this.Controls.Add(this.button打开);
            this.Name = "UcSingleFolderSelect";
            this.Size = new System.Drawing.Size(577, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox文件夹;
        private System.Windows.Forms.Button button选择;
        private System.Windows.Forms.Button button打开;
    }
}
