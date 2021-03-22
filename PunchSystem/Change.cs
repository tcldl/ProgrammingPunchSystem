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
    public partial class Change : Form
    {
        private string oldpassword, password, newpassword1, newpassword2, prove;
        public string number { get; set; }

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

        public Change()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            password = textBox_oldpassword.Text;
            newpassword1 = textBox_newpassword.Text;
            newpassword2 = textBox_confirenewpassword.Text;
            prove = textBox_prove.Text;


            if (password.Length == 0)
            {
                MessageBox.Show(" 请输入原密码!", "编程打卡系统");
            }
            else if (newpassword1.Length == 0)
            {
                MessageBox.Show(" 请输入密码!", "编程打卡系统");
            }
            else if (prove.Length == 0)
            {
                MessageBox.Show(" 请输入验证码!", "编程打卡系统");
            }
            else if (string.Equals(newpassword1, newpassword2) == false)
            {
                MessageBox.Show(" 两次输入的密码不一致!", "编程打卡系统");
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
                    string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                    MySqlConnection conn = new MySqlConnection(connectStr);
                    try
                    {
                        conn.Open();
                        string sql = " select stu_password from student where stu_number = '" + number + "' ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                        if (get.Read())
                        {
                            oldpassword = get[0].ToString();
                            get.Close();
                        }

                        if (string.Equals(password, oldpassword) == false)
                        {
                            MessageBox.Show("原密码错误!", "编程打卡系统");
                        }
                        else
                        {
                            string sql1 = " update student set stu_password='" + newpassword1 + "' where stu_number='" + number + "' ";
                            using (MySqlCommand cmd2 = new MySqlCommand(sql1, conn))
                            {
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("修改成功,请重新登录!", "编程打卡系统");
                                System.Environment.Exit(0);
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

        ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers);

        private void picValidCode_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }

        private void Change_Load(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            Win32Utility.SetCueText(textBox_oldpassword, "请输入旧密码");
            Win32Utility.SetCueText(textBox_newpassword, "请输入新密码");
            Win32Utility.SetCueText(textBox_confirenewpassword, "请再次输入新密码");
            Win32Utility.SetCueText(textBox_prove, "请输入验证码");
        }
    }
}
