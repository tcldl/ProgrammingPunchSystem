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
    public partial class ManagerFind : Form
    {
        public string manager_number { get; set; }
        private string username, password, confirm, code, oldpassword;

        ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers);

        private void picValidCode1_Click(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
        }

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

        public ManagerFind()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ManagerFind_Load(object sender, EventArgs e)
        {
            picValidCode1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            Win32Utility.SetCueText(textBox_changemanagerusername, "请输入用户名");
            Win32Utility.SetCueText(textBox_changemanagerpassword, "请输入新密码");
            Win32Utility.SetCueText(textBox_changemanagerconfirm, "请再次输入新密码");
            Win32Utility.SetCueText(textBox_changemanagercode, "请输入验证码");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox_changemanagerusername.Text;
            password = textBox_changemanagerpassword.Text;
            confirm = textBox_changemanagerconfirm.Text;
            code = textBox_changemanagercode.Text;

            if(username.Length == 0)
                MessageBox.Show("请输入原密码!", "编程打卡系统");
            else if (password.Length == 0)
                MessageBox.Show("请输入新密码!", "编程打卡系统");
            else if (confirm.Length == 0)
                MessageBox.Show("请输入确认密码!", "编程打卡系统");
            else if (string.Equals(password, confirm) == false)
                MessageBox.Show("输入两次密码不一致!", "编程打卡系统");
            else if(code.Length == 0)
                MessageBox.Show("请输入验证码!", "编程打卡系统");
            else
            {
                if (!this.textBox_changemanagercode.Text.Equals(validCode.CheckCode))//验证是否输入正确
                {

                    MessageBox.Show(" 请输入正确的验证码!", this.Text);
                    picValidCode1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
                    this.textBox_changemanagercode.Focus();
                    this.textBox_changemanagercode.Text = "";

                    return;

                }
                else
                {
                    string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                    MySqlConnection conn = new MySqlConnection(connectStr);
                    try
                    {
                        conn.Open();
                        string sql = " select admin_password from admin where admin_number = '" + manager_number + "' ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                        if (get.Read())
                        {
                            oldpassword = get[0].ToString();
                            get.Close();
                        }

                        if (string.Equals(username, oldpassword) == false)
                        {
                            MessageBox.Show("原密码错误!", "编程打卡系统");
                        }
                        else
                        {
                            string sql1 = " update admin set admin_password='" + password + "' where admin_number='" + manager_number + "' ";
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
    }
}
