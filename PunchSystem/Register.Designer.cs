namespace PunchSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_confirm = new System.Windows.Forms.TextBox();
            this.textBox_prove = new System.Windows.Forms.TextBox();
            this.picValidCode1 = new System.Windows.Forms.PictureBox();
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
            this.label_title.Location = new System.Drawing.Point(386, 144);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(380, 103);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "用户注册";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_name.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_name.Location = new System.Drawing.Point(374, 345);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(400, 44);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_username.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(374, 404);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(400, 44);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(374, 463);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(400, 44);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_register
            // 
            this.button_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_register.BackColor = System.Drawing.Color.BurlyWood;
            this.button_register.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.Location = new System.Drawing.Point(374, 654);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(400, 60);
            this.button_register.TabIndex = 0;
            this.button_register.Text = "立即注册";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_confirm
            // 
            this.textBox_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_confirm.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_confirm.Location = new System.Drawing.Point(374, 522);
            this.textBox_confirm.Name = "textBox_confirm";
            this.textBox_confirm.Size = new System.Drawing.Size(400, 44);
            this.textBox_confirm.TabIndex = 4;
            this.textBox_confirm.UseSystemPasswordChar = true;
            // 
            // textBox_prove
            // 
            this.textBox_prove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prove.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_prove.Location = new System.Drawing.Point(374, 582);
            this.textBox_prove.Name = "textBox_prove";
            this.textBox_prove.Size = new System.Drawing.Size(261, 44);
            this.textBox_prove.TabIndex = 5;
            // 
            // picValidCode1
            // 
            this.picValidCode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picValidCode1.BackColor = System.Drawing.Color.Transparent;
            this.picValidCode1.Location = new System.Drawing.Point(637, 584);
            this.picValidCode1.Name = "picValidCode1";
            this.picValidCode1.Size = new System.Drawing.Size(140, 44);
            this.picValidCode1.TabIndex = 6;
            this.picValidCode1.TabStop = false;
            this.picValidCode1.Click += new System.EventHandler(this.picValidCode1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.picValidCode1);
            this.Controls.Add(this.textBox_prove);
            this.Controls.Add(this.textBox_confirm);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.Text = "编程打卡系统";
            this.Load += new System.EventHandler(this.Register_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_confirm;
        private System.Windows.Forms.TextBox textBox_prove;
        private System.Windows.Forms.PictureBox picValidCode1;
    }
}