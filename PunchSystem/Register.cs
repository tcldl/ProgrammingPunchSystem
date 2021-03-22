using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PunchSystem
{
    public partial class Register : Form
    {
        private string name1, number, password, confirm, prove;

        public static class Win32Utility
        {

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern Int32 SendMessage(IntPtr hWnd, int msg,
            int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

            [DllImport("user32.dll")]
            private static extern bool SendMessage(IntPtr hwnd, int msg, int wParam, StringBuilder lParam);

            [DllImport("user32.dll")]
            private static extern bool GetComboBoxInfo(IntPtr hwnd, ref COMBOBOXINFO pcbi);

            [StructLayout(LayoutKind.Sequential)]
            private struct COMBOBOXINFO
            {
                public int cbSize;
                public RECT rcItem;
                public RECT rcButton;
                public IntPtr stateButton;
                public IntPtr hwndCombo;
                public IntPtr hwndItem;
                public IntPtr hwndList;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct RECT
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            private const int EM_SETCUEBANNER = 0x1501;
            private const int EM_GETCUEBANNER = 0x1502;

            public static void SetCueText(Control control, string text)
            {
                if (control is ComboBox)
                {
                    COMBOBOXINFO info = GetComboBoxInfo(control);
                    SendMessage(info.hwndItem, EM_SETCUEBANNER, 0, text);
                }
                else
                {
                    SendMessage(control.Handle, EM_SETCUEBANNER, 0, text);
                }
            }

            private static COMBOBOXINFO GetComboBoxInfo(Control control)
            {
                COMBOBOXINFO info = new COMBOBOXINFO();
                //a combobox is made up of three controls, a button, a list and textbox;
                //we want the textbox
                info.cbSize = Marshal.SizeOf(info);
                GetComboBoxInfo(control.Handle, ref info);
                return info;
            }

            public static string GetCueText(Control control)
            {
                StringBuilder builder = new StringBuilder();
                if (control is ComboBox)
                {
                    COMBOBOXINFO info = new COMBOBOXINFO();
                    //a combobox is made up of two controls, a list and textbox;
                    //we want the textbox
                    info.cbSize = Marshal.SizeOf(info);
                    GetComboBoxInfo(control.Handle, ref info);
                    SendMessage(info.hwndItem, EM_GETCUEBANNER, 0, builder);
                }
                else
                {
                    SendMessage(control.Handle, EM_GETCUEBANNER, 0, builder);
                }
                return builder.ToString();
            }

        }

        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        ValidCode validCode1 = new ValidCode(5, ValidCode.CodeType.Numbers);

        private void picValidCode1_Click(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());//点击图片更换验证码
        }

        private void Register_Load_1(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
            Win32Utility.SetCueText(textBox_username, "请输入用户名");
            Win32Utility.SetCueText(textBox_password, "请输入密码");
            Win32Utility.SetCueText(textBox_prove, "请输入验证码");
            Win32Utility.SetCueText(textBox_name, "请输入姓名");
            Win32Utility.SetCueText(textBox_confirm, "请再次输入密码");
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            name1 = textBox_name.Text;
            number = textBox_username.Text;
            password = textBox_password.Text;
            confirm = textBox_confirm.Text;
            prove = textBox_prove.Text;

            if (name1.Length == 0)
            {
                MessageBox.Show("请输入姓名!", "编程打卡系统");
            }
            else if (number.Length == 0)
            {
                MessageBox.Show("请输入学号!", "编程打卡系统");
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("请输入密码!", "编程打卡系统");
            }
            else if(string.Equals(password,confirm) == false)
            {
                MessageBox.Show("输入两次密码不一致!", "编程打卡系统");
                textBox_password.Clear();
                textBox_confirm.Clear();
                textBox_prove.Clear();
                picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
            }
            else if(prove.Length == 0)
            {
                MessageBox.Show("请输入验证码!", "编程打卡系统");
            }
            else 
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " select * from student where stu_number='"+ number + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader getusername = cmd.ExecuteReader();  //getusername.Read()表示找到
                    if (getusername.Read())
                    {
                        MessageBox.Show("该学号已被注册,请重新输入!", "编程打卡系统");
                    }
                    else
                    {
                        getusername.Close();

                        if (!this.textBox_prove.Text.Equals(validCode1.CheckCode))//验证是否输入正确
                        {
                            MessageBox.Show("请输入正确的验证码!", "编程打卡系统");
                            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());

                            this.textBox_prove.Focus();
                            this.textBox_prove.Text = "";

                            return;

                        }
                        else
                        {
                            string sql1 = " insert into student(stu_id,stu_number,stu_name,stu_password,stu_days) values(NULL,'" + number + "','" + name1 + "','" + password + "','0') ";
                            using (MySqlCommand cmd2 = new MySqlCommand(sql1, conn))
                            {
                                cmd2.ExecuteNonQuery();

                            }
                            string sql2 = " insert into record(record_number,record_name,record_days) values('" + number + "','" + name1 + "','0') ";
                            using (MySqlCommand cmd3 = new MySqlCommand(sql2, conn))
                            {
                                cmd3.ExecuteNonQuery();

                            }

                            MessageBox.Show("恭喜你,注册成功!", "编程打卡系统");
                            this.Close();
                        }
          
                    }
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
