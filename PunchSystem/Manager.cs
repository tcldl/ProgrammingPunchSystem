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
    public partial class Manager : Form
    {
        private const int ITEM_PADDING = 8;
        private ManagerFind managerfind;
        private Answer answer;
        string weekstr = "";
        public string manager_number { get; set; }
        private int id;
        private string name, searchname, searchnumber, stusearchnumber, stusearchname, changeid, changepassword, changedays, changenumber;

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

        public Manager()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.tabControl.DrawItem += new DrawItemEventHandler(this.tabControl_DrawItem);
            listBox1.DrawItem += ListBox1_DrawItem;
            listBox1.MeasureItem += ListBox1_MeasureItem;
        }

        private void Manager_Load(object sender, EventArgs e)
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
            Win32Utility.SetCueText(textBox_changestuid, "输入学生编号");
            Win32Utility.SetCueText(textBox_changestupassword, "输入学生密码");
            Win32Utility.SetCueText(textBox_changestudays, "输入修改天数");
            Win32Utility.SetCueText(textBox_studentsearchname, "输入查询姓名");
            Win32Utility.SetCueText(textBox_studentsearchnumber, "输入查询学号");

            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            MySqlDataAdapter s1 = new MySqlDataAdapter("select stu_number, stu_question, date from question where stu_answer is NULL", conn);
            //创建DataSet对象d
            DataSet d1 = new DataSet();
            //使用fill方法填充DataSet
            s1.Fill(d1, "t");
            //在DataGridView1控件中显示表t
            dataGridView_question.DataSource = d1.Tables["t"];
            try
            {
                conn.Open();
                string sql = " select admin_id,admin_name,admin_idcard from admin where admin_number = '" + manager_number + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                if (get.Read())
                {
                    id = int.Parse(get[0].ToString());
                    name = get[1].ToString();
                    label_showmanagerid.Text = "" + get[0].ToString() + "";
                    label_showmanagername.Text = "" + get[1].ToString() + "";
                    label_showmanagerusername.Text = "" + manager_number + "";
                    textBox_manager_idcard.Text = get[2].ToString();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label_name.Text = "欢迎管理员:" + name + " ";
            label_time.Text = "当前时间:" + DateTime.Now.ToString() + " " + weekstr;
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            //显示打卡榜单
            //创建SqlDataAdapter对象s
            MySqlDataAdapter s = new MySqlDataAdapter("select * from record order by record_days desc", conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            dataGridView_record_manager.DataSource = d.Tables["t"];
            conn.Close();
        }

        private void button_listclear_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_changemanagerinfor_Click(object sender, EventArgs e)
        {
            managerfind = new ManagerFind();
            managerfind.manager_number = manager_number;
            managerfind.ShowDialog();
        }

        private void button_refresh_question_Click(object sender, EventArgs e)
        {
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            MySqlDataAdapter s1 = new MySqlDataAdapter("select stu_number, stu_question, date from question where stu_answer is NULL", conn);
            //创建DataSet对象d
            DataSet d1 = new DataSet();
            //使用fill方法填充DataSet
            s1.Fill(d1, "t");
            //在DataGridView1控件中显示表t
            dataGridView_question.DataSource = d1.Tables["t"];
            conn.Close();
        }

        private void 回复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_question.SelectedRows.Count > 0)
            {
                int a = dataGridView_question.CurrentRow.Index;
                string answer_number = dataGridView_question.Rows[a].Cells[1].Value.ToString();
                string answer_question = dataGridView_question.Rows[a].Cells[2].Value.ToString();

                answer = new Answer();
                answer.student_number = answer_number;
                answer.student_question = answer_question;
                answer.ShowDialog();
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗?", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (this.dataGridView_question.SelectedRows.Count > 0)
                {
                    int a = dataGridView_question.CurrentRow.Index;
                    string delete_question = dataGridView_question.Rows[a].Cells[2].Value.ToString();
                    DataRowView drv = dataGridView_question.SelectedRows[0].DataBoundItem as DataRowView;
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

        private void textBox_manager_idcard_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_manager_idcard_Click(object sender, EventArgs e)
        {
            if(textBox_manager_idcard.Text.Length == 0)
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
                    string sql = " update admin set admin_idcard = '" + textBox_manager_idcard.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("绑定身份信息成功!", "编程打卡系统");

                    string sql1 = " select admin_idcard from admin where admin_number = '" + manager_number + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader get = cmd1.ExecuteReader();  //getusername.Read()表示找到
                    if (get.Read())
                    {
                        textBox_manager_idcard.Text = "" + get[0].ToString() + "";
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

        private void button_changetime_Click(object sender, EventArgs e)
        {
            string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                string sql = " update timerange set time_start = '" + dateTimePicker_start.Value.ToString() + "',time_stop = '" + dateTimePicker_stop.Value.ToString() + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改打卡时间成功!", "编程打卡系统");
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

        private void button_search_Click_1(object sender, EventArgs e)
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
                if (searchname.Length == 0 && searchnumber.Length == 0)
                {
                    MessageBox.Show("请输入查询信息!", "编程打卡系统");
                }
                else if (searchname.Length == 0 && searchnumber.Length != 0)
                {
                    sql = " select stu_program,stu_datetime from program where stu_number like '%" + searchnumber + "%' and DATE_FORMAT(stu_datetime,'%Y-%m-%d') ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
                }
                else if (searchname.Length != 0 && searchnumber.Length == 0)
                {
                    sql = " select stu_program,stu_datetime from program where stu_name like '%" + searchname + "%' and DATE_FORMAT(stu_datetime,'%Y-%m-%d') ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
                }
                else if (searchname.Length != 0 && searchnumber.Length != 0)
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

        private void button_stuclear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button_confirmchangestu_Click(object sender, EventArgs e)
        {
            changeid = textBox_changestuid.Text;
            changepassword = textBox_changestupassword.Text;
            changedays = textBox_changestudays.Text;
            if (changeid.Length == 0)
            {
                MessageBox.Show("请输入要修改学生的编号!", "编程打卡系统");
            }
            else if (changeid.Length != 0 && changepassword.Length != 0 && changedays.Length == 0)
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " update student set stu_password = '" + changepassword + "' where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功!", "编程打卡系统");
                    textBox_changestuid.Clear();
                    textBox_changestupassword.Clear();
                    textBox_changestudays.Clear();
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
            else if (changeid.Length != 0 && changepassword.Length == 0 && changedays.Length != 0)
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " update student set stu_days = '" + changedays + "' where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    string sql1 = " select stu_number from student where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader get1 = cmd1.ExecuteReader();
                    if (get1.Read())
                    {
                        changenumber = get1[0].ToString();
                        get1.Close();
                    }
                    string sql2 = " update record set record_days = '" + changedays + "' where record_number = '" + changenumber + "' ";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("修改成功!", "编程打卡系统");
                    textBox_changestuid.Clear();
                    textBox_changestupassword.Clear();
                    textBox_changestudays.Clear();
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
            else if (changeid.Length != 0 && changepassword.Length != 0 && changedays.Length != 0)
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql = " update student set stu_password = '" + changepassword + "' where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    string sql3 = " update student set stu_days = '" + changedays + "' where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();
                    string sql1 = " select stu_number from student where stu_id = '" + changeid + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader get1 = cmd1.ExecuteReader();
                    if (get1.Read())
                    {
                        changenumber = get1[0].ToString();
                        get1.Close();
                    }
                    string sql2 = " update record set record_days = '" + changedays + "' where record_number = '" + changenumber + "' ";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("修改成功!", "编程打卡系统");
                    textBox_changestuid.Clear();
                    textBox_changestupassword.Clear();
                    textBox_changestudays.Clear();
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
            else if (changeid.Length != 0 && changepassword.Length == 0 && changedays.Length == 0)
            {
                MessageBox.Show("请输入要修改学生的信息!", "编程打卡系统");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_studentsearch_Click(object sender, EventArgs e)
        {
            stusearchnumber = textBox_studentsearchnumber.Text;
            stusearchname = textBox_studentsearchname.Text;

            if (stusearchnumber.Length == 0 && stusearchname.Length == 0)
            {
                MessageBox.Show("请输入查询信息!", "编程打卡系统");
            }
            else
            {
                string connectStr = "server=localhost;port=3306;database=programpunchsystem;user=root;password=123456;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    string sql;
                    if (stusearchname.Length == 0 && stusearchnumber.Length != 0)
                        sql = " select stu_id,stu_name,stu_password,stu_idcard,stu_days from student where stu_number like '%" + stusearchnumber + "%' ";
                    else if (stusearchname.Length != 0 && stusearchnumber.Length == 0)
                        sql = " select stu_id,stu_name,stu_password,stu_idcard,stu_days from student where stu_name like '%" + stusearchname + "%' ";
                    else
                        sql = " select stu_id,stu_name,stu_password,stu_idcard,stu_days from student where stu_number like '%" + stusearchnumber + "%' and stu_name like '%" + stusearchname + "%' ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader get = cmd.ExecuteReader();  //getusername.Read()表示找到
                    while (get.Read())
                    {
                        ListViewItem lt = new ListViewItem();
                        //将数据库数据转变成ListView类型的一行数据
                        lt.Text = get[0].ToString();
                        lt.SubItems.Add(get[1].ToString());
                        lt.SubItems.Add(get[2].ToString());
                        lt.SubItems.Add(get[3].ToString());
                        lt.SubItems.Add(get[4].ToString());
                        //将lt数据添加到listView1控件中
                        listView1.Items.Add(lt);
                    }
                    get.Close();
                    textBox_studentsearchnumber.Clear();
                    textBox_studentsearchname.Clear();
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

            int hzSize = (int)listBox1.CreateGraphics().MeasureString(listBox1.Items[listBox1.Items.Count - 1].ToString(), listBox1.Font).Width + 200;
            // Set the HorizontalExtent property.
            listBox1.HorizontalExtent = hzSize;

            Rectangle itemBounds = e.Bounds;//获取当前要绘制的行的一个矩形范围。

            //文字绘制的区域，留出一定间隔

            Rectangle textBounds = new Rectangle(itemBounds.X, itemBounds.Y + ITEM_PADDING, itemBounds.Width, itemBounds.Height);

            string text = Convert.ToString(listBox.Items[index]);

            //因为文本可能会非常长，因此要用自绘实现ListBox项目的自动换行

            TextRenderer.DrawText(g, "" + text, e.Font, textBounds, e.ForeColor, TextFormatFlags.WordBreak);

            g.DrawRectangle(Pens.Black, itemBounds);//画每一项的边框，这样清楚分出来各项。

        }

    }
}