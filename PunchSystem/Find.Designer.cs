namespace PunchSystem
{
    partial class Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.label_title = new System.Windows.Forms.Label();
            this.picValidCode1 = new System.Windows.Forms.PictureBox();
            this.textBox_prove = new System.Windows.Forms.TextBox();
            this.textBox_confirm = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.radioButton_findstu = new System.Windows.Forms.RadioButton();
            this.radioButton_findadmin = new System.Windows.Forms.RadioButton();
            this.textBox_postname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("方正粗黑宋简体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_title.Location = new System.Drawing.Point(395, 136);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(380, 103);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "密码找回";
            // 
            // picValidCode1
            // 
            this.picValidCode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picValidCode1.BackColor = System.Drawing.Color.Transparent;
            this.picValidCode1.Location = new System.Drawing.Point(648, 584);
            this.picValidCode1.Name = "picValidCode1";
            this.picValidCode1.Size = new System.Drawing.Size(140, 42);
            this.picValidCode1.TabIndex = 18;
            this.picValidCode1.TabStop = false;
            this.picValidCode1.Click += new System.EventHandler(this.picValidCode1_Click);
            // 
            // textBox_prove
            // 
            this.textBox_prove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prove.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_prove.Location = new System.Drawing.Point(384, 581);
            this.textBox_prove.Name = "textBox_prove";
            this.textBox_prove.Size = new System.Drawing.Size(260, 44);
            this.textBox_prove.TabIndex = 5;
            // 
            // textBox_confirm
            // 
            this.textBox_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_confirm.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_confirm.Location = new System.Drawing.Point(384, 511);
            this.textBox_confirm.Name = "textBox_confirm";
            this.textBox_confirm.Size = new System.Drawing.Size(400, 44);
            this.textBox_confirm.TabIndex = 4;
            this.textBox_confirm.UseSystemPasswordChar = true;
            // 
            // button_find
            // 
            this.button_find.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_find.BackColor = System.Drawing.Color.BurlyWood;
            this.button_find.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_find.Location = new System.Drawing.Point(384, 688);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(400, 60);
            this.button_find.TabIndex = 0;
            this.button_find.Text = "立即找回";
            this.button_find.UseVisualStyleBackColor = false;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(384, 439);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(400, 44);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_username.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(384, 298);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(400, 44);
            this.textBox_username.TabIndex = 1;
            // 
            // radioButton_findstu
            // 
            this.radioButton_findstu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_findstu.AutoSize = true;
            this.radioButton_findstu.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_findstu.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_findstu.ForeColor = System.Drawing.Color.White;
            this.radioButton_findstu.Location = new System.Drawing.Point(475, 642);
            this.radioButton_findstu.Name = "radioButton_findstu";
            this.radioButton_findstu.Size = new System.Drawing.Size(93, 32);
            this.radioButton_findstu.TabIndex = 6;
            this.radioButton_findstu.TabStop = true;
            this.radioButton_findstu.Text = "学生";
            this.radioButton_findstu.UseVisualStyleBackColor = false;
            // 
            // radioButton_findadmin
            // 
            this.radioButton_findadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_findadmin.AutoSize = true;
            this.radioButton_findadmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_findadmin.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_findadmin.ForeColor = System.Drawing.Color.White;
            this.radioButton_findadmin.Location = new System.Drawing.Point(603, 642);
            this.radioButton_findadmin.Name = "radioButton_findadmin";
            this.radioButton_findadmin.Size = new System.Drawing.Size(121, 32);
            this.radioButton_findadmin.TabIndex = 7;
            this.radioButton_findadmin.TabStop = true;
            this.radioButton_findadmin.Text = "管理员";
            this.radioButton_findadmin.UseVisualStyleBackColor = false;
            // 
            // textBox_postname
            // 
            this.textBox_postname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_postname.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_postname.Location = new System.Drawing.Point(384, 369);
            this.textBox_postname.Name = "textBox_postname";
            this.textBox_postname.Size = new System.Drawing.Size(400, 44);
            this.textBox_postname.TabIndex = 2;
            this.textBox_postname.TextChanged += new System.EventHandler(this.textBox_postname_TextChanged);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.textBox_postname);
            this.Controls.Add(this.radioButton_findadmin);
            this.Controls.Add(this.radioButton_findstu);
            this.Controls.Add(this.picValidCode1);
            this.Controls.Add(this.textBox_prove);
            this.Controls.Add(this.textBox_confirm);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.Name = "Find";
            this.Text = "编程打卡系统";
            this.Load += new System.EventHandler(this.Find_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox picValidCode1;
        private System.Windows.Forms.TextBox textBox_prove;
        private System.Windows.Forms.TextBox textBox_confirm;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.RadioButton radioButton_findstu;
        private System.Windows.Forms.RadioButton radioButton_findadmin;
        private System.Windows.Forms.TextBox textBox_postname;
    }
}