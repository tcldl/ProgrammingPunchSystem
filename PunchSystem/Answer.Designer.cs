namespace PunchSystem
{
    partial class Answer
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
            this.button_confirm_answer = new System.Windows.Forms.Button();
            this.richTextBox_answer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_confirm_answer
            // 
            this.button_confirm_answer.Location = new System.Drawing.Point(339, 482);
            this.button_confirm_answer.Name = "button_confirm_answer";
            this.button_confirm_answer.Size = new System.Drawing.Size(100, 40);
            this.button_confirm_answer.TabIndex = 1;
            this.button_confirm_answer.Text = "确认回复";
            this.button_confirm_answer.UseVisualStyleBackColor = true;
            this.button_confirm_answer.Click += new System.EventHandler(this.button_confirm_answer_Click);
            // 
            // richTextBox_answer
            // 
            this.richTextBox_answer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox_answer.Location = new System.Drawing.Point(12, 54);
            this.richTextBox_answer.Name = "richTextBox_answer";
            this.richTextBox_answer.Size = new System.Drawing.Size(754, 407);
            this.richTextBox_answer.TabIndex = 2;
            this.richTextBox_answer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "问题回复";
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_answer);
            this.Controls.Add(this.button_confirm_answer);
            this.Name = "Answer";
            this.Text = "编程打卡系统";
            this.Load += new System.EventHandler(this.Answer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_confirm_answer;
        private System.Windows.Forms.RichTextBox richTextBox_answer;
        private System.Windows.Forms.Label label1;
    }
}