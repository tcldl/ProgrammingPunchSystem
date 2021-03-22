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

    public partial class Find : Form
    {
        private string number, postname, password, confirm, prove;

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

        ValidCode validCode1 = new ValidCode(5, ValidCode.CodeType.Numbers);

        private void textBox_postname_TextChanged(object sender, EventArgs e)
        {

        }

        private void picValidCode1_Click(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());//点击图片更换验证码
        }

        public Find()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Find_Load_1(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
            Win32Utility.SetCueText(textBox_username, "请输入学号/用户名");
            Win32Utility.SetCueText(textBox_postname, "请输入身份证号");
            Win32Utility.SetCueText(textBox_password, "请输入新密码");
            Win32Utility.SetCueText(textBox_confirm, "请再次输入新密码");
            Win32Utility.SetCueText(textBox_prove, "请输入验证码");
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            number = textBox_username.Text;
            postname = textBox_postname.Text;
            password = textBox_password.Text;
            confirm = textBox_confirm.Text;
            prove = textBox_prove.Text;

            if (number.Length == 0)
            {
                MessageBox.Show("请输入用户名/学号!", "编程打卡系统");
            }
            else if (postname.Length == 0)
            {
                MessageBox.Show("请输入邮箱地址!", "编程打卡系统");
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("请输入密码!", "编程打卡系统");
            }
            else if (string.Equals(password, confirm) == false)
            {
                MessageBox.Show("输入两次密码不一致!", "编程打卡系统");
                textBox_password.Clear();
                textBox_confirm.Clear();
                textBox_prove.Clear();
                picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
            }
            else if (prove.Length == 0)
            {
                MessageBox.Show("请输入验证码!", "编程打卡系统");
            }
            else
            {
                if(radioButton_findstu.Checked)
                {
                    string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                    MySqlConnection conn = new MySqlConnection(connectStr);
                    try
                    {
                        conn.Open();
                        string sql = " select * from student where stu_number='" + number + "' and stu_idcard='"+postname+"' ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader getusername = cmd.ExecuteReader();  //getusername.Read()表示找到
                        if (!getusername.Read())
                        {
                            MessageBox.Show("输入信息有误,请重新输入!", "编程打卡系统");
                            textBox_password.Clear();
                            textBox_confirm.Clear();
                            textBox_prove.Clear();
                            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
                            getusername.Close();
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
                                string sql1 = " update student set stu_password = '" + password + "' where stu_number = '" + number + "' ";
                                using (MySqlCommand cmd2 = new MySqlCommand(sql1, conn))
                                {
                                    cmd2.ExecuteNonQuery();

                                }

                                MessageBox.Show("恭喜你,找回成功!", "编程打卡系统");
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
                else if(radioButton_findadmin.Checked)
                {
                    string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                    MySqlConnection conn = new MySqlConnection(connectStr);
                    try
                    {
                        conn.Open();
                        string sql = " select * from admin where admin_number='" + number + "' and admin_idcard='"+postname+"' ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader getusername = cmd.ExecuteReader();  //getusername.Read()表示找到
                        if (!getusername.Read())
                        {
                            MessageBox.Show("输入信息有误,请重新输入!", "编程打卡系统");
                            getusername.Close();
                            textBox_password.Clear();
                            textBox_confirm.Clear();
                            textBox_prove.Clear();
                            picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());
                        }
                        else
                        {
                            getusername.Close();

                            if (!this.textBox_prove.Text.Equals(validCode1.CheckCode))//验证是否输入正确
                            {
                                MessageBox.Show("请输入正确的验证码!", "编程打卡系统");

                                this.textBox_prove.Focus();
                                this.textBox_prove.Text = "";

                                return;

                            }
                            else
                            {
                                string sql1 = " update admin set admin_password = '" + password + "' where admin_number = '" + number + "' ";
                                using (MySqlCommand cmd2 = new MySqlCommand(sql1, conn))
                                {
                                    cmd2.ExecuteNonQuery();
                                }

                                MessageBox.Show("恭喜你,找回成功!", "编程打卡系统");
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
                else
                {
                    MessageBox.Show("请选择用户类型!", "编程打卡系统");
                    textBox_prove.Clear();
                    picValidCode1.Image = Bitmap.FromStream(validCode1.CreateCheckCodeImage());//更换验证码
                }
                
            }
        }
    }
}
