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
    public partial class Main : Form
    {
        private Register register;
        private Find find;
        private Student student;
        private Manager manager;
        private string number, password, prove;

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

        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers);


        private void button_register_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.ShowDialog();
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            number = textBox_username.Text;
            password = textBox_password.Text;
            prove = textBox_prove.Text;

            if (number.Length == 0)
            {
                MessageBox.Show(" 请输入用户名/学号!", "编程打卡系统");
            }
            else if(password.Length == 0)
            {
                MessageBox.Show(" 请输入密码!", "编程打卡系统");
            }
            else if(prove.Length == 0)
            {
                MessageBox.Show(" 请输入验证码!", "编程打卡系统");
            }
            else
            {
                if (!this.textBox_prove.Text.Equals(validCode.CheckCode))//验证是否输入正确
                {

                    MessageBox.Show(" 请输入正确的验证码!", this.Text);
                    picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                    this.textBox_prove.Focus();
                    this.textBox_prove.Text = "";
                    return;
                }
                else
                {
                    if (radioButton_user.Checked)
                    {
                        string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                        MySqlConnection conn = new MySqlConnection(connectStr);
                        try
                        {
                            conn.Open();
                            string sql = " select * from student where stu_number = '" + number + "' and stu_password = '"+password+"' ";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            MySqlDataReader getusername = cmd.ExecuteReader();  //getusername.Read()表示找到
                            if (getusername.Read())
                            {
                                student = new Student();
                                student.student_number = textBox_username.Text;
                                student.ShowDialog();
                                this.Close();
                                MessageBox.Show("登陆成功!", "编程打卡系统");
                                getusername.Close();
                            }
                            else
                            {
                                MessageBox.Show("用户名/学号或密码错误,请重新输入!", "编程打卡系统");
                                textBox_prove.Clear();
                                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//更换验证码
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
                    else if(radioButton_manager.Checked)
                    {
                        string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                        MySqlConnection conn = new MySqlConnection(connectStr);
                        try
                        {
                            conn.Open();
                            string sql = " select * from admin where admin_number = '" + number + "' and admin_password = '" + password + "' ";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            MySqlDataReader getmanagername = cmd.ExecuteReader();  //getusername.Read()表示找到
                            if (getmanagername.Read())
                            {
                                manager = new Manager();
                                manager.manager_number = textBox_username.Text;
                                manager.ShowDialog();
                                this.Close();
                                MessageBox.Show("登陆成功!", "编程打卡系统");
                                getmanagername.Close();
                            }
                            else
                            {
                                MessageBox.Show("用户名/学号或密码错误,请重新输入!", "编程打卡系统");
                                textBox_prove.Clear();
                                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//更换验证码
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
                        picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//更换验证码
                    }

                }
            }

        }

        private void radioButton_manager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            Win32Utility.SetCueText(textBox_username, "请输入用户名");
            Win32Utility.SetCueText(textBox_password, "请输入密码");
            Win32Utility.SetCueText(textBox_prove, "请输入验证码");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click_1(object sender, EventArgs e)
        {
            register = new Register();
            register.ShowDialog();
        }

        private void picValidCode_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//更换验证码
        }
                                                                               
        private void button_forget_Click(object sender, EventArgs e)
        {
            find = new Find();
            find.ShowDialog();
        }

    }
}
