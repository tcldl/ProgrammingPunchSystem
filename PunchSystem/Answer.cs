using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PunchSystem
{
    public partial class Answer : Form
    {
        public string student_number { get; set; }
        public string student_question { get; set; }
        private string answer;

        public Answer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Answer_Load(object sender, EventArgs e)
        {

        }

        private void button_confirm_answer_Click(object sender, EventArgs e)
        {
            answer = richTextBox_answer.Text;
            if (answer.Length == 0)
                MessageBox.Show("请输入回复内容!", "编程打卡系统");
            else
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " update question set stu_answer='" + answer + "' where stu_number = '"+student_number+"' and stu_question = '"+student_question+"' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("提交成功!", "编程打卡系统");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Application.Exit();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
