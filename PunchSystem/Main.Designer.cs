namespace PunchSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label_title = new System.Windows.Forms.Label();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_manager = new System.Windows.Forms.RadioButton();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.textBox_prove = new System.Windows.Forms.TextBox();
            this.button_forget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("方正粗黑宋简体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_title.Location = new System.Drawing.Point(312, 134);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(548, 103);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "编程打卡系统";
            // 
            // radioButton_user
            // 
            this.radioButton_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_user.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_user.ForeColor = System.Drawing.Color.White;
            this.radioButton_user.Location = new System.Drawing.Point(473, 594);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(93, 32);
            this.radioButton_user.TabIndex = 6;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "学生";
            this.radioButton_user.UseVisualStyleBackColor = false;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // radioButton_manager
            // 
            this.radioButton_manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_manager.AutoSize = true;
            this.radioButton_manager.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_manager.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_manager.ForeColor = System.Drawing.Color.White;
            this.radioButton_manager.Location = new System.Drawing.Point(606, 594);
            this.radioButton_manager.Name = "radioButton_manager";
            this.radioButton_manager.Size = new System.Drawing.Size(121, 32);
            this.radioButton_manager.TabIndex = 7;
            this.radioButton_manager.TabStop = true;
            this.radioButton_manager.Text = "管理员";
            this.radioButton_manager.UseVisualStyleBackColor = false;
            this.radioButton_manager.CheckedChanged += new System.EventHandler(this.radioButton_manager_CheckedChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_username.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(391, 397);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(400, 44);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(391, 456);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(400, 44);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login.BackColor = System.Drawing.Color.BurlyWood;
            this.button_login.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(391, 648);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(400, 60);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // picValidCode
            // 
            this.picValidCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picValidCode.BackColor = System.Drawing.Color.Transparent;
            this.picValidCode.Location = new System.Drawing.Point(656, 517);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(150, 50);
            this.picValidCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picValidCode.TabIndex = 7;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // textBox_prove
            // 
            this.textBox_prove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prove.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_prove.Location = new System.Drawing.Point(391, 516);
            this.textBox_prove.Name = "textBox_prove";
            this.textBox_prove.Size = new System.Drawing.Size(264, 44);
            this.textBox_prove.TabIndex = 5;
            // 
            // button_forget
            // 
            this.button_forget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_forget.BackColor = System.Drawing.Color.Transparent;
            this.button_forget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_forget.FlatAppearance.BorderSize = 0;
            this.button_forget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_forget.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_forget.ForeColor = System.Drawing.Color.White;
            this.button_forget.Location = new System.Drawing.Point(641, 724);
            this.button_forget.Name = "button_forget";
            this.button_forget.Size = new System.Drawing.Size(150, 40);
            this.button_forget.TabIndex = 2;
            this.button_forget.Text = "忘记密码";
            this.button_forget.UseVisualStyleBackColor = false;
            this.button_forget.Click += new System.EventHandler(this.button_forget_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "与大家分享你的程序、经验和理解";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_register
            // 
            this.button_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_register.BackColor = System.Drawing.Color.Transparent;
            this.button_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.ForeColor = System.Drawing.Color.White;
            this.button_register.Location = new System.Drawing.Point(391, 724);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(150, 40);
            this.button_register.TabIndex = 8;
            this.button_register.Text = "用户注册";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_forget);
            this.Controls.Add(this.textBox_prove);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.radioButton_manager);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Main";
            this.Text = "编程打卡系统";
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_manager;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.TextBox textBox_prove;
        private System.Windows.Forms.Button button_forget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_register;
    }
}

