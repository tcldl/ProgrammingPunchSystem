namespace PunchSystem
{
    partial class Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change));
            this.textBox_prove = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.button_change = new System.Windows.Forms.Button();
            this.textBox_confirenewpassword = new System.Windows.Forms.TextBox();
            this.textBox_newpassword = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_oldpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_prove
            // 
            this.textBox_prove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prove.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_prove.Location = new System.Drawing.Point(385, 574);
            this.textBox_prove.Name = "textBox_prove";
            this.textBox_prove.Size = new System.Drawing.Size(269, 44);
            this.textBox_prove.TabIndex = 3;
            // 
            // picValidCode
            // 
            this.picValidCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picValidCode.BackColor = System.Drawing.Color.Transparent;
            this.picValidCode.Location = new System.Drawing.Point(651, 576);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(150, 50);
            this.picValidCode.TabIndex = 19;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // button_change
            // 
            this.button_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_change.BackColor = System.Drawing.Color.BurlyWood;
            this.button_change.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_change.Location = new System.Drawing.Point(385, 657);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(400, 60);
            this.button_change.TabIndex = 4;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // textBox_confirenewpassword
            // 
            this.textBox_confirenewpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_confirenewpassword.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_confirenewpassword.Location = new System.Drawing.Point(385, 489);
            this.textBox_confirenewpassword.Name = "textBox_confirenewpassword";
            this.textBox_confirenewpassword.Size = new System.Drawing.Size(400, 44);
            this.textBox_confirenewpassword.TabIndex = 2;
            this.textBox_confirenewpassword.UseSystemPasswordChar = true;
            // 
            // textBox_newpassword
            // 
            this.textBox_newpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_newpassword.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_newpassword.Location = new System.Drawing.Point(385, 405);
            this.textBox_newpassword.Name = "textBox_newpassword";
            this.textBox_newpassword.Size = new System.Drawing.Size(400, 44);
            this.textBox_newpassword.TabIndex = 1;
            this.textBox_newpassword.UseSystemPasswordChar = true;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("方正粗黑宋简体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_title.Location = new System.Drawing.Point(397, 138);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(380, 103);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "信息修改";
            // 
            // textBox_oldpassword
            // 
            this.textBox_oldpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_oldpassword.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_oldpassword.Location = new System.Drawing.Point(385, 324);
            this.textBox_oldpassword.Name = "textBox_oldpassword";
            this.textBox_oldpassword.Size = new System.Drawing.Size(400, 44);
            this.textBox_oldpassword.TabIndex = 0;
            this.textBox_oldpassword.UseSystemPasswordChar = true;
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.textBox_oldpassword);
            this.Controls.Add(this.textBox_prove);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_confirenewpassword);
            this.Controls.Add(this.textBox_newpassword);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.Name = "Change";
            this.Text = "编程打卡系统";
            this.Load += new System.EventHandler(this.Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_prove;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.TextBox textBox_confirenewpassword;
        private System.Windows.Forms.TextBox textBox_newpassword;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_oldpassword;
    }
}