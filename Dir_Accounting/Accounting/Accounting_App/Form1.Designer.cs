namespace Accounting_App
{
    partial class Main
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
            DevComponents.DotNetBar.Controls.ClockStyleData clockStyleData1 = new DevComponents.DotNetBar.Controls.ClockStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData1 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData2 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData3 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData1 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData4 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData5 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData2 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData6 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData3 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData7 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData8 = new DevComponents.DotNetBar.Controls.ColorData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpReport = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReciveAll = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAccountBalanceAll = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayAll = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.pcAccounting = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Clock = new DevComponents.DotNetBar.Controls.AnalogClockControl();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnEditLogin = new DevComponents.DotNetBar.BubbleButton();
            this.btnChart = new DevComponents.DotNetBar.BubbleButton();
            this.btnReportPay = new DevComponents.DotNetBar.BubbleButton();
            this.btnReportRecive = new DevComponents.DotNetBar.BubbleButton();
            this.btnReport = new DevComponents.DotNetBar.BubbleButton();
            this.btnLoan = new DevComponents.DotNetBar.BubbleButton();
            this.BtnCustomers = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleBar2 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnLuck = new DevComponents.DotNetBar.BubbleButton();
            this.btnExit = new DevComponents.DotNetBar.BubbleButton();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.lblChangeLocation = new System.Windows.Forms.Label();
            this.gpReport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gpReport
            // 
            this.gpReport.Controls.Add(this.groupBox3);
            this.gpReport.Controls.Add(this.groupBox2);
            this.gpReport.Controls.Add(this.groupBox1);
            this.gpReport.Controls.Add(this.pcAccounting);
            this.gpReport.Controls.Add(this.label1);
            this.gpReport.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpReport.Location = new System.Drawing.Point(11, 111);
            this.gpReport.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gpReport.Name = "gpReport";
            this.gpReport.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gpReport.Size = new System.Drawing.Size(711, 316);
            this.gpReport.TabIndex = 4;
            this.gpReport.TabStop = false;
            this.gpReport.Text = "گزارش ها ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(210, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "گزارش وام ها";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(30, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(153, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "دریافتی ها:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(30, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(153, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "پرداختی ها :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(152, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 33);
            this.label12.TabIndex = 0;
            this.label12.Text = "وضعیت :";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(30, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReciveAll);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblAccountBalanceAll);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblPayAll);
            this.groupBox2.Location = new System.Drawing.Point(210, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 128);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش کلی";
            // 
            // lblReciveAll
            // 
            this.lblReciveAll.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReciveAll.Location = new System.Drawing.Point(30, 37);
            this.lblReciveAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReciveAll.Name = "lblReciveAll";
            this.lblReciveAll.Size = new System.Drawing.Size(119, 25);
            this.lblReciveAll.TabIndex = 0;
            this.lblReciveAll.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(153, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "دریافتی ها:";
            // 
            // lblAccountBalanceAll
            // 
            this.lblAccountBalanceAll.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAccountBalanceAll.Location = new System.Drawing.Point(30, 90);
            this.lblAccountBalanceAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountBalanceAll.Name = "lblAccountBalanceAll";
            this.lblAccountBalanceAll.Size = new System.Drawing.Size(119, 26);
            this.lblAccountBalanceAll.TabIndex = 0;
            this.lblAccountBalanceAll.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(153, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "پرداختی ها :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(152, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "وضعیت :";
            // 
            // lblPayAll
            // 
            this.lblPayAll.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPayAll.Location = new System.Drawing.Point(30, 62);
            this.lblPayAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayAll.Name = "lblPayAll";
            this.lblPayAll.Size = new System.Drawing.Size(119, 28);
            this.lblPayAll.TabIndex = 0;
            this.lblPayAll.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAccountBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Location = new System.Drawing.Point(461, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 247);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ماه جاری";
            // 
            // lblRecive
            // 
            this.lblRecive.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecive.Location = new System.Drawing.Point(36, 37);
            this.lblRecive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(119, 25);
            this.lblRecive.TabIndex = 0;
            this.lblRecive.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(160, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "پرداختی ها :";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAccountBalance.Location = new System.Drawing.Point(36, 90);
            this.lblAccountBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(119, 26);
            this.lblAccountBalance.TabIndex = 0;
            this.lblAccountBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(160, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "دریافتی ها:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(159, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "وضعیت :";
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPay.Location = new System.Drawing.Point(36, 62);
            this.lblPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(119, 28);
            this.lblPay.TabIndex = 0;
            this.lblPay.Text = "0";
            // 
            // pcAccounting
            // 
            this.pcAccounting.Image = global::Accounting_App.Properties.Resources.Untitled_1;
            this.pcAccounting.Location = new System.Drawing.Point(5, 110);
            this.pcAccounting.Name = "pcAccounting";
            this.pcAccounting.Size = new System.Drawing.Size(199, 165);
            this.pcAccounting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAccounting.TabIndex = 9;
            this.pcAccounting.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(140, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "(( وَ یَرْزُقْهُ مِنْ حَیْثُ لا یَحْتَسِبُ وَ مَنْ یَتَوَکَّلْ عَلَی اللّهِ فَهُو" +
    "َ حَسْبُهُ إِنَّاللّهَ بالِغُ أَمْرِهِ قَدْ جَعَلَ اللّهُ لِکُلِّ شَیْء قَدْراً " +
    "))";
            // 
            // Elipse1
            // 
            this.Elipse1.ElipseRadius = 35;
            this.Elipse1.TargetControl = this;
            // 
            // Clock
            // 
            this.Clock.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            colorData1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            colorData1.BorderWidth = 0.01F;
            colorData1.BrushSBSScale = 1F;
            colorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            clockStyleData1.BezelColor = colorData1;
            colorData2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData2.BorderWidth = 0.01F;
            colorData2.BrushSBSScale = 1F;
            colorData2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockStyleData1.CapColor = colorData2;
            colorData3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            colorData3.BorderWidth = 0.01F;
            colorData3.BrushAngle = 45F;
            colorData3.BrushSBSScale = 1F;
            colorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            colorData3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            clockStyleData1.FaceColor = colorData3;
            clockStyleData1.GlassAngle = -20;
            colorData4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData4.BorderWidth = 0.01F;
            colorData4.BrushSBSScale = 1F;
            colorData4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData1.HandColor = colorData4;
            clockHandStyleData1.Length = 0.55F;
            clockHandStyleData1.Width = 0.015F;
            clockStyleData1.HourHandStyle = clockHandStyleData1;
            colorData5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData5.BorderWidth = 0.01F;
            colorData5.BrushSBSScale = 1F;
            colorData5.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            colorData5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            clockStyleData1.LargeTickColor = colorData5;
            colorData6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData6.BorderWidth = 0.01F;
            colorData6.BrushSBSScale = 1F;
            colorData6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData2.HandColor = colorData6;
            clockHandStyleData2.Length = 0.8F;
            clockHandStyleData2.Width = 0.01F;
            clockStyleData1.MinuteHandStyle = clockHandStyleData2;
            clockStyleData1.NumberFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            colorData7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData7.BorderWidth = 0.01F;
            colorData7.BrushSBSScale = 1F;
            colorData7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData3.HandColor = colorData7;
            clockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style2;
            clockHandStyleData3.Length = 0.8F;
            clockHandStyleData3.Width = 0.005F;
            clockStyleData1.SecondHandStyle = clockHandStyleData3;
            colorData8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData8.BorderWidth = 0.01F;
            colorData8.BrushSBSScale = 1F;
            colorData8.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            colorData8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            clockStyleData1.SmallTickColor = colorData8;
            clockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            this.Clock.ClockStyleData = clockStyleData1;
            this.Clock.Location = new System.Drawing.Point(3, 5);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(100, 100);
            this.Clock.TabIndex = 5;
            this.Clock.Text = "analogClockControl1";
            this.Clock.Value = new System.DateTime(2023, 4, 7, 15, 32, 38, 386);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Aviny", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDay.Location = new System.Drawing.Point(126, 64);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(35, 42);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "روز";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Aviny", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(122, 35);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 42);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "تاریخ";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Aviny", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblClock.Location = new System.Drawing.Point(129, 7);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(64, 42);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "ساعت";
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            // 
            // 
            // 
            this.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(70, 70);
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(50, 50);
            this.bubbleBar1.Location = new System.Drawing.Point(0, 435);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(733, 62);
            this.bubbleBar1.TabIndex = 6;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            this.bubbleBar1.TabsVisible = false;
            this.bubbleBar1.Text = "bubbleBar1";
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnEditLogin,
            this.btnChart,
            this.btnReportPay,
            this.btnReportRecive,
            this.btnReport,
            this.btnLoan,
            this.BtnCustomers});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "bubbleBarTab1";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLogin.Image = global::Accounting_App.Properties.Resources.settings_128__11_;
            this.btnEditLogin.ImageLarge = global::Accounting_App.Properties.Resources._010;
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.TooltipText = "تنظیمات ورود";
            this.btnEditLogin.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnEditLogin_Click_1);
            // 
            // btnChart
            // 
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChart.Image = global::Accounting_App.Properties.Resources.Line_chart_Pre;
            this.btnChart.ImageLarge = global::Accounting_App.Properties.Resources.Line_chart_Pre;
            this.btnChart.Name = "btnChart";
            this.btnChart.TooltipText = "نمودار دخل";
            this.btnChart.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnChart_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportPay.Image = global::Accounting_App.Properties.Resources._1493124785_cabinet;
            this.btnReportPay.ImageLarge = global::Accounting_App.Properties.Resources._1493124785_cabinet;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.TooltipText = "گزارش پرداختی ها";
            this.btnReportPay.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportRecive.Image = global::Accounting_App.Properties.Resources._1493124785_cabinet;
            this.btnReportRecive.ImageLarge = global::Accounting_App.Properties.Resources._1493124785_cabinet;
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.TooltipText = "گزارش دریافتی ها";
            this.btnReportRecive.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnReportRecive_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Image = global::Accounting_App.Properties.Resources._1493124773_calculator;
            this.btnReport.ImageLarge = global::Accounting_App.Properties.Resources._1493124773_calculator;
            this.btnReport.Name = "btnReport";
            this.btnReport.TooltipText = "ثبت گزارش";
            this.btnReport.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnReport_Click_1);
            // 
            // btnLoan
            // 
            this.btnLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnLoan.ImageLarge")));
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.TooltipText = "وام ها";
            this.btnLoan.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnLoan_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.Image = global::Accounting_App.Properties.Resources._1493124790_cashbox;
            this.BtnCustomers.ImageLarge = global::Accounting_App.Properties.Resources._1493124790_cashbox;
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.TooltipText = "لیست اشخاص";
            this.BtnCustomers.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnCustomers_Click);
            // 
            // bubbleBar2
            // 
            this.bubbleBar2.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar2.AntiAlias = true;
            this.bubbleBar2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.bubbleBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar2.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar2.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar2.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar2.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar2.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar2.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar2.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar2.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar2.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar2.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar2.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar2.ImageSizeLarge = new System.Drawing.Size(55, 55);
            this.bubbleBar2.ImageSizeNormal = new System.Drawing.Size(40, 40);
            this.bubbleBar2.Location = new System.Drawing.Point(591, -4);
            this.bubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar2.Name = "bubbleBar2";
            this.bubbleBar2.SelectedTab = this.bubbleBarTab2;
            this.bubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar2.Size = new System.Drawing.Size(158, 54);
            this.bubbleBar2.TabIndex = 7;
            this.bubbleBar2.Tabs.Add(this.bubbleBarTab2);
            this.bubbleBar2.TabsVisible = false;
            this.bubbleBar2.Text = "bubbleBar2";
            // 
            // bubbleBarTab2
            // 
            this.bubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab2.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnLuck,
            this.btnExit});
            this.bubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab2.Name = "bubbleBarTab2";
            this.bubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab2.Text = "bubbleBarTab1";
            this.bubbleBarTab2.TextColor = System.Drawing.Color.Black;
            // 
            // btnLuck
            // 
            this.btnLuck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuck.Image = ((System.Drawing.Image)(resources.GetObject("btnLuck.Image")));
            this.btnLuck.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnLuck.ImageLarge")));
            this.btnLuck.Name = "btnLuck";
            this.btnLuck.TooltipText = "قفل برنامه";
            this.btnLuck.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnLuck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Accounting_App.Properties.Resources._5346703;
            this.btnExit.ImageLarge = global::Accounting_App.Properties.Resources._5346703;
            this.btnExit.Name = "btnExit";
            this.btnExit.TooltipText = "خروج";
            this.btnExit.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnExit_Click);
            // 
            // popupNotifier
            // 
            this.popupNotifier.BodyColor = System.Drawing.Color.DarkGray;
            this.popupNotifier.ContentFont = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifier.ContentText = null;
            this.popupNotifier.Image = global::Accounting_App.Properties.Resources._1493124773_calculator;
            this.popupNotifier.ImageSize = new System.Drawing.Size(90, 90);
            this.popupNotifier.IsRightToLeft = true;
            this.popupNotifier.OptionsMenu = null;
            this.popupNotifier.Size = new System.Drawing.Size(370, 120);
            this.popupNotifier.TitleFont = new System.Drawing.Font("Aviny", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifier.TitleText = null;
            // 
            // lblChangeLocation
            // 
            this.lblChangeLocation.AutoSize = true;
            this.lblChangeLocation.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblChangeLocation.Font = new System.Drawing.Font("Aviny", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChangeLocation.Location = new System.Drawing.Point(329, -12);
            this.lblChangeLocation.Name = "lblChangeLocation";
            this.lblChangeLocation.Size = new System.Drawing.Size(75, 47);
            this.lblChangeLocation.TabIndex = 8;
            this.lblChangeLocation.Text = "-----";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(733, 497);
            this.ControlBox = false;
            this.Controls.Add(this.lblChangeLocation);
            this.Controls.Add(this.bubbleBar2);
            this.Controls.Add(this.bubbleBar1);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.gpReport);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDay);
            this.Font = new System.Drawing.Font("Aviny", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابدار شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gpReport.ResumeLayout(false);
            this.gpReport.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gpReport;
        public System.Windows.Forms.Label lblAccountBalance;
        private DevComponents.DotNetBar.Controls.AnalogClockControl Clock;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
#pragma warning disable CS0169 // The field 'Form1.tnRefreshReport' is never used
        private DevComponents.DotNetBar.BubbleButton tnRefreshReport;
#pragma warning restore CS0169 // The field 'Form1.tnRefreshReport' is never used
        private DevComponents.DotNetBar.BubbleButton btnReportPay;
        private DevComponents.DotNetBar.BubbleButton btnReportRecive;
        private DevComponents.DotNetBar.BubbleButton btnReport;
        private DevComponents.DotNetBar.BubbleButton BtnCustomers;
        private DevComponents.DotNetBar.BubbleBar bubbleBar2;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab2;
        private DevComponents.DotNetBar.BubbleButton btnExit;
        private DevComponents.DotNetBar.BubbleButton btnChart;
        private DevComponents.DotNetBar.BubbleButton btnEditLogin;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuElipse Elipse1;
        public System.Windows.Forms.PictureBox pcAccounting;
        private DevComponents.DotNetBar.BubbleButton btnLuck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblReciveAll;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblAccountBalanceAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPayAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevComponents.DotNetBar.BubbleButton btnLoan;
        private System.Windows.Forms.Label lblChangeLocation;
        public Tulpep.NotificationWindow.PopupNotifier popupNotifier;
    }
}

