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
    public partial class Student : Form
    {
        string weekstr = "";
        private const int ITEM_PADDING = 8;
        public string student_number { get; set; }
        private string name, timestart, timestop, code, searchname, searchnumber, question;
        private int id;
        private double days;
        private Change change;

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

        public Student()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listBox1.DrawItem += ListBox1_DrawItem;
            listBox1.MeasureItem += ListBox1_MeasureItem;
        }

        private void tabControl_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            //获取TabControl主控件的工作区域
            Rectangle rec = tabControl.ClientRectangle;
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// 设置文字垂直方向居中
            StrFormat.Alignment = StringAlignment.Center;// 设置文字水平方向居中     
            SolidBrush bru = new SolidBrush(Color.White);
            SolidBrush bruFont = new SolidBrush(Color.Black);// 标签字体颜色
            Font font = new System.Drawing.Font("微软雅黑", 10F);//设置标签字体样式

            Brush bshBack;
            Brush bshFore;
            if (e.Index == this.tabControl.SelectedIndex) //当前Tab页的样式 
            {
                bshBack = new SolidBrush(Color.BurlyWood);
                bshFore = Brushes.Black;
                e.Graphics.FillRectangle(bshBack, e.Bounds);
                Rectangle recTab = e.Bounds;
                string tabName = this.tabControl.TabPages[e.Index].Text;
                e.Graphics.DrawString(tabName, font, bruFont, recTab, StrFormat);
            }
            else //其余Tab页的样式 
            {
                bshBack = new SolidBrush(Color.White);
                bshFore = new SolidBrush(Color.Black);
                string tabName = this.tabControl.TabPages[e.Index].Text;
                StringFormat sftTab = new StringFormat();
                e.Graphics.FillRectangle(bshBack, e.Bounds);
                Rectangle recTab = e.Bounds;
                e.Graphics.DrawString(tabName, font, bruFont, recTab, StrFormat);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            //显示时间姓名
            this.timer1.Start();
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": weekstr = "星期一"; break;
                case "Tuesday": weekstr = "星期二"; break;
                case "Wednesday": weekstr = "星期三"; break;
                case "Thursday": weekstr = "星期四"; break;
                case "Friday": weekstr = "星期五"; break;
                case "Saturday": weekstr = "星期六"; break;
                case "Sunday": weekstr = "星期日"; break;
            }

            Win32Utility.SetCueText(textBox_searchnumber, "输入查询学号");
            Win32Utility.SetCueText(textBox_searchname, "输入查询姓名");

            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            MySqlDataAdapter s1 = new MySqlDataAdapter("select * from question where stu_number = '" + student_number + "' ", conn);
            DataSet d1 = new DataSet();
            s1.Fill(d1, "t");
            dataGridView_get_answer.DataSource = d1.Tables["t"];

            try
            {
                conn.Open();
                string sql = " select stu_idcard from student where stu_number = '" + student_number + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                if (get.Read())
                {
                    textBox_stu_idcard.Text = get[0].ToString();
                    get.Close();
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

        private void button_change_Click(object sender, EventArgs e)
        {
            change = new Change();
            change.number = student_number;
            change.ShowDialog();
        }

        private void button_listclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            searchname = textBox_searchname.Text;
            searchnumber = textBox_searchnumber.Text;
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                string sql = null;
                if(searchname.Length == 0 && searchnumber.Length == 0)
                {
                    MessageBox.Show("请输入查询信息!", "编程打卡系统");
                }
                else if(searchname.Length == 0 && searchnumber.Length != 0)
                {
                    sql = " select stu_program,stu_datetime from program where stu_number like '%" + searchnumber + "%' and DATE_FORMAT(stu_datetime,'%Y-%m-%d') ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
                }
                else if(searchname.Length != 0 && searchnumber.Length == 0)
                {
                    sql = " select stu_program,stu_datetime from program where stu_name like '%" + searchname + "%' and DATE_FORMAT(stu_datetime,'%Y-%m-%d') ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
                }
                else if(searchname.Length != 0 && searchnumber.Length !=0 )
                {
                    sql = " select stu_program,stu_datetime from program where stu_name like '%" + searchname + "%' and stu_number like '%" + searchnumber + "%' and DATE_FORMAT(stu_datetime,'%Y-%m-%d') ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
                }

                if (sql != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                    while (get.Read())
                    {
                        listBox1.Items.Add(get[1].ToString().Trim());
                        listBox1.Items.Add(get[0].ToString().Trim());
                    }
                    get.Close();
                    textBox_searchname.Clear();
                    textBox_searchnumber.Clear();
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

        private void button_question_Click(object sender, EventArgs e)
        {
            question = richTextBox_question.Text;

            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                string sql = null;
                if (question.Length == 0)
                {
                    MessageBox.Show("请输入问题信息!", "编程打卡系统");
                }
                else
                {
                    sql = " insert into question(stu_number, stu_question,date) values('" + student_number + "', '"+ question + "', '" + DateTime.Now.ToString() + "') ";
                }
                
                if (sql != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("提交成功!", "编程打卡系统");
                    richTextBox_question.Clear();
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

        private void button_quesclc_Click(object sender, EventArgs e)
        {
            richTextBox_question.Clear();
        }

        private void button_refresh_get_answer_Click(object sender, EventArgs e)
        {
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            MySqlDataAdapter s1 = new MySqlDataAdapter("select * from question where stu_number = '" + student_number + "' ", conn);
            DataSet d1 = new DataSet();
            s1.Fill(d1, "t");
            dataGridView_get_answer.DataSource = d1.Tables["t"];
            conn.Close();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗?", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (this.dataGridView_get_answer.SelectedRows.Count > 0)
                {
                    int a = dataGridView_get_answer.CurrentRow.Index;
                    string delete_question = dataGridView_get_answer.Rows[a].Cells[1].Value.ToString();
                    DataRowView drv = dataGridView_get_answer.SelectedRows[0].DataBoundItem as DataRowView;
                    drv.Delete();

                    string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                    MySqlConnection conn = new MySqlConnection(connectStr);
                    try
                    {
                        conn.Open();
                        string sql = " delete from question where stu_question = '" + delete_question + "' ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功!", "编程打卡系统");
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

        private void button_stu_idcard_Click(object sender, EventArgs e)
        {
            if (textBox_stu_idcard.Text.Length == 0)
            {
                MessageBox.Show("请输入身份信息!", "编程打卡系统");
            }
            else
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " update student set stu_idcard = '" + textBox_stu_idcard.Text + "' where stu_number = '"+student_number+"' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("绑定身份信息成功!", "编程打卡系统");

                    string sql1 = " select stu_idcard from student where stu_number = '" + student_number + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader get = cmd1.ExecuteReader();  //getusername.Read()表示找到
                    if (get.Read())
                    {
                        textBox_stu_idcard.Text = "" + get[0].ToString() + "";
                        get.Close();
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

        private void richTextBox_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)

        {

            ListBox listBox = sender as ListBox;

            int index = e.Index;//获取当前要进行绘制的行的序号，从0开始。

            if (index < 0)

            {

                return;

            }

            string text = Convert.ToString(listBox.Items[index]);



            //超范围后自动换行

            Size size = TextRenderer.MeasureText(index + ":" + text, listBox.Font, listBox.Size, TextFormatFlags.WordBreak);

            e.ItemWidth = size.Width;

            e.ItemHeight = size.Height + ITEM_PADDING * 2;//适当多一点高度，避免太挤

        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)

        {

            int index = e.Index;//获取当前要进行绘制的行的序号，从0开始。

            if (index < 0)

            {

                return;

            }

            ListBox listBox = sender as ListBox;

            e.DrawBackground();//画背景颜色

            e.DrawFocusRectangle();//画聚焦项的边框

            Graphics g = e.Graphics;//获取Graphics对象。

            int hzSize = (int)listBox1.CreateGraphics().MeasureString(listBox1.Items[listBox1.Items.Count - 1].ToString(), listBox1.Font).Width+200;
            // Set the HorizontalExtent property.
            listBox1.HorizontalExtent = hzSize;

            Rectangle itemBounds = e.Bounds;//获取当前要绘制的行的一个矩形范围。

            //文字绘制的区域，留出一定间隔

            Rectangle textBounds = new Rectangle(itemBounds.X, itemBounds.Y + ITEM_PADDING, itemBounds.Width, itemBounds.Height);

            string text = Convert.ToString(listBox.Items[index]);

            //因为文本可能会非常长，因此要用自绘实现ListBox项目的自动换行

            TextRenderer.DrawText(g, "" + text, e.Font, textBounds, e.ForeColor,TextFormatFlags.WordBreak);

            g.DrawRectangle(Pens.Black, itemBounds);//画每一项的边框，这样清楚分出来各项。

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            MySqlDataAdapter s = new MySqlDataAdapter("select * from record order by record_days desc", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            dataGridView_record.DataSource = d.Tables["t"];

            try
            {
                conn.Open();
                string sql = " select stu_id,stu_name,stu_days from student where stu_number = '" + student_number + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                if (get.Read())
                {
                    id = int.Parse(get[0].ToString());
                    name = get[1].ToString();
                    days = double.Parse(get[2].ToString());
                    get.Close();
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

            label_name.Text = "欢迎用户:" + name + " ";
            label_time.Text = "当前时间:" + DateTime.Now.ToString() + " " + weekstr;
            label_showid.Text = "" + id + "";
            label_shownumber.Text = "" + student_number + "";
            label_showname.Text = "" + name + "";
            label_showdays.Text = "" + days + "";

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.richTextBox_code.Clear();
        }

        private void button_hand_Click(object sender, EventArgs e)
        {
            code = richTextBox_code.Text;
            if (code.Length == 0)
            {
                MessageBox.Show("请输入程序代码!", "编程打卡系统");
            }
            else
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " select time_start,time_stop from timerange where time_id = '1' ";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    MySqlDataReader get = cmd1.ExecuteReader();  //getusername.Read()表示找到
                    if (get.Read())
                    {
                        timestart = get[0].ToString();
                        timestop = get[1].ToString();
                        get.Close();

                        DateTime dt1 = Convert.ToDateTime(timestart);
                        DateTime dt2 = Convert.ToDateTime(timestop);
                        DateTime dt3 = DateTime.Now;
                        if (DateTime.Compare(dt3, dt1) > 0 && DateTime.Compare(dt3, dt2) < 0)
                        {
                            string sql5 = " select * from program where stu_number = '"+student_number+"' and DATE_FORMAT(stu_datetime,'%Y-%m-%d')  = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
                            MySqlCommand cmd6 = new MySqlCommand(sql5, conn);
                            MySqlDataReader get6 = cmd6.ExecuteReader();
                            if (get6.Read())
                            {
                                get6.Close();
                                string sql1 = " insert into program(stu_number,stu_name,stu_program,stu_datetime) values('" + student_number + "','" + name + "','" + code + "','" + DateTime.Now.ToString() + "') ";
                                using (MySqlCommand cmd4 = new MySqlCommand(sql1, conn))
                                {
                                    cmd4.ExecuteNonQuery();
                                }
                                MessageBox.Show("今日已打卡,可继续提交,但不会增加打卡天数!", "编程打卡系统");
                                this.richTextBox_code.Clear();
                            }
                            else
                            {
                                get6.Close();
                                string sql1 = " insert into program(stu_number,stu_name,stu_program,stu_datetime) values('" + student_number + "','" + name + "','" + code + "','" + DateTime.Now.ToString() + "') ";
                                using (MySqlCommand cmd4 = new MySqlCommand(sql1, conn))
                                {
                                    cmd4.ExecuteNonQuery();
                                }
                                string sql2 = " update record set record_days=record_days+'1' where record_number='" + student_number + "' ";
                                using (MySqlCommand cmd3 = new MySqlCommand(sql2, conn))
                                {
                                    cmd3.ExecuteNonQuery();
                                }
                                string sql3 = " update student set stu_days=stu_days+'1' where stu_number='" + student_number + "' ";
                                using (MySqlCommand cmd5 = new MySqlCommand(sql3, conn))
                                {
                                    cmd5.ExecuteNonQuery();
                                }
                                MessageBox.Show("打卡成功!", "编程打卡系统");
                                this.richTextBox_code.Clear();
                            }

                        }
                        else
                        {
                            MessageBox.Show("不在打卡时间范围!", "编程打卡系统");
                        }

                    }
                    else
                    {
                        MessageBox.Show("该用户不存在,请重新输入!", "编程打卡系统");
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
