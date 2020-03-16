namespace CopyTest
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.skinListBox1 = new CCWin.SkinControl.SkinListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.登录 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Pwd = new CCWin.SkinControl.SkinTextBox();
            this.User = new CCWin.SkinControl.SkinTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(16, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "机型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "下载路径";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(112, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 17);
            this.textBox2.TabIndex = 5;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "E:\\0.HDT0000";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 21);
            this.button4.TabIndex = 10;
            this.button4.Text = "下载路径";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(112, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 17);
            this.textBox4.TabIndex = 9;
            // 
            // skinListBox1
            // 
            this.skinListBox1.Back = null;
            this.skinListBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinListBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skinListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinListBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.skinListBox1.FormattingEnabled = true;
            this.skinListBox1.Location = new System.Drawing.Point(8, 280);
            this.skinListBox1.MouseColor = System.Drawing.Color.White;
            this.skinListBox1.Name = "skinListBox1";
            this.skinListBox1.SelectedColor = System.Drawing.Color.Silver;
            this.skinListBox1.Size = new System.Drawing.Size(283, 69);
            this.skinListBox1.TabIndex = 76;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 22);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 登录
            // 
            this.登录.BackColor = System.Drawing.Color.Transparent;
            this.登录.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.登录.DownBack = null;
            this.登录.Location = new System.Drawing.Point(112, 104);
            this.登录.MouseBack = null;
            this.登录.Name = "登录";
            this.登录.NormlBack = null;
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 102;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = false;
            this.登录.Click += new System.EventHandler(this.登录_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel2.Location = new System.Drawing.Point(32, 72);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(35, 14);
            this.skinLabel2.TabIndex = 101;
            this.skinLabel2.Text = "密码";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel1.Location = new System.Drawing.Point(32, 32);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(35, 14);
            this.skinLabel1.TabIndex = 100;
            this.skinLabel1.Text = "用户";
            // 
            // Pwd
            // 
            this.Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Pwd.DownBack = null;
            this.Pwd.Icon = null;
            this.Pwd.IconIsButton = false;
            this.Pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.IsPasswordChat = '*';
            this.Pwd.IsSystemPasswordChar = false;
            this.Pwd.Lines = new string[0];
            this.Pwd.Location = new System.Drawing.Point(112, 64);
            this.Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.Pwd.MaxLength = 32767;
            this.Pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.Pwd.MouseBack = null;
            this.Pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.Multiline = false;
            this.Pwd.Name = "Pwd";
            this.Pwd.NormlBack = null;
            this.Pwd.Padding = new System.Windows.Forms.Padding(5);
            this.Pwd.ReadOnly = false;
            this.Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pwd.Size = new System.Drawing.Size(120, 28);
            // 
            // 
            // 
            this.Pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwd.SkinTxt.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Pwd.SkinTxt.Name = "BaseText";
            this.Pwd.SkinTxt.PasswordChar = '*';
            this.Pwd.SkinTxt.Size = new System.Drawing.Size(110, 17);
            this.Pwd.SkinTxt.TabIndex = 0;
            this.Pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.SkinTxt.WaterText = "";
            this.Pwd.TabIndex = 99;
            this.Pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.WaterText = "";
            this.Pwd.WordWrap = true;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.DownBack = null;
            this.User.Icon = null;
            this.User.IconIsButton = false;
            this.User.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.User.IsPasswordChat = '\0';
            this.User.IsSystemPasswordChar = false;
            this.User.Lines = new string[] {
        "mech\\ch"};
            this.User.Location = new System.Drawing.Point(112, 24);
            this.User.Margin = new System.Windows.Forms.Padding(0);
            this.User.MaxLength = 32767;
            this.User.MinimumSize = new System.Drawing.Size(28, 28);
            this.User.MouseBack = null;
            this.User.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.User.Multiline = false;
            this.User.Name = "User";
            this.User.NormlBack = null;
            this.User.Padding = new System.Windows.Forms.Padding(5);
            this.User.ReadOnly = false;
            this.User.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User.Size = new System.Drawing.Size(120, 28);
            // 
            // 
            // 
            this.User.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User.SkinTxt.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.User.SkinTxt.Name = "BaseText";
            this.User.SkinTxt.Size = new System.Drawing.Size(110, 17);
            this.User.SkinTxt.TabIndex = 0;
            this.User.SkinTxt.Text = "mech\\ch";
            this.User.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.User.SkinTxt.WaterText = "";
            this.User.TabIndex = 98;
            this.User.Text = "mech\\ch";
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.User.WaterText = "";
            this.User.WordWrap = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(200, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 103;
            this.button1.Text = "解压";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(306, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.User);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.skinListBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("標楷體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private CCWin.SkinControl.SkinListBox skinListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CCWin.SkinControl.SkinButton 登录;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox Pwd;
        private CCWin.SkinControl.SkinTextBox User;
        private System.Windows.Forms.Button button1;
    }
}

