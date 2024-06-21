namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox_Encoding = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox_hex = new TextBox();
            textBox_string = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1094, 706);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1086, 676);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "字符串";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox_Encoding);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_hex);
            groupBox1.Controls.Add(textBox_string);
            groupBox1.Location = new Point(8, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 180);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hex&String";
            // 
            // button1
            // 
            button1.Location = new Point(347, 13);
            button1.Name = "button1";
            button1.Size = new Size(115, 26);
            button1.TabIndex = 5;
            button1.Text = "清除";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox_Encoding
            // 
            comboBox_Encoding.FormattingEnabled = true;
            comboBox_Encoding.Items.AddRange(new object[] { "UTF-8", "ASCII" });
            comboBox_Encoding.Location = new Point(203, 13);
            comboBox_Encoding.Name = "comboBox_Encoding";
            comboBox_Encoding.Size = new Size(133, 25);
            comboBox_Encoding.TabIndex = 5;
            comboBox_Encoding.Text = "UTF-8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 2;
            label1.Text = "Hex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 94);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 3;
            label2.Text = "String";
            // 
            // textBox_hex
            // 
            textBox_hex.Location = new Point(6, 45);
            textBox_hex.Multiline = true;
            textBox_hex.Name = "textBox_hex";
            textBox_hex.Size = new Size(456, 46);
            textBox_hex.TabIndex = 0;
            textBox_hex.TextChanged += textBox_hex_TextChanged;
            textBox_hex.MouseDoubleClick += textBox_hex_MouseDoubleClick;
            // 
            // textBox_string
            // 
            textBox_string.Location = new Point(6, 114);
            textBox_string.Multiline = true;
            textBox_string.Name = "textBox_string";
            textBox_string.Size = new Size(456, 46);
            textBox_string.TabIndex = 1;
            textBox_string.TextChanged += textBox_string_TextChanged;
            textBox_string.MouseDoubleClick += textBox_string_MouseDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1086, 676);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 706);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "tools";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox_Encoding;
        private Label label1;
        private Label label2;
        private TextBox textBox_hex;
        private TextBox textBox_string;
    }
}
