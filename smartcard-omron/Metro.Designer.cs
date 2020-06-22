namespace smartcard_omron
{
    partial class Metro
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
            this.timer_checksmartcard = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_data = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTxt_datetime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTxt_pr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTxt_dia = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_sys = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTxt_status = new MetroFramework.Controls.MetroTextBox();
            this.grb_smartcard = new System.Windows.Forms.GroupBox();
            this.metroTxt_province = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_distrat = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_subdistrat = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_issure = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_road = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_lane = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_moo = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_houseno = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_expire = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_issuedate = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_dateOfbirth = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_gender = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_lastname_en = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_firstname_en = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_prefix_en = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_lastname_th = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_firstname_th = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_prefix_th = new MetroFramework.Controls.MetroTextBox();
            this.metroTxt_idcard = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.grb_data.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_smartcard.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_checksmartcard
            // 
            this.timer_checksmartcard.Interval = 3000;
            this.timer_checksmartcard.Tick += new System.EventHandler(this.timer_checksmartcard_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grb_data);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grb_smartcard);
            this.panel1.Location = new System.Drawing.Point(19, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 656);
            this.panel1.TabIndex = 55;
            // 
            // grb_data
            // 
            this.grb_data.Controls.Add(this.groupBox2);
            this.grb_data.Controls.Add(this.metroLabel3);
            this.grb_data.Controls.Add(this.metroTxt_pr);
            this.grb_data.Controls.Add(this.metroLabel2);
            this.grb_data.Controls.Add(this.metroLabel1);
            this.grb_data.Controls.Add(this.metroTxt_dia);
            this.grb_data.Controls.Add(this.metroTxt_sys);
            this.grb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_data.Location = new System.Drawing.Point(667, 25);
            this.grb_data.Name = "grb_data";
            this.grb_data.Size = new System.Drawing.Size(304, 347);
            this.grb_data.TabIndex = 53;
            this.grb_data.TabStop = false;
            this.grb_data.Text = "DATA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTxt_datetime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 76);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATETIME";
            // 
            // metroTxt_datetime
            // 
            this.metroTxt_datetime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_datetime.CustomForeColor = true;
            this.metroTxt_datetime.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_datetime.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_datetime.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_datetime.Location = new System.Drawing.Point(17, 19);
            this.metroTxt_datetime.Multiline = true;
            this.metroTxt_datetime.Name = "metroTxt_datetime";
            this.metroTxt_datetime.Size = new System.Drawing.Size(254, 45);
            this.metroTxt_datetime.TabIndex = 79;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(29, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 25);
            this.metroLabel3.TabIndex = 78;
            this.metroLabel3.Text = "PR :";
            // 
            // metroTxt_pr
            // 
            this.metroTxt_pr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_pr.CustomForeColor = true;
            this.metroTxt_pr.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_pr.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_pr.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_pr.Location = new System.Drawing.Point(120, 161);
            this.metroTxt_pr.Multiline = true;
            this.metroTxt_pr.Name = "metroTxt_pr";
            this.metroTxt_pr.Size = new System.Drawing.Size(161, 45);
            this.metroTxt_pr.TabIndex = 76;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(29, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 74;
            this.metroLabel2.Tag = "";
            this.metroLabel2.Text = "DIA :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(29, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 25);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "SYS :";
            // 
            // metroTxt_dia
            // 
            this.metroTxt_dia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_dia.CustomForeColor = true;
            this.metroTxt_dia.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_dia.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_dia.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_dia.Location = new System.Drawing.Point(120, 96);
            this.metroTxt_dia.Multiline = true;
            this.metroTxt_dia.Name = "metroTxt_dia";
            this.metroTxt_dia.Size = new System.Drawing.Size(159, 45);
            this.metroTxt_dia.TabIndex = 72;
            // 
            // metroTxt_sys
            // 
            this.metroTxt_sys.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_sys.CustomForeColor = true;
            this.metroTxt_sys.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_sys.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_sys.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_sys.Location = new System.Drawing.Point(120, 33);
            this.metroTxt_sys.Multiline = true;
            this.metroTxt_sys.Name = "metroTxt_sys";
            this.metroTxt_sys.Size = new System.Drawing.Size(161, 45);
            this.metroTxt_sys.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTxt_status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 87);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // metroTxt_status
            // 
            this.metroTxt_status.BackColor = System.Drawing.Color.White;
            this.metroTxt_status.CustomBackground = true;
            this.metroTxt_status.CustomForeColor = true;
            this.metroTxt_status.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_status.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_status.ForeColor = System.Drawing.Color.Red;
            this.metroTxt_status.Location = new System.Drawing.Point(6, 19);
            this.metroTxt_status.Multiline = true;
            this.metroTxt_status.Name = "metroTxt_status";
            this.metroTxt_status.Size = new System.Drawing.Size(622, 58);
            this.metroTxt_status.TabIndex = 81;
            // 
            // grb_smartcard
            // 
            this.grb_smartcard.Controls.Add(this.metroTxt_province);
            this.grb_smartcard.Controls.Add(this.metroTxt_distrat);
            this.grb_smartcard.Controls.Add(this.metroTxt_subdistrat);
            this.grb_smartcard.Controls.Add(this.metroTxt_issure);
            this.grb_smartcard.Controls.Add(this.metroTxt_road);
            this.grb_smartcard.Controls.Add(this.metroTxt_lane);
            this.grb_smartcard.Controls.Add(this.metroTxt_moo);
            this.grb_smartcard.Controls.Add(this.metroTxt_houseno);
            this.grb_smartcard.Controls.Add(this.metroTxt_expire);
            this.grb_smartcard.Controls.Add(this.metroTxt_issuedate);
            this.grb_smartcard.Controls.Add(this.metroTxt_dateOfbirth);
            this.grb_smartcard.Controls.Add(this.metroTxt_gender);
            this.grb_smartcard.Controls.Add(this.metroTxt_lastname_en);
            this.grb_smartcard.Controls.Add(this.metroTxt_firstname_en);
            this.grb_smartcard.Controls.Add(this.metroTxt_prefix_en);
            this.grb_smartcard.Controls.Add(this.metroTxt_lastname_th);
            this.grb_smartcard.Controls.Add(this.metroTxt_firstname_th);
            this.grb_smartcard.Controls.Add(this.metroTxt_prefix_th);
            this.grb_smartcard.Controls.Add(this.metroTxt_idcard);
            this.grb_smartcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_smartcard.Location = new System.Drawing.Point(24, 25);
            this.grb_smartcard.Name = "grb_smartcard";
            this.grb_smartcard.Size = new System.Drawing.Size(637, 493);
            this.grb_smartcard.TabIndex = 52;
            this.grb_smartcard.TabStop = false;
            this.grb_smartcard.Text = "SMART CARD";
            // 
            // metroTxt_province
            // 
            this.metroTxt_province.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_province.CustomForeColor = true;
            this.metroTxt_province.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_province.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_province.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_province.Location = new System.Drawing.Point(433, 421);
            this.metroTxt_province.Multiline = true;
            this.metroTxt_province.Name = "metroTxt_province";
            this.metroTxt_province.Size = new System.Drawing.Size(195, 45);
            this.metroTxt_province.TabIndex = 70;
            this.metroTxt_province.Text = "จังหวัด";
            // 
            // metroTxt_distrat
            // 
            this.metroTxt_distrat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_distrat.CustomForeColor = true;
            this.metroTxt_distrat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_distrat.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_distrat.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_distrat.Location = new System.Drawing.Point(207, 421);
            this.metroTxt_distrat.Multiline = true;
            this.metroTxt_distrat.Name = "metroTxt_distrat";
            this.metroTxt_distrat.Size = new System.Drawing.Size(205, 45);
            this.metroTxt_distrat.TabIndex = 69;
            this.metroTxt_distrat.Text = "อำเภอ";
            // 
            // metroTxt_subdistrat
            // 
            this.metroTxt_subdistrat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_subdistrat.CustomForeColor = true;
            this.metroTxt_subdistrat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_subdistrat.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_subdistrat.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_subdistrat.Location = new System.Drawing.Point(15, 421);
            this.metroTxt_subdistrat.Multiline = true;
            this.metroTxt_subdistrat.Name = "metroTxt_subdistrat";
            this.metroTxt_subdistrat.Size = new System.Drawing.Size(168, 45);
            this.metroTxt_subdistrat.TabIndex = 68;
            this.metroTxt_subdistrat.Text = "ตำบล";
            // 
            // metroTxt_issure
            // 
            this.metroTxt_issure.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_issure.CustomForeColor = true;
            this.metroTxt_issure.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_issure.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_issure.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_issure.Location = new System.Drawing.Point(15, 291);
            this.metroTxt_issure.Multiline = true;
            this.metroTxt_issure.Name = "metroTxt_issure";
            this.metroTxt_issure.Size = new System.Drawing.Size(613, 45);
            this.metroTxt_issure.TabIndex = 67;
            this.metroTxt_issure.Text = "สถานที่ออกบัตร";
            // 
            // metroTxt_road
            // 
            this.metroTxt_road.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_road.CustomForeColor = true;
            this.metroTxt_road.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_road.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_road.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_road.Location = new System.Drawing.Point(419, 352);
            this.metroTxt_road.Multiline = true;
            this.metroTxt_road.Name = "metroTxt_road";
            this.metroTxt_road.Size = new System.Drawing.Size(212, 45);
            this.metroTxt_road.TabIndex = 66;
            this.metroTxt_road.Text = "ถนน";
            // 
            // metroTxt_lane
            // 
            this.metroTxt_lane.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_lane.CustomForeColor = true;
            this.metroTxt_lane.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_lane.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_lane.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_lane.Location = new System.Drawing.Point(224, 352);
            this.metroTxt_lane.Multiline = true;
            this.metroTxt_lane.Name = "metroTxt_lane";
            this.metroTxt_lane.Size = new System.Drawing.Size(171, 45);
            this.metroTxt_lane.TabIndex = 65;
            this.metroTxt_lane.Text = "ตรอก/ซอย";
            // 
            // metroTxt_moo
            // 
            this.metroTxt_moo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_moo.CustomForeColor = true;
            this.metroTxt_moo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_moo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_moo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_moo.Location = new System.Drawing.Point(128, 352);
            this.metroTxt_moo.Multiline = true;
            this.metroTxt_moo.Name = "metroTxt_moo";
            this.metroTxt_moo.Size = new System.Drawing.Size(78, 45);
            this.metroTxt_moo.TabIndex = 64;
            this.metroTxt_moo.Text = "หมู่";
            // 
            // metroTxt_houseno
            // 
            this.metroTxt_houseno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_houseno.CustomForeColor = true;
            this.metroTxt_houseno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_houseno.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_houseno.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_houseno.Location = new System.Drawing.Point(15, 352);
            this.metroTxt_houseno.Multiline = true;
            this.metroTxt_houseno.Name = "metroTxt_houseno";
            this.metroTxt_houseno.Size = new System.Drawing.Size(93, 45);
            this.metroTxt_houseno.TabIndex = 63;
            this.metroTxt_houseno.Text = "บ้านเลขที่";
            // 
            // metroTxt_expire
            // 
            this.metroTxt_expire.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_expire.CustomForeColor = true;
            this.metroTxt_expire.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_expire.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_expire.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_expire.Location = new System.Drawing.Point(462, 226);
            this.metroTxt_expire.Multiline = true;
            this.metroTxt_expire.Name = "metroTxt_expire";
            this.metroTxt_expire.Size = new System.Drawing.Size(166, 45);
            this.metroTxt_expire.TabIndex = 62;
            this.metroTxt_expire.Text = "วันหมดอายุ";
            // 
            // metroTxt_issuedate
            // 
            this.metroTxt_issuedate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_issuedate.CustomForeColor = true;
            this.metroTxt_issuedate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_issuedate.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_issuedate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_issuedate.Location = new System.Drawing.Point(274, 226);
            this.metroTxt_issuedate.Multiline = true;
            this.metroTxt_issuedate.Name = "metroTxt_issuedate";
            this.metroTxt_issuedate.Size = new System.Drawing.Size(162, 45);
            this.metroTxt_issuedate.TabIndex = 61;
            this.metroTxt_issuedate.Text = "วันออกบัตร";
            // 
            // metroTxt_dateOfbirth
            // 
            this.metroTxt_dateOfbirth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_dateOfbirth.CustomForeColor = true;
            this.metroTxt_dateOfbirth.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_dateOfbirth.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_dateOfbirth.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_dateOfbirth.Location = new System.Drawing.Point(114, 226);
            this.metroTxt_dateOfbirth.Multiline = true;
            this.metroTxt_dateOfbirth.Name = "metroTxt_dateOfbirth";
            this.metroTxt_dateOfbirth.Size = new System.Drawing.Size(138, 45);
            this.metroTxt_dateOfbirth.TabIndex = 60;
            this.metroTxt_dateOfbirth.Text = "วัน เดือน ปีเกิด";
            // 
            // metroTxt_gender
            // 
            this.metroTxt_gender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_gender.CustomForeColor = true;
            this.metroTxt_gender.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_gender.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_gender.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_gender.Location = new System.Drawing.Point(15, 226);
            this.metroTxt_gender.Multiline = true;
            this.metroTxt_gender.Name = "metroTxt_gender";
            this.metroTxt_gender.Size = new System.Drawing.Size(80, 45);
            this.metroTxt_gender.TabIndex = 59;
            this.metroTxt_gender.Text = "เพศ";
            // 
            // metroTxt_lastname_en
            // 
            this.metroTxt_lastname_en.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_lastname_en.CustomForeColor = true;
            this.metroTxt_lastname_en.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_lastname_en.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_lastname_en.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_lastname_en.Location = new System.Drawing.Point(408, 161);
            this.metroTxt_lastname_en.Multiline = true;
            this.metroTxt_lastname_en.Name = "metroTxt_lastname_en";
            this.metroTxt_lastname_en.Size = new System.Drawing.Size(220, 45);
            this.metroTxt_lastname_en.TabIndex = 58;
            this.metroTxt_lastname_en.Text = "นามสกุลอังกฤษ";
            // 
            // metroTxt_firstname_en
            // 
            this.metroTxt_firstname_en.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_firstname_en.CustomForeColor = true;
            this.metroTxt_firstname_en.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_firstname_en.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_firstname_en.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_firstname_en.Location = new System.Drawing.Point(165, 161);
            this.metroTxt_firstname_en.Multiline = true;
            this.metroTxt_firstname_en.Name = "metroTxt_firstname_en";
            this.metroTxt_firstname_en.Size = new System.Drawing.Size(222, 45);
            this.metroTxt_firstname_en.TabIndex = 57;
            this.metroTxt_firstname_en.Text = "ชื่ออังกฤษ";
            // 
            // metroTxt_prefix_en
            // 
            this.metroTxt_prefix_en.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_prefix_en.CustomForeColor = true;
            this.metroTxt_prefix_en.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_prefix_en.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_prefix_en.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_prefix_en.Location = new System.Drawing.Point(15, 161);
            this.metroTxt_prefix_en.Multiline = true;
            this.metroTxt_prefix_en.Name = "metroTxt_prefix_en";
            this.metroTxt_prefix_en.Size = new System.Drawing.Size(133, 45);
            this.metroTxt_prefix_en.TabIndex = 56;
            this.metroTxt_prefix_en.Text = "คำนำหน้า(EN)";
            // 
            // metroTxt_lastname_th
            // 
            this.metroTxt_lastname_th.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_lastname_th.CustomForeColor = true;
            this.metroTxt_lastname_th.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_lastname_th.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_lastname_th.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_lastname_th.Location = new System.Drawing.Point(411, 96);
            this.metroTxt_lastname_th.Multiline = true;
            this.metroTxt_lastname_th.Name = "metroTxt_lastname_th";
            this.metroTxt_lastname_th.Size = new System.Drawing.Size(220, 45);
            this.metroTxt_lastname_th.TabIndex = 55;
            this.metroTxt_lastname_th.Text = "นามสกุล";
            // 
            // metroTxt_firstname_th
            // 
            this.metroTxt_firstname_th.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_firstname_th.CustomForeColor = true;
            this.metroTxt_firstname_th.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_firstname_th.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_firstname_th.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_firstname_th.Location = new System.Drawing.Point(165, 96);
            this.metroTxt_firstname_th.Multiline = true;
            this.metroTxt_firstname_th.Name = "metroTxt_firstname_th";
            this.metroTxt_firstname_th.Size = new System.Drawing.Size(222, 45);
            this.metroTxt_firstname_th.TabIndex = 54;
            this.metroTxt_firstname_th.Text = "ชื่อไทย";
            // 
            // metroTxt_prefix_th
            // 
            this.metroTxt_prefix_th.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_prefix_th.CustomForeColor = true;
            this.metroTxt_prefix_th.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_prefix_th.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_prefix_th.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_prefix_th.Location = new System.Drawing.Point(15, 96);
            this.metroTxt_prefix_th.Multiline = true;
            this.metroTxt_prefix_th.Name = "metroTxt_prefix_th";
            this.metroTxt_prefix_th.Size = new System.Drawing.Size(133, 45);
            this.metroTxt_prefix_th.TabIndex = 53;
            this.metroTxt_prefix_th.Text = "คำนำหน้า";
            // 
            // metroTxt_idcard
            // 
            this.metroTxt_idcard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTxt_idcard.CustomForeColor = true;
            this.metroTxt_idcard.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxt_idcard.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTxt_idcard.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroTxt_idcard.Location = new System.Drawing.Point(17, 33);
            this.metroTxt_idcard.Multiline = true;
            this.metroTxt_idcard.Name = "metroTxt_idcard";
            this.metroTxt_idcard.Size = new System.Drawing.Size(370, 45);
            this.metroTxt_idcard.TabIndex = 52;
            this.metroTxt_idcard.Text = "เลขบัตรประจำตัวประชาชน";
            // 
            // Metro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1030, 751);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "Metro";
            this.panel1.ResumeLayout(false);
            this.grb_data.ResumeLayout(false);
            this.grb_data.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grb_smartcard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Timer timer_checksmartcard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb_data;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTxt_datetime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTxt_pr;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTxt_dia;
        private MetroFramework.Controls.MetroTextBox metroTxt_sys;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTxt_status;
        private System.Windows.Forms.GroupBox grb_smartcard;
        private MetroFramework.Controls.MetroTextBox metroTxt_province;
        private MetroFramework.Controls.MetroTextBox metroTxt_distrat;
        private MetroFramework.Controls.MetroTextBox metroTxt_subdistrat;
        private MetroFramework.Controls.MetroTextBox metroTxt_issure;
        private MetroFramework.Controls.MetroTextBox metroTxt_road;
        private MetroFramework.Controls.MetroTextBox metroTxt_lane;
        private MetroFramework.Controls.MetroTextBox metroTxt_moo;
        private MetroFramework.Controls.MetroTextBox metroTxt_houseno;
        private MetroFramework.Controls.MetroTextBox metroTxt_expire;
        private MetroFramework.Controls.MetroTextBox metroTxt_issuedate;
        private MetroFramework.Controls.MetroTextBox metroTxt_dateOfbirth;
        private MetroFramework.Controls.MetroTextBox metroTxt_gender;
        private MetroFramework.Controls.MetroTextBox metroTxt_lastname_en;
        private MetroFramework.Controls.MetroTextBox metroTxt_firstname_en;
        private MetroFramework.Controls.MetroTextBox metroTxt_prefix_en;
        private MetroFramework.Controls.MetroTextBox metroTxt_lastname_th;
        private MetroFramework.Controls.MetroTextBox metroTxt_firstname_th;
        private MetroFramework.Controls.MetroTextBox metroTxt_prefix_th;
        private MetroFramework.Controls.MetroTextBox metroTxt_idcard;
    }
}