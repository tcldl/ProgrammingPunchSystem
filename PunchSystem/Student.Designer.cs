namespace PunchSystem
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_hand = new System.Windows.Forms.Button();
            this.richTextBox_code = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_record = new System.Windows.Forms.DataGridView();
            this.recordnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recorddaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programpunchsystemDataSet = new PunchSystem.programpunchsystemDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_searchnumber = new System.Windows.Forms.TextBox();
            this.button_listclear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_searchname = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_refresh_get_answer = new System.Windows.Forms.Button();
            this.dataGridView_get_answer = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_stu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programpunchsystemDataSet2 = new PunchSystem.programpunchsystemDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_question = new System.Windows.Forms.RichTextBox();
            this.button_quesclc = new System.Windows.Forms.Button();
            this.button_question = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_showdays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_showname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_shownumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_showid = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.recordTableAdapter = new PunchSystem.programpunchsystemDataSetTableAdapters.recordTableAdapter();
            this.questionTableAdapter = new PunchSystem.programpunchsystemDataSet2TableAdapters.questionTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_stu_idcard = new System.Windows.Forms.TextBox();
            this.button_stu_idcard = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programpunchsystemDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get_answer)).BeginInit();
            this.contextMenuStrip_stu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programpunchsystemDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Font = new System.Drawing.Font("仿宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(585, 23);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 30);
            this.label_time.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("仿宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(340, 23);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 30);
            this.label_name.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(70, 100);
            this.tabControl.Location = new System.Drawing.Point(12, 80);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1154, 791);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_clear);
            this.tabPage1.Controls.Add(this.button_hand);
            this.tabPage1.Controls.Add(this.richTextBox_code);
            this.tabPage1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 783);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "编程打卡";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clear.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_clear.Location = new System.Drawing.Point(593, 703);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(200, 60);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "清除";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_hand
            // 
            this.button_hand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hand.BackColor = System.Drawing.Color.BurlyWood;
            this.button_hand.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_hand.Location = new System.Drawing.Point(265, 703);
            this.button_hand.Name = "button_hand";
            this.button_hand.Size = new System.Drawing.Size(200, 60);
            this.button_hand.TabIndex = 1;
            this.button_hand.Text = "提交";
            this.button_hand.UseVisualStyleBackColor = false;
            this.button_hand.Click += new System.EventHandler(this.button_hand_Click);
            // 
            // richTextBox_code
            // 
            this.richTextBox_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_code.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richTextBox_code.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_code.Location = new System.Drawing.Point(6, 6);
            this.richTextBox_code.Name = "richTextBox_code";
            this.richTextBox_code.Size = new System.Drawing.Size(1034, 683);
            this.richTextBox_code.TabIndex = 0;
            this.richTextBox_code.Text = "";
            this.richTextBox_code.TextChanged += new System.EventHandler(this.richTextBox_code_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dataGridView_record);
            this.tabPage2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 783);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "榜单总览";
            // 
            // dataGridView_record
            // 
            this.dataGridView_record.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_record.AutoGenerateColumns = false;
            this.dataGridView_record.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordnumberDataGridViewTextBoxColumn,
            this.recordnameDataGridViewTextBoxColumn,
            this.recorddaysDataGridViewTextBoxColumn});
            this.dataGridView_record.DataSource = this.recordBindingSource;
            this.dataGridView_record.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView_record.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_record.Name = "dataGridView_record";
            this.dataGridView_record.RowHeadersWidth = 62;
            this.dataGridView_record.RowTemplate.Height = 30;
            this.dataGridView_record.Size = new System.Drawing.Size(1034, 771);
            this.dataGridView_record.TabIndex = 0;
            // 
            // recordnumberDataGridViewTextBoxColumn
            // 
            this.recordnumberDataGridViewTextBoxColumn.DataPropertyName = "record_number";
            this.recordnumberDataGridViewTextBoxColumn.HeaderText = "学生学号";
            this.recordnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordnumberDataGridViewTextBoxColumn.Name = "recordnumberDataGridViewTextBoxColumn";
            this.recordnumberDataGridViewTextBoxColumn.Width = 180;
            // 
            // recordnameDataGridViewTextBoxColumn
            // 
            this.recordnameDataGridViewTextBoxColumn.DataPropertyName = "record_name";
            this.recordnameDataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.recordnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordnameDataGridViewTextBoxColumn.Name = "recordnameDataGridViewTextBoxColumn";
            this.recordnameDataGridViewTextBoxColumn.Width = 180;
            // 
            // recorddaysDataGridViewTextBoxColumn
            // 
            this.recorddaysDataGridViewTextBoxColumn.DataPropertyName = "record_days";
            this.recorddaysDataGridViewTextBoxColumn.HeaderText = "打卡天数";
            this.recorddaysDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recorddaysDataGridViewTextBoxColumn.Name = "recorddaysDataGridViewTextBoxColumn";
            this.recorddaysDataGridViewTextBoxColumn.Width = 180;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "record";
            this.recordBindingSource.DataSource = this.programpunchsystemDataSet;
            // 
            // programpunchsystemDataSet
            // 
            this.programpunchsystemDataSet.DataSetName = "programpunchsystemDataSet";
            this.programpunchsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_searchnumber);
            this.tabPage3.Controls.Add(this.button_listclear);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.textBox_searchname);
            this.tabPage3.Controls.Add(this.button_search);
            this.tabPage3.Controls.Add(this.label_date);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1046, 783);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "代码共享";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_searchnumber
            // 
            this.textBox_searchnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_searchnumber.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_searchnumber.Location = new System.Drawing.Point(48, 12);
            this.textBox_searchnumber.Name = "textBox_searchnumber";
            this.textBox_searchnumber.Size = new System.Drawing.Size(200, 39);
            this.textBox_searchnumber.TabIndex = 0;
            // 
            // button_listclear
            // 
            this.button_listclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_listclear.BackColor = System.Drawing.Color.BurlyWood;
            this.button_listclear.Location = new System.Drawing.Point(901, 12);
            this.button_listclear.Name = "button_listclear";
            this.button_listclear.Size = new System.Drawing.Size(100, 40);
            this.button_listclear.TabIndex = 3;
            this.button_listclear.Text = "清除";
            this.button_listclear.UseVisualStyleBackColor = false;
            this.button_listclear.Click += new System.EventHandler(this.button_listclear_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(15, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1016, 704);
            this.listBox1.TabIndex = 4;
            // 
            // textBox_searchname
            // 
            this.textBox_searchname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_searchname.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_searchname.Location = new System.Drawing.Point(264, 12);
            this.textBox_searchname.Name = "textBox_searchname";
            this.textBox_searchname.Size = new System.Drawing.Size(200, 39);
            this.textBox_searchname.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_search.BackColor = System.Drawing.Color.BurlyWood;
            this.button_search.Location = new System.Drawing.Point(789, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 40);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(470, 19);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(96, 28);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(574, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage5.Location = new System.Drawing.Point(104, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1046, 783);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "问题详情";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_refresh_get_answer);
            this.groupBox3.Controls.Add(this.dataGridView_get_answer);
            this.groupBox3.Location = new System.Drawing.Point(15, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1021, 401);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "问题反馈";
            // 
            // button_refresh_get_answer
            // 
            this.button_refresh_get_answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_refresh_get_answer.BackColor = System.Drawing.Color.BurlyWood;
            this.button_refresh_get_answer.Location = new System.Drawing.Point(460, 348);
            this.button_refresh_get_answer.Name = "button_refresh_get_answer";
            this.button_refresh_get_answer.Size = new System.Drawing.Size(100, 40);
            this.button_refresh_get_answer.TabIndex = 1;
            this.button_refresh_get_answer.Text = "刷新";
            this.button_refresh_get_answer.UseVisualStyleBackColor = false;
            this.button_refresh_get_answer.Click += new System.EventHandler(this.button_refresh_get_answer_Click);
            // 
            // dataGridView_get_answer
            // 
            this.dataGridView_get_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_get_answer.AutoGenerateColumns = false;
            this.dataGridView_get_answer.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView_get_answer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_get_answer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.stuquestionDataGridViewTextBoxColumn,
            this.stuanswerDataGridViewTextBoxColumn});
            this.dataGridView_get_answer.ContextMenuStrip = this.contextMenuStrip_stu;
            this.dataGridView_get_answer.DataSource = this.questionBindingSource;
            this.dataGridView_get_answer.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_get_answer.Name = "dataGridView_get_answer";
            this.dataGridView_get_answer.RowHeadersWidth = 62;
            this.dataGridView_get_answer.RowTemplate.Height = 30;
            this.dataGridView_get_answer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_get_answer.Size = new System.Drawing.Size(1009, 324);
            this.dataGridView_get_answer.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 90;
            // 
            // stuquestionDataGridViewTextBoxColumn
            // 
            this.stuquestionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stuquestionDataGridViewTextBoxColumn.DataPropertyName = "stu_question";
            this.stuquestionDataGridViewTextBoxColumn.FillWeight = 28.57143F;
            this.stuquestionDataGridViewTextBoxColumn.HeaderText = "问题详情";
            this.stuquestionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stuquestionDataGridViewTextBoxColumn.Name = "stuquestionDataGridViewTextBoxColumn";
            this.stuquestionDataGridViewTextBoxColumn.Width = 134;
            // 
            // stuanswerDataGridViewTextBoxColumn
            // 
            this.stuanswerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stuanswerDataGridViewTextBoxColumn.DataPropertyName = "stu_answer";
            this.stuanswerDataGridViewTextBoxColumn.FillWeight = 171.4286F;
            this.stuanswerDataGridViewTextBoxColumn.HeaderText = "问题回复";
            this.stuanswerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stuanswerDataGridViewTextBoxColumn.Name = "stuanswerDataGridViewTextBoxColumn";
            this.stuanswerDataGridViewTextBoxColumn.Width = 134;
            // 
            // contextMenuStrip_stu
            // 
            this.contextMenuStrip_stu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_stu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip_stu.Name = "contextMenuStrip_stu";
            this.contextMenuStrip_stu.Size = new System.Drawing.Size(117, 34);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.programpunchsystemDataSet2;
            // 
            // programpunchsystemDataSet2
            // 
            this.programpunchsystemDataSet2.DataSetName = "programpunchsystemDataSet2";
            this.programpunchsystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBox_question);
            this.groupBox2.Controls.Add(this.button_quesclc);
            this.groupBox2.Controls.Add(this.button_question);
            this.groupBox2.Location = new System.Drawing.Point(15, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 340);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "提问页面";
            // 
            // richTextBox_question
            // 
            this.richTextBox_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_question.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richTextBox_question.Location = new System.Drawing.Point(6, 21);
            this.richTextBox_question.Name = "richTextBox_question";
            this.richTextBox_question.Size = new System.Drawing.Size(1009, 267);
            this.richTextBox_question.TabIndex = 0;
            this.richTextBox_question.Text = "";
            // 
            // button_quesclc
            // 
            this.button_quesclc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_quesclc.BackColor = System.Drawing.Color.BurlyWood;
            this.button_quesclc.Location = new System.Drawing.Point(593, 290);
            this.button_quesclc.Name = "button_quesclc";
            this.button_quesclc.Size = new System.Drawing.Size(100, 40);
            this.button_quesclc.TabIndex = 2;
            this.button_quesclc.Text = "清除";
            this.button_quesclc.UseVisualStyleBackColor = false;
            this.button_quesclc.Click += new System.EventHandler(this.button_quesclc_Click);
            // 
            // button_question
            // 
            this.button_question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_question.BackColor = System.Drawing.Color.BurlyWood;
            this.button_question.Location = new System.Drawing.Point(312, 290);
            this.button_question.Name = "button_question";
            this.button_question.Size = new System.Drawing.Size(100, 40);
            this.button_question.TabIndex = 1;
            this.button_question.Text = "提交";
            this.button_question.UseVisualStyleBackColor = false;
            this.button_question.Click += new System.EventHandler(this.button_question_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.button_change);
            this.tabPage4.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(104, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1046, 783);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "个人中心";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button_stu_idcard);
            this.groupBox1.Controls.Add(this.textBox_stu_idcard);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_showdays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_showname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_shownumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_showid);
            this.groupBox1.Location = new System.Drawing.Point(181, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(115, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号:";
            // 
            // label_showdays
            // 
            this.label_showdays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_showdays.AutoSize = true;
            this.label_showdays.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_showdays.Location = new System.Drawing.Point(228, 244);
            this.label_showdays.Name = "label_showdays";
            this.label_showdays.Size = new System.Drawing.Size(0, 33);
            this.label_showdays.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号:";
            // 
            // label_showname
            // 
            this.label_showname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_showname.AutoSize = true;
            this.label_showname.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_showname.Location = new System.Drawing.Point(228, 179);
            this.label_showname.Name = "label_showname";
            this.label_showname.Size = new System.Drawing.Size(0, 33);
            this.label_showname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(115, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名:";
            // 
            // label_shownumber
            // 
            this.label_shownumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_shownumber.AutoSize = true;
            this.label_shownumber.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_shownumber.Location = new System.Drawing.Point(228, 116);
            this.label_shownumber.Name = "label_shownumber";
            this.label_shownumber.Size = new System.Drawing.Size(0, 33);
            this.label_shownumber.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(51, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "记录天数:";
            // 
            // label_showid
            // 
            this.label_showid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_showid.AutoSize = true;
            this.label_showid.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_showid.Location = new System.Drawing.Point(228, 50);
            this.label_showid.Name = "label_showid";
            this.label_showid.Size = new System.Drawing.Size(0, 33);
            this.label_showid.TabIndex = 0;
            // 
            // button_change
            // 
            this.button_change.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_change.BackColor = System.Drawing.Color.BurlyWood;
            this.button_change.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_change.Location = new System.Drawing.Point(181, 584);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(693, 60);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "修改信息";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // recordTableAdapter
            // 
            this.recordTableAdapter.ClearBeforeFill = true;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(51, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "身份信息:";
            // 
            // textBox_stu_idcard
            // 
            this.textBox_stu_idcard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_stu_idcard.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_stu_idcard.Location = new System.Drawing.Point(225, 308);
            this.textBox_stu_idcard.Name = "textBox_stu_idcard";
            this.textBox_stu_idcard.Size = new System.Drawing.Size(300, 39);
            this.textBox_stu_idcard.TabIndex = 2;
            // 
            // button_stu_idcard
            // 
            this.button_stu_idcard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_stu_idcard.BackColor = System.Drawing.Color.BurlyWood;
            this.button_stu_idcard.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stu_idcard.Location = new System.Drawing.Point(540, 308);
            this.button_stu_idcard.Name = "button_stu_idcard";
            this.button_stu_idcard.Size = new System.Drawing.Size(120, 40);
            this.button_stu_idcard.TabIndex = 2;
            this.button_stu_idcard.Text = "立即绑定";
            this.button_stu_idcard.UseVisualStyleBackColor = false;
            this.button_stu_idcard.Click += new System.EventHandler(this.button_stu_idcard_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_time);
            this.DoubleBuffered = true;
            this.Name = "Student";
            this.Text = "编程打卡系统用户";
            this.Load += new System.EventHandler(this.Student_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programpunchsystemDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get_answer)).EndInit();
            this.contextMenuStrip_stu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programpunchsystemDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox_code;
        private System.Windows.Forms.DataGridView dataGridView_record;
        private programpunchsystemDataSet programpunchsystemDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private programpunchsystemDataSetTableAdapters.recordTableAdapter recordTableAdapter;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label_showdays;
        private System.Windows.Forms.Label label_showname;
        private System.Windows.Forms.Label label_shownumber;
        private System.Windows.Forms.Label label_showid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_searchname;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_searchnumber;
        private System.Windows.Forms.Button button_listclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorddaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox richTextBox_question;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_hand;
        private System.Windows.Forms.Button button_quesclc;
        private System.Windows.Forms.Button button_question;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_get_answer;
        private programpunchsystemDataSet2 programpunchsystemDataSet2;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private programpunchsystemDataSet2TableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuanswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_refresh_get_answer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_stu;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button button_stu_idcard;
        private System.Windows.Forms.TextBox textBox_stu_idcard;
        private System.Windows.Forms.Label label5;
    }
}