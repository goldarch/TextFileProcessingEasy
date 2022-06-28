using TextFileProcessingEasy.MyControl;

namespace TextFileProcessingEasy
{
    partial class 行数量拆分计划
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(行数量拆分计划));
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSpliteString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileNameTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button拆分 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button关于 = new System.Windows.Forms.Button();
            this.ucSingleFileSelect1 = new TextFileProcessingEasy.MyControl.UcSingleFileSelect();
            this.label2 = new System.Windows.Forms.Label();
            this.ucSingleFolderSelect1 = new TextFileProcessingEasy.MyControl.UcSingleFolderSelect();
            this.comboBox文本编码 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "拆分计划(1000,10,2000,)";
            // 
            // textBoxSpliteString
            // 
            this.textBoxSpliteString.Location = new System.Drawing.Point(12, 68);
            this.textBoxSpliteString.Name = "textBoxSpliteString";
            this.textBoxSpliteString.Size = new System.Drawing.Size(650, 21);
            this.textBoxSpliteString.TabIndex = 38;
            this.textBoxSpliteString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "拆分后的名称为：\"输出名称头\"+\"_Splite\"+序号：文件名_Splite{0}.扩展名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "输出名称模板";
            // 
            // textBoxFileNameTemplate
            // 
            this.textBoxFileNameTemplate.Location = new System.Drawing.Point(12, 107);
            this.textBoxFileNameTemplate.Name = "textBoxFileNameTemplate";
            this.textBoxFileNameTemplate.Size = new System.Drawing.Size(650, 21);
            this.textBoxFileNameTemplate.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "请选择文件（或拖动文件到输入框）：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button拆分
            // 
            this.button拆分.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button拆分.Location = new System.Drawing.Point(659, 7);
            this.button拆分.Name = "button拆分";
            this.button拆分.Size = new System.Drawing.Size(57, 23);
            this.button拆分.TabIndex = 45;
            this.button拆分.Text = "拆分";
            this.button拆分.UseVisualStyleBackColor = false;
            this.button拆分.Click += new System.EventHandler(this.button拆分_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button关于);
            this.panel1.Controls.Add(this.button拆分);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 38);
            this.panel1.TabIndex = 47;
            // 
            // button关于
            // 
            this.button关于.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button关于.Image = global::TextFileProcessingEasy.Properties.Resources.About;
            this.button关于.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button关于.Location = new System.Drawing.Point(9, 7);
            this.button关于.Name = "button关于";
            this.button关于.Size = new System.Drawing.Size(81, 23);
            this.button关于.TabIndex = 46;
            this.button关于.Text = "关于";
            this.button关于.UseVisualStyleBackColor = false;
            this.button关于.Click += new System.EventHandler(this.button关于_Click);
            // 
            // ucSingleFileSelect1
            // 
            this.ucSingleFileSelect1.FileDialogFilter = null;
            this.ucSingleFileSelect1.FileDialogTitle = null;
            this.ucSingleFileSelect1.Location = new System.Drawing.Point(12, 24);
            this.ucSingleFileSelect1.Name = "ucSingleFileSelect1";
            this.ucSingleFileSelect1.Size = new System.Drawing.Size(700, 22);
            this.ucSingleFileSelect1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "输出目录（可选择目录或拖动目标目录到输入框）";
            // 
            // ucSingleFolderSelect1
            // 
            this.ucSingleFolderSelect1.Location = new System.Drawing.Point(12, 170);
            this.ucSingleFolderSelect1.Name = "ucSingleFolderSelect1";
            this.ucSingleFolderSelect1.SelectedPath = "";
            this.ucSingleFolderSelect1.Size = new System.Drawing.Size(700, 22);
            this.ucSingleFolderSelect1.TabIndex = 49;
            // 
            // comboBox文本编码
            // 
            this.comboBox文本编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox文本编码.FormattingEnabled = true;
            this.comboBox文本编码.Items.AddRange(new object[] {
            "",
            "UTF-8",
            "GB2312"});
            this.comboBox文本编码.Location = new System.Drawing.Point(12, 210);
            this.comboBox文本编码.Name = "comboBox文本编码";
            this.comboBox文本编码.Size = new System.Drawing.Size(121, 20);
            this.comboBox文本编码.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "文本编码";
            // 
            // 行数量拆分计划
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox文本编码);
            this.Controls.Add(this.ucSingleFolderSelect1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSingleFileSelect1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileNameTemplate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSpliteString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "行数量拆分计划";
            this.Text = "行数量拆分计划 -- GoldArch 金软架构";
            this.Load += new System.EventHandler(this.拆分行数计划_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSpliteString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileNameTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button拆分;
        private UcSingleFileSelect ucSingleFileSelect1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private UcSingleFolderSelect ucSingleFolderSelect1;
        private System.Windows.Forms.ComboBox comboBox文本编码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button关于;
    }
}